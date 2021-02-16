SELECT p.[Name],
	   p.Seats,
	   ISNULL(COUNT(t.PassengerId), 0) AS 'Passengers Count'
	   FROM Planes AS p
	   LEFT JOIN Flights AS f ON p.Id = f.PlaneId
	   LEFT JOIN Tickets AS t ON f.Id = t.FlightId
	   GROUP BY p.[Name], p.Seats
	   ORDER BY 'Passengers Count' DESC, p.Name ASC, p.Seats ASC
	   