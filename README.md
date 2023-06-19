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

## 参考

- 【C#】Entity Framework Coreを使ってSQLiteを操作する
  - https://hirahira.blog/efcore-sqlite/