create database OSLearningPlatform
on
primary (
	name = OSLearningPlatform_Main,
	filename = 'C:\DbData\OSLearningPlatform_Main.mdf',
	size = 10 Mb,
	filegrowth = 25 Mb
)
log on (
	name = OSLearningPlatform_Log,
	filename = 'C:\DbData\OSLearningPlatform_Log.ldf',
	size = 10 Mb,
	filegrowth = 0
)
go

alter database OSLearningPlatform
set recovery full
