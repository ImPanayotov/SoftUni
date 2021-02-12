CREATE OR ALTER PROC usp_DeleteEmployeesFromDepartment(@departmentId INT)
AS
BEGIN
    --first delete all records from EmployeesProjects where EmployeeId is in to-be-deleted IDs

    DELETE
    FROM EmployeesProjects
    WHERE EmployeeID IN (SELECT EmployeeID
                         FROM Employees
                         WHERE DepartmentID = @departmentId);
    --set managerId to null where Manager is an Employee who is going to be deleted

    UPDATE Employees
    SET ManagerID=NULL
    WHERE ManagerID IN (SELECT EmployeeID
                        FROM Employees
                        WHERE DepartmentID = @departmentId);
--Alter column ManagerId in Departments table and make it nullable

    ALTER TABLE Departments
        ALTER COLUMN ManagerID int;

    UPDATE Departments
    SET ManagerID = NULL
    WHERE ManagerID IN (SELECT EmployeeID
                        FROM Employees
                        WHERE DepartmentID = @departmentId);

    --delete employees from departments

    DELETE FROM Employees
    WHERE DepartmentID=@departmentId

    DELETE FROM Departments
    where DepartmentID=@departmentId

    SELECT count(*)
    FROM Employees
    where DepartmentID=@departmentId

END

SELECT * FROM Employees
SELECT * FROM Departments

EXEC dbo.usp_DeleteEmployeesFromDepartment 1
/*Write a procedure with the name usp_DeleteEmployeesFromDepartment (@departmentId INT) 
	which deletes all Employees from a given department. 
	Delete these departments from the Departments table too. 
	Finally SELECT the number of employees from the given department. 
	If the delete statements are correct the select query should return 0.
	After completing that exercise restore your database to revert all changes.
	Hint:
	You may set ManagerID column in Departments table to nullable (using query "ALTER TABLE …").
*/
BACKUP DATABASE SoftUni
TO DISK = 'D:\Softuni-backup.bak'

USE master

ALTER DATABASE SoftUni
SET OFFLINE WITH ROLLBACK IMMEDIATE

RESTORE DATABASE SoftUni
FROM DISK = 'D:\Softuni-backup.bak' WITH REPLACE