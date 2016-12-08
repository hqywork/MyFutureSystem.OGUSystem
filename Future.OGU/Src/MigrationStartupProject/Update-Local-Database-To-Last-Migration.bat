@ECHO OFF

CHCP 65001>NUL

ECHO 正在获取最近一次迁移的名称...
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations list -c OguContext > %ListTxtPath%

SET "lastMigrationName="
FOR /F "delims=" %%a IN ('MORE ^< %ListTxtPath%') DO SET "lastMigrationName=%%a"

DEL /Q /F %ListTxtPath%

ECHO 正在更新最近一次数据库迁移（%lastMigrationName%）至本地数据库...

dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" database update "%lastMigrationName%" -c OguContext