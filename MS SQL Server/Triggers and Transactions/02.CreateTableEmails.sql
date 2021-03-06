CREATE TABLE NotificationEmails
(
    Id        int PRIMARY KEY IDENTITY,
    Recipient int REFERENCES Accounts (Id),
    Subject   nvarchar(max),
    Body      nvarchar(max)
)

CREATE OR ALTER TRIGGER tr_AddToNotificationEmailOnLogsUpdate
    ON Logs
    FOR INSERT
    AS
    INSERT INTO NotificationEmails(Recipient, Subject, Body)
    SELECT i.AccountID,
           'Balance change for account: ' + CAST(i.AccountID AS nvarchar(20)),
           'On ' + CONVERT(nvarchar(20), GETDATE(), 100) + ' your balance was changed from ' +
           CAST(i.OldSum AS nvarchar(20)) + ' to ' + CAST(i.NewSum AS nvarchar(20)) + '.'
    FROM inserted AS i

    GO
exec usp_TransferFunds 12, 15,1000

SELECT * from Logs
SELECT *
FROM NotificationEmails;