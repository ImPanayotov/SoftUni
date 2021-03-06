DECLARE @USERID INT= (SELECT Id
                      FROM Users
                      WHERE Username = 'Alex');

DECLARE @GAMEID INT= (SELECT Id
                      FROM Games
                      WHERE Name = 'Edinburgh');

DECLARE @UGID INT= (SELECT Id
                    FROM UsersGames
                    WHERE UserId = @USERID
                      AND GameId = @GAMEID);
/*
DECLARE @COSTSITEMS DECIMAL(15, 2)= (SELECT SUM(I.Price)
                                     FROM Items AS I
                                     WHERE I.Name IN ('Blackguard', 'Bottomless Potion of Amplification',
                                                      'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin',
                                                      'Golden Gorget of Leoric', 'Hellfire Amulet'));
*/

UPDATE UsersGames
SET Cash-=(SELECT SUM(I.Price)
                                     FROM Items AS I
                                     WHERE I.Name IN ('Blackguard', 'Bottomless Potion of Amplification',
                                                      'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin',
                                                      'Golden Gorget of Leoric', 'Hellfire Amulet'))
WHERE Id = @UGID;

INSERT INTO UserGameItems(ItemId, UserGameId)
VALUES
       ((SELECT Id FROM Items WHERE Name = 'Blackguard'), @UGID),
 ((SELECT Id FROM Items WHERE Name='Bottomless Potion of Amplification'),@UGID ),
((SELECT Id FROM Items WHERE Name='Eye of Etlich (Diablo III)'),@UGID ),
((SELECT Id FROM Items WHERE Name='Gem of Efficacious Toxin'),@UGID ),
((SELECT Id FROM Items WHERE Name='Golden Gorget of Leoric'),@UGID ),
((SELECT Id FROM Items WHERE Name='Hellfire Amulet'),@UGID )

SELECT U.Username, G.Name, UG.Cash, I.Name
FROM Users AS U
         JOIN UsersGames UG on U.Id = UG.UserId
         JOIN Games G on G.Id = UG.GameId
         JOIN UserGameItems UGI on UG.Id = UGI.UserGameId
         JOIN Items I on I.Id = UGI.ItemId
WHERE G.Name = 'Edinburgh'
ORDER BY I.Name