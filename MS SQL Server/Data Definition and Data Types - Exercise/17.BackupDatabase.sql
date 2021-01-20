BACKUP DATABASE SoftUni
TO DISK = 'C:\MSSQL_DATABASES_BACKUPS\Softuni-backup.bak'

USE master

ALTER DATABASE SoftUni
SET OFFLINE WITH ROLLBACK IMMEDIATE

DROP DATABASE SoftUni

RESTORE DATABASE SoftUni
FROM DISK = 'C:\MSSQL_DATABASES_BACKUPS\Softuni-backup.bak' WITH REPLACE
