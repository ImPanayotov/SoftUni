CREATE PROC usp_EmployeesBySalaryLevel (@SalaryLevel VARCHAR(MAX))
AS
BEGIN
	
	SELECT FirstName, LastName FROM Employees
	WHERE @SalaryLevel = dbo.ufn_GetSalaryLevel(Salary)
END
GO


EXEC usp_EmployeesBySalaryLevel 'High'