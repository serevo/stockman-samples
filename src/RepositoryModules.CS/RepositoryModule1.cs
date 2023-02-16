using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storex;

namespace RepositoryModules
{
    [RepositoryModuleExport("E0B3F83A-B417-43DB-8CCF-9916A2EB63C6", "簡易ファイルシステム", Description = "モードでシンボル内容等を設定します")]
    public class RepositoryModule1 : IRepositoryModule
    {
        static readonly Encoding _textEncoding = Encoding.GetEncoding("shift_jis");

        IMode _currentMode;
        IUser _currentUser;

        public bool IsConfiguable { get; private set; } = true;

        public bool IsModeConfiguable { get; private set; } = true;

        public bool CanConfigureMode => true;

        public Task ConfigureAsync(CancellationToken cancellationToken)
        {
            ConfigForm1.Configure();

            return Task.CompletedTask;
        }

        public Task ConfigureModeAsync(IMode mode, CancellationToken cancellationToken)
        {
            ModeConfigForm1.Configure(mode);

            return Task.CompletedTask;
        }

        public Task<bool> PrepareAsync(IMode Mode, IUser UserInfo, CancellationToken cancellationToken)
        {
            if (!File.Exists(MySettings.Default.FilePath))
            {
                throw new RepositoryModuleException("概要データ ファイルが正しく設定されていません。");
            }

            if (!Directory.Exists(MySettings.Default.FolderPath))
            {
                throw new RepositoryModuleException("詳細データ フォルダが正しく設定されていません。");
            }

            if (!Mode.TryExtractProperty<FixedLengthSpec>(FixedLengthSpec.PropertyKeyForPrimary, out _priaryLabelFixedLengthSpec) |
                !Mode.TryExtractProperty<SecondaryLabelCriteria>(SecondaryLabelCriteria.PropertyKey, out _secondaryLabelCriteria))
            {
                throw new RepositoryModuleException("モードが構成されていません。");
            }

            _conditions = RepositoryModuleHelper.ReadSecondaryConditionsFile();

            _currentMode = Mode;
            _currentUser = UserInfo;

            return Task.FromResult(true);
        }

        FixedLengthSpec _priaryLabelFixedLengthSpec;

        public Task<ILabel> FindPrimaryLabelAsync(ILabelSource[] sources, CancellationToken cancellationToken)
        {
            var labels = sources
                .OfType<Symbol>()
                .Select(x => _priaryLabelFixedLengthSpec.TryGeneraLabel(x, out var label) ? label : null)
                .Where(x => x != null)
                .ToArray();

            return Task.FromResult(labels.Length == 1 ? labels[0] : null);
        }

        SecondaryLabelCriteria _secondaryLabelCriteria;
        IReadOnlyList<Condition> _conditions;

        public Task<ILabel[]> FindSecondaryLabelsAsync(ILabel primary, ILabelSource[] sources, CancellationToken cancellationToken)
        {
            var labels = new List<ILabel>();

            var validConditionValues = _conditions
                .Where(o => o.PrimaryLabelItemNumber == primary.ItemNumber)
                .Select(o => o.ValidValue)
                .ToList();

            if ((_secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.C3Label) == SecondaryLabelTypes.C3Label)
            {
                var c3Labels = sources.OfType<C3Label>().ToList();

                if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior != SecondaryLabelBehavior.Deny)
                {
                    var matchedPartNumC3Labels = c3Labels
                        .Where(x => x.PartNumber == primary.ItemNumber)
                        .ToList();

                    labels.AddRange(matchedPartNumC3Labels);
                }

                if (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior != SecondaryLabelBehavior.Deny)
                {
                    var matchedConditionC3Labels = c3Labels
                        .Where(x => validConditionValues.Contains(x.PartNumber))
                        .ToList();

                    labels.AddRange(matchedConditionC3Labels);
                }

                if (_secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior != SecondaryLabelBehavior.Deny)
                {
                    var otherC3Labels = c3Labels
                        .Where(x => x.PartNumber != primary.ItemNumber)
                        .Where(x => !validConditionValues.Contains(x.PartNumber))
                        .ToList();

                    labels.AddRange(otherC3Labels);
                }
            }

            if((_secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.SingleSymbol) == SecondaryLabelTypes.SingleSymbol)
            {
                var singleSymbolLabels = sources
                    .OfType<Symbol>()
                    .Select(o => new BasicLabel(o) { ItemNumber = o.Value})
                    .ToList();

                if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior != SecondaryLabelBehavior.Deny)
                {
                    var matchedSymbols = singleSymbolLabels
                        .Where(x => x.ItemNumber == primary.ItemNumber)
                        .ToList();

                    labels.AddRange(matchedSymbols);
                }

                if (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior != SecondaryLabelBehavior.Deny)
                {
                    var matchedConditionC3Labels = singleSymbolLabels
                        .Where(x => validConditionValues.Contains(x.ItemNumber))
                        .ToList();

                    labels.AddRange(matchedConditionC3Labels);
                }
            }

