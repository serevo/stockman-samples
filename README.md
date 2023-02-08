# STOCK-MAN モジュール サンプル

STOCK-MAN アプリ用モジュールの開発を支援するためのサンプルです。これらのサンプルはクイックスタートとして素早く内容を理解してモジュールの開発を開始できるよう、副次的な内容は極力省かれています。また単純なテキストファイルやフォルダに読み書きする内容になっていますので、そのままバイナリをダウンロードして組み込み、アプリをまずは「使ってみる」こともできます。



STOCK-MAN やモジュール開発の概要については次のページをご覧ください。

- [STOCK-MAN](https://docs.serevo.net/stockman) 
- [モジュール開発 - STOCK-MAN ガイド](https://docs.serevo.net/stockman/modules-dev)



## バイナリのダウンロード

1. [リリース](https://github.com/serevo/storex-samples/releases) ページより任意のバージョンの bin.zip をダウンロードします。バージョン番号は `{SDKのバージョン}-{日付(年月日各２桁/コミット日)}(.{同日内連番})` となっています。モジュールで使用可能な SDK のバージョンは、原則アプリで直接参照する SDK とメジャー番号が同じで、且つマイナー番号が同じか低いものとなっています。例えばアプリで v1.2.0 が参照されている場合、モジュールで使用可能なのは v1.0.0 以上 v1.3.0 未満です。

2. ダウンロードしたファイルが Windows で ZoneID によりマークされている場合、それらのファイルはブロックされ正常に読み込めません。必要に応じて [ブロックを解除](https://learn.microsoft.com/ja-jp/deployoffice/security/internet-macros-blocked#guidance-on-allowing-vba-macros-to-run-in-files-you-trust) します。
3. bin.zip を解凍して使用します。



## サンプルの種類

サンプルには次の３種類のモジュールが含まれており、それぞれが Visual Basic .NET と C# の両方で書かれています。尚、ビルド後のファイルは全て `src\bin` フォルダーに出力されます。




### `AuthenticationModule1`

CSVファイル (ID と 氏名)  を使用し、ダイアログボックスでユーザーに入力された ID で認証します。モジュール設定として CSV ファイルを選択します。他に次の型も使用します。
  - `AuthenticationForm1`: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `User`:  認証結果として返す `IUser` インターフェイス実装
  - `AuthenticationModuleHelper`:  ファイル入出力用ヘルパー



### `AuthenticationModule2`

CSVファイル (ID と 氏名)  を使用し、ユーザーが氏名を一覧から選択して認証します。モジュール設定として CSV ファイルを選択します。他に次の型も使用します。

  - `AuthenticationForm2`: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0)
  - `User`:  認証結果で返す `IUser` インターフェイスの実装
  - `AuthenticationModuleHelper`:  ファイル入出力用ヘルパー



### `RepositoryModule1`

１つのファイル (概要データ) と１つのフォルダー (詳細データ) でデータを管理します。モジュール設定としてダイアログボックスでこれらの場所を選択します。データ保管モジュールは、検出されたシンボルから主要なラベルを特定する役割もありますが、このサンプルではプライマリ ラベル として指定文字で始まる固定長テキストと、セカンダリ ラベルとして C-3 ラベルを扱うよう、モードの設定で構成します。他に次の型も使用します。

  - `ConfigForm1`: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `ModeConfigForm1`:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `FixedLengthSpec`: プライマリ ラベル用 固定長テキスト定義とロジック
  - `SecondaryLabelCriteria`: セカンダリ ラベル 条件



## モジュール設定の永続化

各モジュールの設定について、設定値の永続化には [WAP Tool-kit](https://github.com/serevo/wap-toolkit) の `WapDataContainerSettingsProvider` を使用します。詳しくはこのページの冒頭に記載のガイドをご覧ください。
