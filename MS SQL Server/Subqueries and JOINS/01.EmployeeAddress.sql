--SELECT FirstName, LastName, AddressText, Name 
--	FROM Employees AS e
--	JOIN Addresses AS a ON a.AddressID = e.AddressID
--	JOIN Towns AS t ON t.TownID = a.TownID
--	WHERE Name = 'Sofia'
--	ORDER BY Salary DESC

SELECT TOP 5 e.EmployeeID, e.JobTitle, e.AddressID, a.AddressText
	FROM Employees AS e
	JOIN Addresses AS a ON a.AddressID = e.AddressID
	ORDER BY e.AddressID ASC

--	SELECT TOP 50 e.FirstName, e.LastName,
--  t.Name as Town, a.AddressText
--FROM Employees e
--  JOIN Addresses a ON e.AddressID = a.AddressID
--  JOIN Towns t ON a.TownID = t.TownID
--ORDER BY e.FirstName, e.LastName
