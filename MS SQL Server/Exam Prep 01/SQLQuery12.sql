CREATE PROC usp_CancelFlights AS
	BEGIN
		UPDATE Flights SET DepartureTime = NULL,  ArrivalTime = NULL
		WHERE ArrivalTime >= DepartureTime
	END

CREATE PROC usp_CancelFlights AS
	BEGIN
		UPDATE Flights SET DepartureTime = NULL,  ArrivalTime = NULL
		WHERE ArrivalTime < DepartureTime
	END



EXEC usp_CancelFlights

SELECT * FROM Flights
WHERE ArrivalTime >= DepartureTime