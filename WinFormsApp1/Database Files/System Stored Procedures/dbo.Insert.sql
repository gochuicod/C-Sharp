CREATE PROCEDURE [dbo].[Insert]
	@ID nvarchar(30),
	@Firstname nvarchar(30),
	@Lastname nvarchar(30),
	@Score nvarchar(30)
AS
	insert into [dbo].[StudentsTable] (ID,Firstname,Lastname,Score)
	values (@ID,@Firstname,@Lastname,@Score)
RETURN 0