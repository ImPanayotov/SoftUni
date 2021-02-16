select * from flights
select * from tickets

SELECT f.id AS FlightId, SUM(t.Price) AS Price FROM Flights AS f
JOIN Tickets AS t ON f.Id = t.FlightId
JOIN Passengers AS p ON t.PassengerId = p.Id
GROUP BY f.Id
ORDER BY Price DESC, FlightId
