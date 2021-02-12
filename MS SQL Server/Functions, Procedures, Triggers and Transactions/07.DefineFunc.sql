GO
CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
BEGIN

	DECLARE @Index INT = 1;

	WHILE @Index < LEN(@word)
		BEGIN
			IF @setOfLetters LIKE '%' + (SELECT SUBSTRING(@word, @Index, 1))+ '%'
				BEGIN
					SET @Index = @Index + 1
					CONTINUE
				END
			ELSE
				RETURN 0
		END
RETURN 1
END
GO

SELECT dbo. ufn_IsWordComprised('pppp', 'Guy') AS Result