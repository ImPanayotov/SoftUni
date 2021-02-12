CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
	SELECT FirstName, LastName FROM Employees e
		WHERE Salary > 35000
