use OSLearningPlatform
go

create function [Service].IsModerator(@id as int)
returns bit
as
begin
	declare @value char(32)
	
	set @value = (
		select top 1 ModeratorId as Moderators
		from Moderator
		inner join [User]
		on UserId = ModeratorId
		where ModeratorId = @id
	)
	if @value is null
		return 0
	
	return 1
end
go

create function Wiki.MostRepliedQuestions(@count as int = 5)
returns table
as
return (
	select top (select @count) wq.QuestionId, wq.ThemeId, wq.UserId, count(ReplyId) as RepliesCount, wq.Text as QuestionText
	from Wiki.Question as wq
	left join Wiki.Reply as wr
	on wq.QuestionId = wr.QuestionId
	group by wq.QuestionId, wq.ThemeId, wq.UserId, wq.Text
	order by RepliesCount desc
);
go

create function Wiki.UserQuestions(@id as int)
returns table
as
return (
	select wq.QuestionId, wq.Text, wq.ThemeId
	from [Service].[User] as su
	inner join Wiki.Question as wq
	on wq.UserId = su.UserId
	where su.UserId = @id
);
go

create procedure [Service].RegisterUser(@login as char(32), @password as char(64), @name as char(128) = null)
as
begin
	insert into [Service].[User](Login, EncryptedPassword, Name)
	values (@login, @password, @name)

	insert into [Service].AttendanceAndPerformance(UserId)
	values (@@identity)
end
go

create procedure [Service].SetAsModerator(@id as int)
as
begin
	if (select UserId from [User] where UserId = @id) is not null
		insert into [Service].Moderator values (@id)
	else
		raiserror(N'No such ID in `UserId` table', 10, 0)
end
go

create procedure [Service].UpdatePerformance(@id as int, @lastTheme as int = null)
as
begin
	update [Service].AttendanceAndPerformance
	set LastOnline = GETDATE(), LastThemeId = @lastTheme
	where UserId = @id
end
go

create view Wiki.NeedAnswer
as
select wq.QuestionId, ThemeId, wq.Text as QuestionText
from Wiki.Question as wq
left join Wiki.Reply as wr
on wq.QuestionId = wr.QuestionId
group by wq.QuestionId, wq.ThemeId, wq.Text
having count(ReplyId) = 0
go

create view Wiki.CourseProgram
as
select wu.UnitId, wu.Name, count(wt.ThemeId) as ThemesCount, sum(wt.RecommendedDuration) as OverallDuration
from Wiki.Unit as wu
left outer join Wiki.Theme as wt
on wu.UnitId = wt.UnitId
group by wu.UnitId, wu.Name
union
select 0 as UnitId, 'Суммарно' as Name, count(ThemeId) as ThemesCount, sum(RecommendedDuration) as OverallDuration
from Wiki.Theme
go

create view [Service].ProblematicUsers
as
select su.UserId, su.Login, su.Name, sa.LastOnline
from [Service].[User] as su
inner join [Service].AttendanceAndPerformance as sa
on su.UserId = sa.UserId
where sa.LastOnline is null or dateadd(d, 10, sa.LastOnline) < getdate()