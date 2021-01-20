CREATE TABLE People (
Id INT IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL (5, 2),
[Weight] DECIMAL (5, 2),
Gender CHAR(1) NOT NULL,
Birthdate NVARCHAR(20) NOT NULL,
Biography NVARCHAR(MAX)
)

ALTER TABLE People 
ADD CONSTRAINT CHK_Gender 
CHECK (Gender IN('f', 'm'))

ALTER TABLE People
ADD CONSTRAINT PK_People_Id
PRIMARY KEY (Id)

INSERT INTO People ([Name],Picture,Height,[Weight],Gender,Birthdate,Biography) VALUES
('Stela',Null,1.65,44.55,'f','2000-09-22',Null),
('Ivan',Null,2.15,95.55,'m','1989-11-02',Null),
('Qvor',Null,1.55,33.00,'m','2010-04-11',Null),
('Karolina',Null,2.15,55.55,'f','2001-11-11',Null),
('Pesho',Null,1.85,90.00,'m','1983-07-22',Null)