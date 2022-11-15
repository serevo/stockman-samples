# STOCK-MAN サンプル

SHINSEI ELECTRONCS CO.,LTD. の STOCK-MAN 用モジュールの開発を支援するためサンプルとガイドです。



## STOCK-MAN SDK

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Storex.Core)](https://www.nuget.org/packages/Storex.Core)

新規でモジュールを開発する場合は、上部のバッジをクリックして [nuget.org](https://www.nuget.org/)  で公開された適切なバージョンの [NuGet](https://learn.microsoft.com/ja-jp/nuget/) パッケージをプロジェクトに追加してください。本サンプルでは既に追加されています。



### API リファレンス

[![Storex.Core on fuget.org](https://www.fuget.org/packages/Storex.Core/badge.svg)](https://www.fuget.org/packages/Storex.Core)

SDK で提供される API のリファレンスです。必要に応じて参照してください。



## モジュール サンプル

このリポジトリでサンプルとして提供する各モジュールについて、概要を説明します。導入先のシステム環境に応じてこれらのサンプルコードを改造してアプリに組み込みます。

### AuthenticationModule1 [/src/AuthenticationModules](https://github.com/serevo/storex-samples/tree/main/src/AuthenticationModules1)

CSVファイル (ID と 氏名)  を使用し、ダイアログボックスでユーザーに入力された ID で認証します。モジュール設定として CSV ファイルを選択します。他の次の型を使用します。
  - AuthenticationForm1: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - User:  認証結果として返す `IUser` インターフェイス実装\
  - AuthenticationModuleHelper:  ファイル入出力用ヘルパー

    

### AuthenticationModule2 [/src/AuthenticationModules](https://github.com/serevo/storex-samples/tree/main/src/AuthenticationModules1)

CSVファイル (ID と 氏名)  を使用し、ユーザーが氏名を一覧から選択して認証します。モジュール設定として CSV ファイルを選択します。他の次の型を使用します。

  - AuthenticationForm2: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0)
  - User:  認証結果で返す `IUser` インターフェイスの実装
  - AuthenticationModuleHelper:  ファイル入出力用ヘルパー

### RepositoryModule1 [/src/RepositoryModules1](https://github.com/serevo/storex-samples/tree/main/src/RepositoryModules1)

１つの概要データファイルと１箇所の詳細データフォルダーでデータを保管します。モジュール設定としてダイアログボックスでこれらの場所を選択します。データ保管モジュールは、アプリで検出されたシンボルから必要なラベルを特定する役割もありますが、このサンプルではプライマリ ラベル として特定文字ではじまる固定長書式を、セカンダリ ラベルとして C-3 ラベルを扱うよう、モードの設定で構成します。他の次の型を使用します。

  - ConfigForm1: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - ModeConfigForm1:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - LabelDefinition1: プライマリ ラベル用の 固定長の 定義とロジック



## MEF とメタデータ




AuthenticationModule (VB)
``` VB
' AuthenticationModule1.VB

Imports System.ComponentModel.Composition
<Export(GetType(IAuthenticationModule))>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Id), "FCB29577-7E5B-4B0C-A514-B8E636AAF13D")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.DisplayName), "簡易認証 (ID入力)")>
<ExportMetadata(NameOf(IAuthenticationModuleMetadata.Description), "CSVファイル (ID と 氏名) を使用します")>
Public Class AuthenticationModule1
    Implements IAuthenticationModule
```

AuthenticationModule (C#)
``` CS
// AuthenticationModule1.CS
using System.ComponentModel.Composition;

[Export(typeof(IAuthenticationModule))]
[ExportMetadata(nameof(IAuthenticationModuleMetadata.Id), "FCB29577-7E5B-4B0C-A514-B8E636AAF13D")]
[ExportMetadata(nameof(IAuthenticationModuleMetadata.DisplayName), "簡易認証 (ID入力)")]
[ExportMetadata(nameof(IAuthenticationModuleMetadata.Description), "CSVファイル (ID と 氏名) を使用します")]
public class AuthenticationModule1 : IAuthenticationModule

```


RepositoryModule (VB)
``` VB
' RepositoryModule1.VB

Imports System.ComponentModel.Composition

<Export(GetType(IRepositoryModule))>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Id), "E0B3F83A-B417-43DB-8CCF-9916A2EB63C6")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.DisplayName), "簡易ファイルシステム")>
<ExportMetadata(NameOf(IRepositoryModuleMetadata.Description), "モードでシンボル内容等を設定します")>
Public Class RepositoryModule1
    Implements IRepositoryModule
```

RepositoryModule (CS)
``` CS
' RepositoryModule1.CS

using System.ComponentModel.Composition;

[Export(typeof(IRepositoryModule))]
[ExportMetadata(nameof(IRepositoryModuleMetadata.Id), "E0B3F83A-B417-43DB-8CCF-9916A2EB63C6")]
[ExportMetadata(nameof(IRepositoryModuleMetadata.DisplayName), "簡易ファイルシステム")]
[ExportMetadata(nameof(IRepositoryModuleMetadata.Description), "モードでシンボル内容等を設定します")]
public class RepositoryModule1 : IRepositoryModule

```



