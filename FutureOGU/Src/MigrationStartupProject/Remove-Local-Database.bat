@ECHO OFF

CHCP 65001>NUL

ECHO 正在删除本地数据库...

dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" database drop -c OguContext