GO
CREATE FUNCTION udf_CalculateTickets 
		(@origin VARCHAR(MAX), @destination VARCHAR(MAX), @peopleCount INT)
RETURNS VARCHAR(50) AS
BEGIN

	DECLARE @RESULT VARCHAR(MAX);

	IF (@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!';
	END
	
	DECLARE @FlightId INT = 
			(SELECT Id FROM Flights	
				WHERE Origin = @origin AND Destination = @Destination);

	IF (@FlightId IS NULL)
	BEGIN
		RETURN 'Invalid flight!';
	END

	DECLARE @TotalPrice AS DECIMAL (18, 2) =
			@peopleCount * (SELECT Price FROM Tickets WHERE FlightId = @FlightId);

	SET @RESULT = 'Total price ' + CAST(@TotalPrice AS VARCHAR(MAX));

RETURN @RESULT
END
GO

SELECT dbo.udf_CalculateTickets ('Kolyshley','Rancabolang', -1)
SELECT dbo.udf_CalculateTickets('Invalid','Rancabolang', 33)
SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', 33)

