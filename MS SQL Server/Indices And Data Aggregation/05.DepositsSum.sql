SELECT DISTINCT wd.DepositGroup,
			SUM(wd.DepositAmount)
		FROM WizzardDeposits AS wd
		GROUP BY wd.DepositGroup