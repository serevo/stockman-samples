# STOCK-MAN モジュール サンプル

STOCK-MAN   (開発コードネーム: Storex [^1]) アプリ用モジュールの開発を支援するためのサンプルです。これらのサンプルはクイックスタートとして素早く内容を理解してモジュールの開発を開始できるよう、副次的な内容は極力省かれています。また単純なテキストファイルやフォルダに読み書きする内容になっていますので、そのままバイナリをダウンロードして組み込み、アプリをまずは「使ってみる」こともできます。



STOCK-MAN やモジュール開発の概要については次のページをご覧ください。

- [STOCK-MAN](https://docs.serevo.net/stockman) 

- [モジュール開発 - STOCK-MAN ガイド](https://docs.serevo.net/stockman/modules-dev)

  

[^1]: コードネームは各種ファイル名やパッケージ名、ソースコードの他、GitHub 等の開発者用向けサービスやリソースのURL にも使用しています。

 

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

データ保管モジュールは、STOCK-MANアプリで検出されたシンボルから主要なラベルを特定する役割と、データを保存する役割を持ち、このサンプルでは下記の条件で行います。

#### 1.データの保存
１つのファイル (概要データ) と１つのフォルダー (詳細データ) でデータを管理します。
 - 概要データ：プライマリ/セカンダリ ラベルの品番とシリアルナンバー、作業者、タイムスタンプを書き込むログファイル
 - 詳細データ：画像と取得シンボル一覧、タグ情報の入ったフォルダをタイムスタンプ毎に作成

 次の型を使用します。

 - `SecondaryLabelCriteria`: 品番確認動作の定義
 - `ConfigForm1`: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0)。上記のファイルとフォルダのパスを指定します。

#### 2.プライマリ ラベルの指定
 テキストの開始文字、品番/シリアルの開始位置と文字数をモード設定として保存します。モジュール設定の条件を満たす単一シンボルをプライマリ ラベルとしてSTOCK-MANアプリに返します。次の型を使用します。

 - `FixedLengthSpec`:プライマリ ラベルの定義 
 - `ModeConfigForm1`:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
 
#### 3.セカンダリ ラベルの指定・品番確認
 - C-3 ラベル/単一シンボルラベルをセカンダリ ラベルの対象とするかの指定
 1. プライマリラベルの品番と 一致する品番を持つ 対象ラベル
 2. CSVファイル (プライマリ ラベル品番 と指定品番)で指定された品番を持つ 対象ラベル
 3. 1と2に当てはまらない C-3 ラベル(対象のとき) 
 4. 上記を満たすセカンダリ ラベルが存在しないときの保存時動作

 - 1～3のラベルに対し、有効(許可・警告)、無効(拒否)を指定します。有効のとき上記条件を満たし、かつプライマリラベルの定義に当てはまらないラベルをセカンダリラベルの一覧として返します。保存の際に指定されたセカンダリ ラベルが警告の条件と一致する場合、警告ダイアログを表示し保存の続行・中止を選択します。
 - 4に対しては許可・警告・拒否・タグによる照合(警告・拒否)を指定します。警告の場合は警告ダイアログを表示し保存の続行・中止を選択、拒否の場合エラーダイアログを表示し保存を中止します。タグによる照合が指定されている場合、1,2で有効に指定されている品番がタグに含まれているかを確認し、含まれている場合は1,2と同じ動作を、含まれていない場合は警告ダイアログ、又はエラーダイアログを表示します。
 上記の内容をモード設定として保存します。次の型を使用します。
 
 - `FixedLengthSpec`:プライマリ ラベルの定義 
 - `SecondaryLabelCriteria`: セカンダリ ラベルと品番確認動作の定義
 - `SecondaryLabelTypes`: セカンダリ ラベル有効ラベルの列挙体
 - `SecondaryNoLabelBehavior`: 記録時のセカンダリ ラベルがない時の品番確認動作の列挙体
 - `SecondaryLabelBehavior`: セカンダリ ラベルの特定や品番確認時動作の列挙体
 - `ConfigForm1`: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 。対応表ファイルの場所を保存します。
 - `ModeConfigForm1`:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 

 このモジュールでは他に次の型を使用します。
  - `RepositoryModuleHelper`: 画像ファイルの書込み、対応表ファイルの読込、メッセージダイアログの共通化の機能を持つヘルパー
