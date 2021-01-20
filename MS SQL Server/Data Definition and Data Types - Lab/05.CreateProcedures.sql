--Account Procedure
CREATE PROC p_AddAccount @CLientId INT, @AccountTypeId INT AS
INSERT INTO Accounts (ClientId, AccountTypeId)
VALUES (@ClientId, @AccountTypeId)

p_AddAccount 2, 2
SELECT * FROM Accounts

--Deposit Procedure
CREATE PROC p_Deposit @AccountId INT, @Amount DECIMAL (15, 2) AS
UPDATE Accounts
SET Balance += @Amount
WHERE Id = @AccountId

--Withdraw Procedure
CREATE PROC p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS
BEGIN
	DECLARE @OldBalance DECIMAL(15, 2)
	SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId
	IF (@OldBalance - @Amount >= 0)
	BEGIN
		UPDATE Accounts
		SET Balance -= @Amount
		WHERE Id = @AccountId
	END
	ELSE
	BEGIN
		RAISERROR('Insufficient funds', 10, 1)
	END
END