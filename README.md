# STOCK-MAN モジュール サンプル

STOCK-MAN アプリ用モジュールの開発を支援するためのサンプルです。これらのサンプルはクイックスタートとして素早く内容を理解してモジュールの開発を開始できるよう、副次的な内容は極力省かれています。また単純なテキストファイルやフォルダに読み書きする内容になっていますので、そのままビルドして組み込み、「アプリをまずは使ってみるため」こともできます。



STOCK-MAN やモジュール開発の概要については次のページをご覧ください。

- [STOCK-MAN](https://docs.serevo.net/stockman) 
- [モジュール開発 - STOCK-MAN ガイド](https://docs.serevo.net/stockman/modules-dev)



## サンプルの種類

サンプルには次の３種類のモジュールが含まれており、それぞれが Visual Basic .NET と C# の両方で書かれています。尚、ビルド後のファイルは全て `src\bin` フォルダーに出力されます。

- AuthenticationModule1: ユーザー認証モジュール
- AuthenticationModule2 ユーザー認証モジュール
- RepositoryModule1: データ保管モジュール



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
