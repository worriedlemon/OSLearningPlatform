$dbName = "OsLearningPlatform"
$backupScriptPath = "C:\DbData\Backup\backup_osplatform.ps1"

$fullScript = "${backupScriptPath} full"
$diffScript = "${backupScriptPath} diff"
$logScript = "${backupScriptPath} log"

# Устанавливаем еженедельное полное копирование в воскресенье
schtasks /Create /tn "${dbName} Full Backup" /sc weekly /d sun /st 03:00 /tr "${fullScript}"
schtasks /Create /tn "${dbName} Diff Backup" /sc daily /st 00:00 /tr "${diffScript}"
schtasks /Create /tn "${dbName} Log Backup" /sc hourly /mo 6 /st 06:00 /et 18:00 /tr "${logScript}"