SELECT TOP (2) DepositGroup
	FROM (
		  SELECT DepositGroup,
			     AVG(MagicWandSize) AS AverageWandSize
		  FROM WizzardDeposits AS wd
	      GROUP BY wd.DepositGroup
		 ) AS AverageWandSize
	ORDER BY AverageWandSize
	
SELECT top(2) DepositGroup
	FROM WizzardDeposits
	GROUP BY DepositGroup
	ORDER BY AVG(MagicWandSize)