            return Task.FromResult(labels.Distinct().ToArray());
        }

        public async Task<bool> RegisterAsync(ILabel primary, ILabel secondary, CaptureData[] captureDatas, string[] tags, CancellationToken cancellationToken)
        {
            if (!File.Exists(MySettings.Default.FilePath))
            {
                throw new RepositoryModuleException("概要データ ファイルが存在しません。");
            }

            if (!Directory.Exists(MySettings.Default.FolderPath))
            {
                throw new RepositoryModuleException("詳細データ フォルダが存在しません。");
            }

            if(secondary is null 
                && _secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.Warnning
                && MessageBox.Show("セカンダリ ラベルが必要です。無視して登録しますか。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return false;
            }
            else if (secondary is null && _secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.Deny)
            {
                MessageBox.Show("セカンダリ ラベルが必要です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            else if(secondary is null
                && (_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.TagRequest | _secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.TagRequired)
                && !tags.Any(o => o == primary.ItemNumber | _conditions.Any(p => p.PrimaryLabelItemNumber == primary.ItemNumber & p.ValidValue == o)))
            {
                if(_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.TagRequest
                    && MessageBox.Show("セカンダリ ラベル、又は対応するタグが必要です。無視して登録しますか。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes) 
                {
                    return false;
                }
                else if (_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.TagRequired)
                {
                    MessageBox.Show("セカンダリ ラベル、又は対応するタグが必要です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior == SecondaryLabelBehavior.Warnning
                && primary.ItemNumber == secondary.ItemNumber
                && MessageBox.Show("セカンダリ ラベルは、プライマリラベルの品番と一致するものが選択されています。登録を続行しますか。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return false;
            }
            else if (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior == SecondaryLabelBehavior.Warnning
                && _conditions.Any(o => o.PrimaryLabelItemNumber == primary.ItemNumber & o.ValidValue== secondary?.ItemNumber)
                && MessageBox.Show("指定された セカンダリ ラベルは、プライマリ ラベルの品番とは一致しませんが対応表で指定されている品番です。登録を続行しますか。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return false;
            }            
            else if (_secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior == SecondaryLabelBehavior.Warnning
                && secondary != null 
                && primary.ItemNumber != secondary.ItemNumber
                && !_conditions.Any(o => o.PrimaryLabelItemNumber == primary.ItemNumber & o.ValidValue == secondary.ItemNumber)
                && MessageBox.Show("C-3 ラベルはプライマリラベルや対応表と一致しないものが選択されています。登録しますか。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            { 
                return false;             
            }

            var timestamp = DateTime.Now;

            var myFile = new FileInfo(MySettings.Default.FilePath);

            using (var sw = new StreamWriter(myFile.FullName, true, _textEncoding))
            {
                if (myFile.Length == 0L)
                {
                    await sw.WriteLineAsync(string.Join("\t", new string[]
                    {
                        "PrimaryPartNumber",
                        "PrimarySerialNumber",
                        "SecondaryPartNumber",
                        "SecondarySerialNumber",
                        "ModeId",
                        "UserName",
                        "Timestamp",
                    }));
                }

                await sw.WriteLineAsync(string.Join("\t", new string[]
                {
                    primary.ItemNumber,
                    primary.SerialNumber,
                    secondary?.ItemNumber,
                    secondary?.SerialNumber,
                    _currentMode.Id.ToString(),
                    _currentUser?.DisplayName,
                    $"{timestamp:yyyy/MM/dd HH:mm:ss.fff}",
                }));
            }

            var mFolder = new DirectoryInfo(MySettings.Default.FolderPath);

            mFolder = mFolder.CreateSubdirectory($"{timestamp:yyyy-MM-dd HH-mm-ss.fff}");

            for (int i = 1, loopTo = captureDatas.Count(); i <= loopTo; i++)
            {
                var captureData = captureDatas[i - 1];

                var captureDataFolder = mFolder.CreateSubdirectory($"catpure#{i}");

                File.WriteAllBytes($@"{captureDataFolder.FullName}\original.jpg", (byte[])captureData.OriginalImage);

                if (captureData.AdornedImage != null)
                {
                    File.WriteAllBytes($@"{captureDataFolder.FullName}\adorned.jpeg", (byte[])captureData.AdornedImage);
                }

                if (captureData.LabelSources.Count > 0)
                {
                    var symbolValues = captureData.LabelSources.SelectMany(x => x.Symbols.Select(xx => xx.Value)).ToArray();

                    File.WriteAllLines($@"{captureDataFolder.FullName}\symbols.txt", symbolValues);
                }
            }

            if (tags.Length > 0)
            {
                File.WriteAllLines($@"{mFolder.FullName}\tags.txt", tags);
            }

            return true;
        }

        public void Dispose()
        {
        }
    }
}