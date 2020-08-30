RESTORE FILELISTONLY 
FROM DISK = 'd:\projects\SSDT\WideWorldImporters-Standard.bak'

RESTORE Database WideWorldImporters
FROM DISK = 'd:\projects\SSDT\WideWorldImporters-Standard.bak'
WITH MOVE 'WWI_Primary' TO 'd:\projects\SSDT\WideWorldImporters.mdf',
MOVE 'WWI_Log' TO 'd:\projects\SSDT\WideWorldImporters.ldf',
MOVE 'WWI_UserData' TO  'd:\projects\SSDT\WideWorldImporters.ndf',
REPLACE

--https://hanskindberg.wordpress.com/2016/11/08/restore-a-sql-server-backup-to-localdb/