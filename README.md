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

#### データの保存
１つのファイル (概要データ) と１つのフォルダー (詳細データ) でデータを管理します。
- 概要データ：プライマリ/セカンダリ ラベルの品番とシリアルナンバー、作業者、タイムスタンプを書き込むログファイル
- 詳細データ：画像と取得シンボル一覧、タグ情報の入ったフォルダをタイムスタンプ毎に作成


#### プライマリ ラベルの指定
 テキストの開始文字、品番/シリアルの開始位置と文字数をモード設定として保存します。モジュール設定の条件を満たす単一シンボルをプライマリ ラベルとしてSTOCK-MANアプリに返します。次の型を使用します。

 - `FixedLengthSpec`:プライマリ ラベルの定義 

 
#### セカンダリ ラベルの指定・品番確認
 有効ラベル種類、品番確認動作をモード設定として保存します。プライマリ ラベルとモジュール設定から条件を満たすラベルをセカンダリ ラベルとしてSTOCK-MANアプリに返します。またデータ保存時にモジュールの品番確認動作設定を元に登録や警告表示、保存の中止を行います。

 - `SecondaryLabelCriteria`: セカンダリ ラベルと品番確認動作の定義
 - `SecondaryLabelTypes`: セカンダリ ラベル有効ラベルの列挙体
 - `SecondaryNoLabelBehavior`: 記録時のセカンダリ ラベルがない時の品番確認動作の列挙体
   - `Default` : 警告なしで登録。設定画面では「許可」と表示
   - `Warnning` : 警告ダイアログを出し「はい」で登録、「いいえ」で記録中止。設定画面では「警告」と表示
   - `Deny` : エラーダイアログを出し記録中止。設定画面では「拒否」と表示 
   - `WarningWhenTagNotMatched` : タグで品番照合を行い記録。照合できない場合、警告ダイアログを出し「はい」で登録、「いいえ」で記録中止。設定画面では「タグで品番照合 (合致しない場合警告)」と表示
   - `DenyWhenTagNotMatched` : タグで品番照合を行い記録。照合できない場合、エラーダイアログを出し記録中止。設定画面では「タグで品番照合 (合致しない場合拒否)」と表示
    
 - `SecondaryLabelBehavior`: セカンダリ ラベルの特定や品番確認時動作の列挙体
   - `Default` :　各項目の条件を満たすラベルをセカンダリ ラベルとして取得。 記録時には警告なしで登録。設定画面では「許可」と表示
   - `Warnning` : 各項目の条件を満たすラベルをセカンダリ ラベルとして取得。 記録時には警告ダイアログを出し「はい」で登録、「いいえ」で記録中止。設定画面では「警告」と表示
   - `Deny` : 各項目の条件を満たすラベルをセカンダリ ラベルとして取得

#### 設定UI
  - `ConfigForm1`: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 。データ記録ファイル/フォルダ、対応表ファイルの場所を保存します。
  - `ModeConfigForm1`:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 。プライマリ/セカンダリ ラベルの定義を保存します。
