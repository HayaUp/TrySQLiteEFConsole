# SQLite と Entity Framework を試す

## Nuget でインストール 

- Microsoft.EntityFrameworkCore.Sqlite.Core
- Microsoft.EntityFrameworkCore.Tools

### 補足

- バージョンは `5.0.17`
  - バージョン6以降は ,Net のバージョンが合わなかった
    - ※開発環境は　.Net5

## マイグレーション等を行おうとしたらエラー発生

```
You need to call SQLitePCL.raw.SetProvider().  If you are using a bundle package, this is done by calling SQLitePCL.Batteries.Init().
```

### 対応？

- Microsoft.Data.Sqlite をインストールした
- https://github.com/dotnet/efcore/issues/24493#issuecomment-1228643696

## Nuget パッケージマネージャーのパッケージマネージャーコンソールでコマンドを実行する

- ツール -> Nuget パッケージマネージャー -> パッケージマネージャーコンソール
  - Add-Migration InitialCreate
    - 作成したクラスからデータベース作成・操作に必要なクラスを生成する
  - Update-Database
    - 生成したクラスからデータベースファイルを作成する

## 参考

- 【C#】Entity Framework Coreを使ってSQLiteを操作する
  - https://hirahira.blog/efcore-sqlite/