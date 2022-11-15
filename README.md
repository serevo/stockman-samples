# STOCK-MAN モジュール サンプル & 開発ガイド

STOCK-MAN アプリ用モジュールの開発を支援するためのサンプルとガイドです。サンプルはそのままビルドして組み込み、アプリを「とりあえず使ってみる」ために活用することもできます。



## STOCK-MAN SDK

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Storex.Core)](https://www.nuget.org/packages/Storex.Core)

新規でモジュールを開発する場合は、[nuget.org](https://www.nuget.org/)  で公開されている適切なバージョンの [NuGet](https://learn.microsoft.com/ja-jp/nuget/) パッケージへの参照をプロジェクトに追加してください。本サンプル内のプロジェクトには既に追加されています。



### API リファレンス

[![Storex.Core on fuget.org](https://www.fuget.org/packages/Storex.Core/badge.svg)](https://www.fuget.org/packages/Storex.Core)

SDK に含まれる API のリファレンスです。必要に応じて参照してください。

## モジュールの種類とインターフェイス
開発してアプリに組み込むことができるモジュールの種類とインターフェイスを次の表に示します。
| モジュールの種類       | インターフェイス      |
| ---------------------- | --------------------- |
| ユーザー認証モジュール | `IAuthenticationModule` |
| データ保管モジュール   | `IRepositoryModule`     |

## モジュール サンプル

このサンプルは、クイックスタートとして素早く内容を理解してモジュールの開発を開始できるよう、副次的な内容は極力省かれています。また単純なテキストファイルやフォルダに読み書きする内容になっていますので、そのまま組み込んでアプリをまずは使ってみるために活用することもできます。

### `AuthenticationModule1` [/src/AuthenticationModules](https://github.com/serevo/storex-samples/tree/main/src/AuthenticationModules1)

CSVファイル (ID と 氏名)  を使用し、ダイアログボックスでユーザーに入力された ID で認証します。モジュール設定として CSV ファイルを選択します。他に次の型も使用します。
  - `AuthenticationForm1`: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `User`:  認証結果として返す `IUser` インターフェイス実装\
  - `AuthenticationModuleHelper`:  ファイル入出力用ヘルパー

    

### `AuthenticationModule2` [/src/AuthenticationModules](https://github.com/serevo/storex-samples/tree/main/src/AuthenticationModules1)

CSVファイル (ID と 氏名)  を使用し、ユーザーが氏名を一覧から選択して認証します。モジュール設定として CSV ファイルを選択します。他に次の型も使用します。

  - `AuthenticationForm2`: 認証用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0)
  - `User`:  認証結果で返す `IUser` インターフェイスの実装
  - `AuthenticationModuleHelper`:  ファイル入出力用ヘルパー

### `RepositoryModule1` [/src/RepositoryModules1](https://github.com/serevo/storex-samples/tree/main/src/RepositoryModules1)

１つのファイル (概要データ) と１つのフォルダー (詳細データ) でデータを管理します。モジュール設定としてダイアログボックスでこれらの場所を選択します。データ保管モジュールは、検出されたシンボルから主要なラベルを特定する役割もありますが、このサンプルではプライマリ ラベル として指定文字で始まる固定長テキストと、セカンダリ ラベルとして C-3 ラベルを扱うよう、モードの設定で構成します。他に次の型も使用します。

  - `ConfigForm1`: モジュール設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `ModeConfigForm1`:  モード設定用ダイアログボックス ([System.Windows.Forms)](https://learn.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form?view=windowsdesktop-7.0) 
  - `LabelDefinition1`: プライマリ ラベル用の 固定長テキスト定義とロジック


## MEF とメタデータ
モジュールのプラグインは [MEF (Managed Extensibility Framework)](https://learn.microsoft.com/ja-jp/dotnet/framework/mef/) によって実現しています。モジュールを新規で開発する場合、そのモジュールをアプリで認識する為には各インターフェイスの実装とエクスポート属性の指定に加え、次のメタデータの指定が必要です。

| 名前        | 説明                                                        |
| ----------- | ----------------------------------------------------------- |
| Id          | モジュールを一意に識別できる文字列。Guid の文字列表現推奨。 |
| DisplayName | モジュールの表示名。                                        |
| Description | モジュールの補足説明。 省略可。                                     |

ユーザー認証モジュールの例 (VB)

``` VB

Imports System.ComponentModel.Composition

<Export(GetType(IAuthenticationModule))>
<ExportMetadata("Id", "42dc1253-5ca5-43ce-8eb9-558c8094cf5a")>
<ExportMetadata("DisplayName", "社員証認証")>
<ExportMetadata("Description", "社員証を使用します。")>
Public Class MyAuthenticationModule
    Implements IAuthenticationModule
```


データ保管モジュールの例 (C#)
``` CS

using System.ComponentModel.Composition;

[Export(typeof(IRepositoryModule))]
// nameof 式で名前を指定することもできます。
[ExportMetadata(nameof(IRepositoryModuleMetadata.Id), "3051d137-3611-4911-b71c-8ecaeb7f9a7c")]
[ExportMetadata(nameof(IRepositoryModuleMetadata.DisplayName), "社内DB")]
[ExportMetadata(nameof(IRepositoryModuleMetadata.Description), "xx サーバーの SQL Server")]
public class MyRepositoryModule : IRepositoryModule

```

