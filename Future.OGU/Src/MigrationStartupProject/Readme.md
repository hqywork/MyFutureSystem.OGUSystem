Entity Framework Core 数据库迁移维护
===================================
----

## 目录

### 使用程序包管理器控制台（PowerShell）

#### 必备条件

 - Visual Studio 2015 Update 3
 - 安装 VS2015 扩展应用：Nuget 包管理器
 - 在项目 `project.json` 文件中中加入
   * `dependencies` 节中加入：
```
"Microsoft.EntityFrameworkCore.Design": {
	"version": "1.1.0",
	"type": "build"
},
"Microsoft.EntityFrameworkCore.Tools": {
    "type": "build",
    "version": "1.1.0-preview4-final"
}
```
   * `tools` 节中加入：
```
"Microsoft.EntityFrameworkCore.Tools": "1.1.0-preview4-final"
```

#### 迁移命令的使用

- 通过 VS2015 打开使用了 Entity Framework Core 的项目；
- 通过 VS2015 主菜单“工具”->“NuGet 包管理器”->“程序包管理器控制台” 打开程序包管理器控制台窗口。
- 在窗口中的“默认项目”选择 `Src\DomainLayout\Repositories\HQY.FutureOGU.EfSqlserver`
- 在解决方案资源管理器中设置 `Src\MigrationStartupProject` 为启动项目
- 

#### 命令说明

在此仅说明在本项目中需要使用的功能，详细请见：https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell 。

##### Add-Migration

添加一个新的迁移。

- 添加初始化迁移
```
Add-Migration InitMigration -Context OguContext
```

##### Remove-Migration

移除最后一次迁移

- 移除当前最新的迁移
```
Remove-Migration -Context OguContext
```

**注**
  1. 在以下环境中运行提示“No ModelSnapshot was found.”
 - Runtime：.NET Core 1.1.0 Preview1
 - SDK：.NET Core 1.0.0 SDK Preview2.1-003155(x64)
 - VS2015 Tooling：.NET Core 1.0.1 - VS 2015 Tooling Preview 2.0.2

  2. 在以下环境中可正常运行
 - Runtime：.NET Core 1.1.0
 - SDK：.NET Core 1.0.0 SDK Preview2.1-003177(x64)
 - VS2015 Tooling：.NET Core 1.0.1 - VS 2015 Tooling Preview 2.0.3

##### Script-Migration

- 为所有迁移生成 SQL 脚本，并且此脚本可以运用于任何迁移所建的数据库。
```
Script-Migration -From 0 -To InitMigration -Context OguContext
```

##### Update-Database
- 更新数据库到初始迁移
```
Update-Database -Migration InitMigration
```

### 使用 dotnet 命令行接口（Command Line）

#### 必备条件

 - Visual Studio 2015 Update 3
 - 安装 Microsoft DotNet Core 1.0.0 SDK Preview 2.1
 - 在项目 `project.json` 文件中中加入
   * `dependencies` 节中加入：
```
"Microsoft.EntityFrameworkCore.Design": {
	"version": "1.1.0",
	"type": "build"
},
"Microsoft.EntityFrameworkCore.Tools.DotNet": {
    "type": "build",
    "version": "1.1.0-preview4-final"
}
```

   * `tools` 节中加入：
```
"Microsoft.EntityFrameworkCore.Tools.DotNet": "1.1.0-preview4-final"
```

#### 迁移命令的使用

- 打开“命令提示符”
- 切换至迁移启动项目所在文件夹（即 `Src\MigrationStartupProject`）
- 

#### 命令说明

在此仅说明在本项目中需要使用的功能，详细请见：https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet 。

##### dotnet ef migrations add

添加一个新的迁移

- 初始化迁移
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations add "InitMagration" -c OguContext
```

##### dotnet ef migrations remove

删除最后一次迁移

- 移除当前最新的迁移
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations remove -c OguContext
```

##### dotnet ef migrations script

生成迁移的 SQL 脚本

- 生成初始化迁移的 SQL 脚本
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations script 0 "InitMagration" -c OguContext -o "SQLScript\InitMagration.sql"
```

##### dotnet ef migrations list

显示已添加迁移的列表。

- 列出已有迁移
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations list -c OguContext
```

##### dotnet ef database update

根据指定的迁移更新数据库

- 使用初始化迁移来更新数据库
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" database update "InitMagration" -c OguContext
```

##### dotnet ef database drop

移除数据库

- 移除已创建的数据库
```
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" database drop -c OguContext
```
