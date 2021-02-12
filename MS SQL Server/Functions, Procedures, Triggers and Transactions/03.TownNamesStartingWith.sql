CREATE OR ALTER PROC usp_GetTownsStartingWith @StartingWith VARCHAR(MAX)
AS
	SELECT [Name] FROM Towns
		WHERE [Name] LIKE @StartingWith + '%'
GO

EXEC usp_GetTownsStartingWith 'be'