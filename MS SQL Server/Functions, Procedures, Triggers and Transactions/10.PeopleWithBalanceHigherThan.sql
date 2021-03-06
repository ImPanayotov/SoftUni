SELECT *
FROM Accounts;

CREATE PROC usp_GetHoldersWithBalanceHigherThan(@Money decimal(18, 4))
AS
BEGIN
    SELECT FirstName AS 'First Name',
           LastName  AS 'Last Name'
    FROM Accounts AS a
             JOIN AccountHolders AH ON a.AccountHolderId = AH.Id
    GROUP BY FirstName, LastName
    HAVING SUM(Balance) > @Money
    ORDER BY FirstName, LastName
END

exec usp_GetHoldersWithBalanceHigherThan 25000