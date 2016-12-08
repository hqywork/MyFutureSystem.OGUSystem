@ECHO OFF

CHCP 65001>NUL

SET arg=%1
IF DEFINED arg ( GOTO Add )

:Help

ECHO 语法：Add-Migration ^<迁移名称^>

GOTO Exit

:Add

ECHO 正在添加新的数据库迁移（%arg%）...
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations add "%arg%" -c OguContext

:Exit