INSERT INTO Towns([Name]) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

SELECT * FROM Towns

INSERT INTO Departments([Name]) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

SELECT * FROM Departments


INSERT INTO Employees(FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 2),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 3),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 1),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 2)


SELECT * FROM Employees

INSERT INTO Addresses(AddressText, TownId) VALUES
('Some sample text put in here', 1),
('Some sample text put in here', 2),
('Some sample text put in here', 3),
('Some sample text put in here', 4),
('Some sample text put in here', 3)

SELECT * FROM Addresses