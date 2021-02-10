SELECT FirstLetter
FROM (
         SELECT SUBSTRING(FirstName, 1, 1) AS FirstLetter
         FROM WizzardDeposits
         WHERE DepositGroup LIKE 'Troll Chest') AS FirstCharQuery
GROUP BY FirstLetter
ORDER BY FirstLetter