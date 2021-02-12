--Your task is to create a stored procedure usp_CalculateFutureValueForAccount 
--that uses the function from the previous problem to give an interest to 
--a person's account for 5 years, along with information about his/her: 
--account id, 
--first name, 
--last name and 
--current balance 
--as it is shown in the example below. 
--It should take the AccountId and the interest rate as parameters.
--Again you are provided with “dbo.ufn_CalculateFutureValue” function 
--which was part of the previous task.

--Example
--Account Id	First Name		Last Name		Current Balance		Balance in 5 years
--1				Susan			Cane			123.12				198.2860
--*Note: for the example above interest rate is 0.1
CREATE OR ALTER PROC usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT)
AS
BEGIN
    SELECT a.Id    ,
           AH.FirstName,
          AH.LastName ,
          a.Balance,
           dbo.ufn_CalculateFutureValue(a.Balance,@interestRate, 5)                                       
    FROM Accounts AS a
             JOIN AccountHolders AS AH ON AH.Id = a.AccountHolderId
             WHERE a.Id=@accountId;
END
GO