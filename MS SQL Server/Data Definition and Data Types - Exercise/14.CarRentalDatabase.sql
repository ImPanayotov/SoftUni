USE master
CREATE DATABASE CarRental
GO
CREATE TABLE Categories(
	Id INT IDENTITY,
	CategoryName VARCHAR(30), 
	DailyRate INT NOT NULL, 
	WeeklyRate INT, 
	MonthlyRate INT, 
	WeekendRate INT
)

CREATE TABLE Cars(
	Id INT IDENTITY, 
	PlateNumber VARCHAR(10) NOT NULL, 
	Manufacturer VARCHAR(30) NOT NULL,
	Model VARCHAR(30), 
	CarYear DATE, 
	CategoryId INT NOT NULL, 
	Doors INT, 
	Picture VARCHAR(MAX), 
	Condition VARCHAR(4), 
	Available BIT NOT NULL
)

CREATE TABLE Employees(
	Id INT IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	Title VARCHAR(40), 
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers(
	Id INT IDENTITY,
	DriverLicenceNumber VARCHAR(10) NOT NULL, 
	FullName VARCHAR(30) NOT NULL, 
	[Address] VARCHAR(150) NOT NULL,
	City VARCHAR(30) NOT NULL,
	ZIPCode INT, 
	Notes VARCHAR(MAX)
)

CREATE TABLE RentalOrders(
	Id INT Identity, 
	EmployeeId INT NOT NULL, 
	CustomerId INT NOT NULL, 
	CarId INT NOT NULL, 
	TankLevel INT, 
	KilometrageStart INT, 
	KilometrageEnd INT, 
	TotalKilometrage INT, 
	StartDate smalldatetime, 
	EndDate smalldatetime, 
	TotalDays INT, 
	RateApplied INT, 
	TaxRate INT, 
	OrderStatus NVARCHAR(100), 
	Notes NVARCHAR(MAX)
)

ALTER TABLE Categories
ADD CONSTRAINT PK_Categories_Id
PRIMARY KEY (Id)

ALTER TABLE Cars
ADD CONSTRAINT PK_Cars_Id
PRIMARY KEY (Id)


ALTER TABLE Employees
ADD CONSTRAINT PK_Employees_Id
PRIMARY KEY (Id)

ALTER TABLE Customers
ADD CONSTRAINT PK_Customers_Id
PRIMARY KEY (Id)


ALTER TABLE RentalOrders
ADD CONSTRAINT PK_RentalOrders_Id
PRIMARY KEY (Id)

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES
('CatName1', 10, 35, 250, 15),
('CatName2', 10, 35, 250, 15),
('CatName3', 10, 35, 250, 15)

INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
VALUES
('B6212KH', 'BMW', '318', '1995-02-02', 1, 4, 'NO', 'GOOD', 0 ),
('E6212KH', 'BMW', '318', '1996-02-02', 1, 4, 'NO', 'GOOD', 0 ),
('A6212KH', 'BMW', '318', '1997-02-02', 1, 4, 'NO', 'GOOD', 0 )

INSERT INTO Employees(FirstName, LastName, Title, Notes)
VALUES
('Tosho', 'Toshev', 'Mechanic', 'Oil Leaks'),
('Gosho', 'Toshev', 'Mechanic', 'Oil Leaks'),
('Pesho', 'Toshev', 'Mechanic', 'Oil Leaks')

INSERT INTO Customers(DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes)
VALUES
('1651604044', 'Petran Kostov', 'Burgas, Bulgaria, 125 Zavodska Street', 'Burgas', 8010, 'Ugly guy'),
('1651604044', 'Petran Kostov', 'Burgas, Bulgaria, 125 Zavodska Street', 'Burgas', 8010, 'Ugly guy'),
('1651604044', 'Petran Kostov', 'Burgas, Bulgaria, 125 Zavodska Street', 'Burgas', 8010, 'Ugly guy')

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel,
KilometrageStart, KilometrageEnd,TotalKilometrage, StartDate, 
EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
VALUES
(3, 2, 1, 45, 18980, 19300, 320, 19.06, 20.08, 62, 15, 10, 'Approved', 'Risky'),
(3, 2, 1, 45, 18980, 19300, 320, 19.06, 20.08, 62, 15, 10, 'Approved', 'Risky'),
(3, 2, 1, 45, 18980, 19300, 320, 19.06, 20.08, 62, 15, 10, 'Approved', 'Risky')

SELECT * FROM RentalOrders