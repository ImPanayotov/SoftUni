USE Hotel

SELECT * FROM BedTypes
SELECT * FROM Customers
SELECT * FROM Employees
SELECT * FROM Occupancies
SELECT * FROM Payments
SELECT * FROM Rooms
SELECT * FROM RoomStatus
SELECT * FROM RoomTypes

UPDATE Payments
SET TaxRate *= 0.97

SELECT TaxRate FROM Payments