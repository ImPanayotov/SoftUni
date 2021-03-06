SELECT wd.DepositGroup, SUM(wd.DepositAmount) AS TotalSum
	FROM WizzardDeposits AS wd
	WHERE  wd.MagicWandCreator LIKE 'Ollivander family'
	GROUP BY wd.DepositGroup
	HAVING SUM(DepositAmount) < 150000
	ORDER BY TotalSum DESC