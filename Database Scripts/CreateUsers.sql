-- Пользователи и права
use OSLearningPlatform
go

if exists (
	select name
	from master.sys.server_principals
	where name = 'DbUser'
	)
begin
	create login DbUser
	with password = 'qwerty'
end

if exists (
	select name
	from master.sys.server_principals
	where name = 'DbModerator'
	)
begin
	create login DbModerator
	with password = '1qaz2wsx'
end

create user [User] for login DbUser
create user [Moderator] for login DbModerator

grant select on schema::[Wiki] to [User]
grant select, insert on [Wiki].Question to [User]
grant select, insert on [Wiki].Reply to [User]
grant select on schema::[Service] to [User]
grant select, update on [Service].AttendanceAndPerformance to [User]
grant execute on schema::[Wiki] to [User]
grant execute on [Service].IsModerator to [User]
grant execute on [Service].UpdatePerformance to [User]

grant select, insert, update, delete on schema::[Wiki] to [Moderator]
grant select, update on schema::[Service] to [Moderator]
grant execute on [Service].IsModerator to [Moderator]
grant execute on [Service].SetAsModerator to [Moderator]
grant execute on schema::[Wiki] to [Moderator]
grant execute on [Service].UpdatePerformance to [Moderator]