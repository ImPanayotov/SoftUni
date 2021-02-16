--UPDATE
--    Sales_Import
--SET
--    Sales_Import.AccountNumber = RAN.AccountNumber
--FROM
--    Sales_Import SI
--INNER JOIN
--    RetrieveAccountNumber RAN
--ON 
--    SI.LeadID = RAN.LeadID;

UPDATE
    Tickets
SET Tickets.Price = Price * 1.13
FROM Tickets t
INNER JOIN Flights f
ON t.FlightId = f.Id
WHERE f.Destination LIKE 'Carlsbad'