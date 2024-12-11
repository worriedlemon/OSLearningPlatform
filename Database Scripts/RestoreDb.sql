restore database OsLearningPlatform
from disk = 'D:\Backup OsLearningPlatform\OSLearningPlatformFull.bak'
with norecovery

restore database OsLearningPlatform
from disk = 'D:\Backup OsLearningPlatform\OSLearningPlatformDiff.bak'
with norecovery

restore log OsLearningPlatform
from disk = 'D:\Backup OsLearningPlatform\OSLearningPlatformLog.bak'
with norecovery

restore database OsLearningPlatform
with recovery
