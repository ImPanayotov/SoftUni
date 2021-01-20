CREATE DATABASE Hotel

CREATE TABLE Employees
(
Id INT Identity, 
FirstName NVARCHAR(30) NOT NULL, 
LastName NVARCHAR(30) NOT NULL, 
Title NVARCHAR(30), 
Notes NVARCHAR(150)
)

ALTER TABLE Employees
ADD CONSTRAINT PK_Employees_Id
PRIMARY KEY (Id)

CREATE TABLE Customers 
(
Id INT Identity,
AccountNumber INT NOT NULL, 
FirstName NVARCHAR(30) NOT NULL, 
LastName NVARCHAR(30) NOT NULL, 
PhoneNumber INT, 
EmergencyName NVARCHAR(60) NOT NULL, 
EmergencyNumber INT, 
Notes NVARCHAR(150)
)

ALTER TABLE Customers
ADD CONSTRAINT PK_Customers_AccountNumber
PRIMARY KEY (Id)

CREATE TABLE RoomStatus
(
Id INT Identity,
RoomStatus NVARCHAR(20) NOT NULL, 
Notes NVARCHAR(150)
)

ALTER TABLE RoomStatus
ADD CONSTRAINT PK_RoomStatus_RoomStatus
PRIMARY KEY (Id)

CREATE TABLE RoomTypes
(
Id INT Identity,
RoomTypes NVARCHAR(30) NOT NULL, 
Notes NVARCHAR(150)
)

ALTER TABLE RoomTypes
ADD CONSTRAINT PK_RoomTypes_RoomTypes
PRIMARY KEY (Id)

CREATE TABLE BedTypes
(
Id INT Identity,
BedType NVARCHAR(30) NOT NULL, 
Notes NVARCHAR(150)
)

ALTER TABLE BedTypes
ADD CONSTRAINT PK_BedTypes_BedTypes
PRIMARY KEY (Id)

CREATE TABLE Rooms
(
Id INT Identity,
RoomNumber INT NOT NULL, 
RoomType NVARCHAR(30), 
BedType NVARCHAR(30), 
Rate INT, 
RoomStatus NVARCHAR(30), 
Notes NVARCHAR(150)
)

ALTER TABLE Rooms
ADD CONSTRAINT PK_Rooms_RoomNumber
PRIMARY KEY (Id)

CREATE TABLE Payments
(
Id INT Identity, 
EmployeeId INT NOT NULL, 
PaymentDate NVARCHAR(15), 
AccountNumber INT, 
FirstDateOccupied NVARCHAR(15), 
LastDateOccupied NVARCHAR(15), 
TotalDays INT, 
AmountCharged INT, 
TaxRate INT, 
TaxAmount INT, 
PaymentTotal INT, 
Notes NVARCHAR(150)
)

ALTER TABLE Payments
ADD CONSTRAINT PK_Payments_Id
PRIMARY KEY (Id)

CREATE TABLE Occupancies
(
Id INT Identity, 
EmployeeId INT NOT NULL,
DateOccupied NVARCHAR(30),
AccountNumber INT,
RoomNumber INT,
RateApplied INT,
PhoneCharge INT, 
Notes NVARCHAR(150)
)

ALTER TABLE Occupancies
ADD CONSTRAINT PK_Occupancies_Id
PRIMARY KEY (Id)

INSERT INTO Employees(FirstName, LastName, Title, Notes)
VALUES
('Paskal', 'Tomov', 'Portier', 'Kato ne uchish taka stava'),
('Paskal', 'Tomov', 'Portier', 'Kato ne uchish taka stava'),
('Paskal', 'Tomov', 'Portier', 'Kato ne uchish taka stava')

INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES
(180290, 'Pask', 'Tom', 887901655, 'Batman', 3614320, 'Nananana'),
(180290, 'Pask', 'Tom', 88901655, 'Batman', 35988361, 'Nananana'),
(180290, 'Pask', 'Tom', 87901655, 'Batman', 3594320, 'Nananana')

INSERT INTO RoomStatus(RoomStatus, Notes)
VALUES
('Occupied', 'Until end of year'),
('Occupied', 'Until end of year'),
('Vacant', 'Until end of year')

INSERT INTO RoomTypes(RoomTypes, Notes)
VALUES
('Apartment', 'its dirty'),
('Studio', 'its dirty'),
('Attic', 'its dirty')

INSERT INTO BedTypes(BedType, Notes)
VALUES
('Single bed', 'very small'),
('Single bed', 'very small'),
('Single bed', 'very small')

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
VALUES
(420, 'Apartment', 'Single bed', 8, 'Occupied', 'too expensive'),
(420, 'Apartment', 'Single bed', 8, 'Occupied', 'too expensive'),
(420, 'Apartment', 'Single bed', 8, 'Occupied', 'too expensive')

INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
VALUES
(1239, 20/12/2020, 12312, 20/12/2020, 22/12/2020, 2, 130, 10, 10, 143, 'done'),
(1239, 20/12/2020, 12312, 20/12/2020, 22/12/2020, 2, 130, 10, 10, 143, 'done'),
(1239, 20/12/2020, 12312, 20/12/2020, 22/12/2020, 2, 130, 10, 10, 143, 'done')

INSERT INTO Occupancies(EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES
(123412, 19/02/2020, 21314, 123, 12, 23, 'lalala'),
(123412, 19/02/2020, 21314, 123, 12, 23, 'lalala'),
(123412, 19/02/2020, 21314, 123, 12, 23, 'lalala')