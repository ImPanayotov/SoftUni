--You are given a database schema with tables 
--AccountHolders(Id (PK), FirstName, LastName, SSN) and 
--Accounts(Id (PK), AccountHolderId (FK), Balance).  
--Write a stored procedure usp_GetHoldersFullName that selects the full names of all people. 

--Example
--Full Name
--Susan Cane
--Kim Novac
--Jimmy Henderson
SELECT *
from AccountHolders

CREATE PROC usp_GetHoldersFullName
AS
    SELECT concat(FirstName,' ',LastName)
FROM AccountHolders

exec usp_GetHoldersFullName
