GO
CREATE FUNCTION ufn_GetSalaryLevel (@Salary DECIMAL(18,4)) 
RETURNS VARCHAR(MAX)
BEGIN
	
	DECLARE @Result VARCHAR(MAX)

	IF @Salary < 30000
		RETURN 'Low'
	ELSE IF @Salary >= 30000 AND @Salary <= 50000
		RETURN 'Average'
	ELSE
		RETURN 'High'

	RETURN NULL
END
GO

SELECT dbo.ufn_GetSalaryLevel(12500) AS Salary