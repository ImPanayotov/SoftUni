SELECT (p.FirstName + ' ' + p.LastName) AS 'Full Name',
	    pl.Name AS 'Plane Name',
	   (f.Origin + ' - ' + f.Destination) AS 'Trip',
	    lt.Type AS 'Luggage Type'
		FROM Passengers AS p
	 JOIN Tickets t ON  p.Id = t.PassengerId
	 JOIN Flights AS f ON t.FlightId = f.Id
	 JOIN Planes AS pl ON f.PlaneId = pl.Id
	 JOIN Luggages AS l ON t.LuggageId = l.ID
	 JOIN LuggageTypes AS lt ON l.LuggageTypeId = lt.Id
ORDER BY [Full Name] ASC, [Plane Name] ASC, Origin ASC, Destination ASC, [Luggage Type] ASC

--SELECT * FROM Passengers
--ORDER BY FirstName