select * from tickets
order by PassengerId

SELECT p.FirstName, p.LastName, p.Age
FROM Passengers AS p
WHERE NOT EXISTS
(SELECT t.PassengerId FROM Tickets AS t WHERE p.Id = t.PassengerId)
ORDER BY p.Age DESC, FirstName ASC, LastName ASC