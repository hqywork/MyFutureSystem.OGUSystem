@ECHO OFF

CHCP 65001>NUL
ECHO 正在初始化数据库迁移（InitMagration）...
dotnet ef -p "..\HQY.FutureOGU.EfSqlserver" -s "..\MigrationStartupProject" migrations add "InitMagration" -c OguContext