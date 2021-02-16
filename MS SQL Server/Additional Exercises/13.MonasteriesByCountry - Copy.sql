--PROBLEM 1--
CREATE TABLE Monasteries
(
    Id          INT PRIMARY KEY IDENTITY,
    Name        NVARCHAR(100) NOT NULL,
    CountryCode CHAR(2)       NOT NULL
)

--PROBLEM 2--
INSERT INTO Monasteries(Name, CountryCode)
VALUES ('Rila Monastery “St. Ivan of Rila”', 'BG'),
       ('Bachkovo Monastery “Virgin Mary”', 'BG'),
       ('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
       ('Kopan Monastery', 'NP'),
       ('Thrangu Tashi Yangtse Monastery', 'NP'),
       ('Shechen Tennyi Dargyeling Monastery', 'NP'),
       ('Benchen Monastery', 'NP'),
       ('Southern Shaolin Monastery', 'CN'),
       ('Dabei Monastery', 'CN'),
       ('Wa Sau Toi', 'CN'),
       ('Lhunshigyia Monastery', 'CN'),
       ('Rakya Monastery', 'CN'),
       ('Monasteries of Meteora', 'GR'),
       ('The Holy Monastery of Stavronikita', 'GR'),
       ('Taung Kalat Monastery', 'MM'),
       ('Pa-Auk Forest Monastery', 'MM'),
       ('Taktsang Palphug Monastery', 'BT'),
       ('S?mela Monastery', 'TR')

--PROBLEM 3--
ALTER TABLE Countries
    ADD IsDeleted BIT DEFAULT 0

--PROBLEM 4--
UPDATE Countries
SET IsDeleted=1
WHERE CountryCode IN
      (SELECT Q1.CountryCode
       FROM (SELECT C.CountryCode,
                    COUNT(CR.RiverId) AS COUNT
             FROM Countries AS C
                      JOIN CountriesRivers CR on C.CountryCode = CR.CountryCode
             GROUP BY C.CountryCode) AS Q1
       WHERE Q1.COUNT > 3)

--PROBLEM 5--
SELECT M.Name AS Monastery,
       C.CountryName AS Country
FROM Monasteries AS M
JOIN Countries C on M.CountryCode = C.CountryCode
WHERE C.IsDeleted = 0
ORDER BY Monastery