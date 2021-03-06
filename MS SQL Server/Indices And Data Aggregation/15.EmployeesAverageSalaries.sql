--SELECT DepartmentID,
--       AVG(IIF(DepartmentID = 1, Salary + 5000, Salary)) AS AverageSalary
--FROM (
--         SELECT *
--         FROM Employees
--         WHERE Salary > 30000
--           AND ManagerID != 42
--     ) AS FilteredQuery
--GROUP BY DepartmentID



SELECT * INTO EmployeesWithHightSalaries
FROM Employees
WHERE Salary>30000

DELETE
FROM EmployeesWithHightSalaries
WHERE ManagerID=42

UPDATE EmployeesWithHightSalaries
SET Salary += 5000
WHERE DepartmentID=1

SELECT DepartmentID, avg(Salary) as AverageSalary
FROM EmployeesWithHightSalaries
GROUP BY DepartmentID