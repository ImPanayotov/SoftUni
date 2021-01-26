SELECT TOP(50) [Name], 
		FORMAT(Start, 'yyyy-MM-dd') AS Start --Why doesnt work with CAST(Start AS DATE)???
		FROM Games
	WHERE DATEPART(YEAR, Start) BETWEEN 2011 AND 2012
	ORDER BY Start, [Name]

