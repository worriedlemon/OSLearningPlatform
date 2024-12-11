use OSLearningPlatform
go

create schema [Wiki]
go

create schema [Service]
go

create table Wiki.Unit (
	UnitId int identity primary key,
	Name char(64) not null,
	Description char(256),
)

create table Wiki.Theme (
	ThemeId int identity primary key,
	UnitId int not null,
	Name char(64) not null,
	Description char(1024),
	Type char(8) not null,
	RecommendedDuration int not null default(2),
	ThemeFileUrl char(256),
	
	constraint FK_Theme_UnitRef foreign key (UnitId) references Wiki.Unit(UnitId),
	constraint CK_Theme_Type check(Type in ('LECTION', 'PRACTICE', 'LAB_WORK', 'MANUAL')),
	constraint CK_Duration check(RecommendedDuration > 0),
	constraint CK_ThemeFileUrl check(ThemeFileUrl LIKE 'https://%' OR ThemeFileUrl LIKE 'file:///%')
)

create nonclustered index IN_Theme_Name on Wiki.Theme(Name);

create table [Service].[User] (
	UserId int identity primary key,
	Login char(32) not null unique,
	EncryptedPassword char(64) not null,
	Name char(128)
)

create table [Service].Moderator (
	ModeratorId int not null unique,
	
	constraint FK_Moderator_UserRef foreign key (ModeratorId) references [Service].[User](UserId)
)

create table [Service].AttendanceAndPerformance (
	UserId int unique not null,
	LastOnline datetime null,
	LastThemeId int null,

	constraint FK_Performance_UserRef foreign key (UserId) references [Service].[User](UserId),
	constraint FK_Performance_ThemeRef foreign key (LastThemeId) references Wiki.Theme(ThemeId)
)

create table Wiki.Question (
	QuestionId int identity primary key,
	ThemeId int not null,
	UserId int not null,
	Text char(1024) not null,

	constraint FK_Question_ThemeRef foreign key (ThemeId) references Wiki.Theme(ThemeId),
	constraint FK_Question_UserRef foreign key (UserId) references [Service].[User](UserId)
)

create table Wiki.Reply (
	ReplyId int identity primary key,
	QuestionId int not null,
	UserId int not null,
	Text char(1024) not null,

	constraint FK_Reply_QuestionRef foreign key (QuestionId) references Wiki.Question(QuestionId),
	constraint FK_Reply_UserRef foreign key (UserId) references [Service].[User](UserId)
)