SELECT TOP 50 e.FirstName,
			  e.LastName, 
			  t.Name AS Town,
			  a.AddressText
		FROM Employees AS e
		JOIN Addresses AS a ON a.AddressID = e.AddressID
		JOIN Towns AS t ON a.TownID = t.TownID
	ORDER BY e.FirstName ASC, e.LastName ASC

		--	SELECT TOP 50 e.FirstName, e.LastName,
--  t.Name as Town, a.AddressText
--FROM Employees e
--  JOIN Addresses a ON e.AddressID = a.AddressID
--  JOIN Towns t ON a.TownID = t.TownID
--ORDER BY e.FirstName, e.LastName