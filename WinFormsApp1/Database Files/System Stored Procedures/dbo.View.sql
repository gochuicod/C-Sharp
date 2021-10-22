CREATE PROCEDURE [dbo].[View]
	@ID nvarchar(30),
	@Firstname nvarchar(30),
	@Lastname nvarchar(30),
	@Score nvarchar(30)
AS
	SELECT (ID + ' ' + Firstname + ' ' + Lastname + ' ' + Score) as FullDetails from StudentsTable
RETURN 0