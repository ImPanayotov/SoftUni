CREATE PROC usp_SearchForFiles(@fileExtension VARCHAR(MAX))
AS
	DECLARE  @c TABLE (Id INT, [Name] VARCHAR(MAX), Size DECIMAL(18, 2))

	SELECT Id, [Name], Size as Size 
		INTO c FROM Files
		WHERE [Name] LIKE '%.' + @fileExtension

	SELECT Id, [Name], (CONVERT(VARCHAR(MAX), Size) + 'KB') as Size 
		 FROM c
		WHERE [Name] LIKE '%.' + @fileExtension
		ORDER BY Id ASC, [Name] ASC, Size DESC


EXEC usp_SearchForFiles 'txt'
