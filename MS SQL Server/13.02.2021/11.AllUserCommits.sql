GO
CREATE FUNCTION udf_AllUserCommits(@username VARCHAR(MAX)) 
RETURNS INT
AS
BEGIN
	DECLARE @UsernameId INT = (SELECT Id FROM Users WHERE Username = @username) 

	DECLARE @COUNT INT = (
	(SELECT COUNT(*) FROM Users u 
			 JOIN Commits c ON u.Id = c.ContributorId
			WHERE u.Id = @UsernameId	))

RETURN @COUNT
END
GO

SELECT dbo.udf_AllUserCommits('UnderSinduxrein')

--SELECT c.message, u.Username FROM Commits c
--	JOIN Users u ON c.Id = u.Id

--	ORDER BY u.Username

--	select * from commits