param ($BackupType = $(throw "BackupType should be provided"))

if ( !( $BackupType -in ("full", "diff", "log") ) )
{
	throw "Possible BackupType options are: full | diff | log"
}

$backupPath = "D:\Backup OsLearningPlatform"

if ( !(Test-Path -Path "$backupPath") )
{
	New-Item -Path "$backupPath" -ItemType "directory"
}

$dbName = "OsLearningPlatform"
$scriptPath = "C:\DbData\Backup\${BackupType}_backup.sql"

Invoke-Sqlcmd -InputFile "$scriptPath" -Database "$dbName" -ServerInstance "LEMONWIN\SQLEXPRESS"