using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

            var c3Labels = sources
                .Where(_ => (_secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.C3Label) == SecondaryLabelTypes.C3Label)
                .OfType<C3Label>()
                .Where(o => 
                    (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior != SecondaryLabelBehavior.Deny && o.PartNumber == primary.ItemNumber)
                    | (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior != SecondaryLabelBehavior.Deny && validConditionValues.Contains(o.PartNumber))
                    | (_secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior != SecondaryLabelBehavior.Deny && o.PartNumber != primary.ItemNumber & !validConditionValues.Contains(o.PartNumber))
                    )
                .ToList();

            labels.AddRange(c3Labels);

            var singleSymbolLabels = sources
                .Where(_ => (_secondaryLabelCriteria.AcceptableTypes & SecondaryLabelTypes.SingleSymbol) == SecondaryLabelTypes.SingleSymbol)
                .OfType<Symbol>()
                .Select(o => new BasicLabel(o) { ItemNumber = o.Value })
                .Where(o => 
                    (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior != SecondaryLabelBehavior.Deny & o.ItemNumber == primary.ItemNumber)
                    | (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior != SecondaryLabelBehavior.Deny & validConditionValues.Contains(o.ItemNumber))
                    )
                .ToList();

            labels.AddRange(singleSymbolLabels);

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

            if(secondary is null) 
            {
                if(_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.Warnning
                    && !MessageHelper.AlertShow("セカンダリ ラベルが必要です。無視して登録しますか。")) 
                {
                    return false;
                }
                else if(_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.Deny)
                {
                    MessageHelper.ErrorShow("セカンダリ ラベルが必要です。");
                    return false;
                }
                else if (_secondaryLabelCriteria.NoLabelBehavior != SecondaryNoLabelBehavior.Default) 
                {
                    var hasItemNumberEqualsToPrimary = tags.Any(o => o == primary.ItemNumber);
                    var hasSpecifiedByConditionFile = tags.Any(o => _conditions.Any(p => p.PrimaryLabelItemNumber == primary.ItemNumber & o == p.ValidValue));

                    if (_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.WarningWhenTagNotMatched 
                        && !hasItemNumberEqualsToPrimary && !hasSpecifiedByConditionFile
                        && !MessageHelper.AlertShow("セカンダリ ラベル、又は対応するタグが必要です。無視して登録しますか。"))
                    {
                        return false;
                    }
                    else if (_secondaryLabelCriteria.NoLabelBehavior == SecondaryNoLabelBehavior.DenyWhenTagNotMatched
                        && !hasItemNumberEqualsToPrimary && !hasSpecifiedByConditionFile)
                    {
                        MessageHelper.ErrorShow("セカンダリ ラベル、又は対応するタグがが必要です。");
                        return false;
                    }
                    else if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior == SecondaryLabelBehavior.Warnning
                        && hasItemNumberEqualsToPrimary 
                        && _secondaryLabelCriteria.SpecifiedByConditionFileBehavior == SecondaryLabelBehavior.Warnning
                        && hasSpecifiedByConditionFile
                        && !MessageHelper.AlertShow("プライマリラベルの品番、及び対応表で指定されている品番と一致する文字がタグに含まれています。登録しますか。"))
                    {
                        return false;
                    }
                    else if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior == SecondaryLabelBehavior.Warnning
                        && hasItemNumberEqualsToPrimary
                        && !MessageHelper.AlertShow("プライマリラベルの品番と一致する文字がタグに含まれています。登録しますか。"))
                    {
                        return false;
                    }
                    else if (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior == SecondaryLabelBehavior.Warnning
                        && hasSpecifiedByConditionFile
                        && !MessageHelper.AlertShow("対応表で指定されている品番と一致する文字がタグに含まれています。登録しますか。"))
                    {
                        return false;
                    }
                }
            }
            else if (_secondaryLabelCriteria.ItemNumberEqualsToPrimaryOneBehavior == SecondaryLabelBehavior.Warnning
                && primary.ItemNumber == secondary.ItemNumber
                && !MessageHelper.AlertShow("セカンダリ ラベルは、プライマリラベルの品番と一致するものが選択されています。登録を続行しますか。"))
            {
                return false;
            }
            else if (_secondaryLabelCriteria.SpecifiedByConditionFileBehavior == SecondaryLabelBehavior.Warnning
                && _conditions.Any(o => o.PrimaryLabelItemNumber == primary.ItemNumber & o.ValidValue == secondary.ItemNumber)
                && !MessageHelper.AlertShow("指定された セカンダリ ラベルは、プライマリ ラベルの品番とは一致しませんが対応表で指定されている品番です。登録を続行しますか。"))
            {
                return false;
            }
            else if (_secondaryLabelCriteria.OtherNotSingleSymbolLabelsBehavior == SecondaryLabelBehavior.Warnning
                && primary.ItemNumber != secondary.ItemNumber
                && !_conditions.Any(o => o.PrimaryLabelItemNumber == primary.ItemNumber & o.ValidValue == secondary.ItemNumber)
                && !MessageHelper.AlertShow("C-3 ラベルはプライマリラベルや対応表と一致しない品番が選択されています。登録しますか。"))
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