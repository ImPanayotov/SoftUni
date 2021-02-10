SELECT TOP (1) wd.MagicWandSize AS [LongestMagicWand] FROM WizzardDeposits AS wd
	ORDER BY wd.MagicWandSize DESC
--OR
--SELECT MAX(MagicWandSize) AS [LongestMagicWand] FROM WizzardDeposits