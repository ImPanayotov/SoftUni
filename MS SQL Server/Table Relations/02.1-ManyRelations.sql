CREATE TABLE Models(
	ModelID INT IDENTITY(100, 1),
	[Name] NVARCHAR(20) NOT NULL,
	ManufacturerID INT NOT NULL
)

ALTER TABLE Models
ADD CONSTRAINT PK_ModelID
PRIMARY KEY (ModelID)

CREATE TABLE Manufacturers(
	ManufacturerID INT IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	EstablishedOn DATE
)

ALTER TABLE Manufacturers
ADD CONSTRAINT PK_ManufacturerID
PRIMARY KEY (ManufacturerID)

INSERT INTO Models([Name], ManufacturerID) VALUES
	('X1', 1),
	('i6', 1),
	('Model S', 2),
	('Model X', 2),
	('Model 3', 2),
	('Nova', 3)



INSERT INTO Manufacturers([Name], EstablishedOn) VALUES
	('BMW', '07/03/1916'),
	('Tesla', '01/01/2003'),
	('Lada', '01/05/1966')

ALTER TABLE Models
ADD CONSTRAINT FK_ManufacturerID
FOREIGN KEY (ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
