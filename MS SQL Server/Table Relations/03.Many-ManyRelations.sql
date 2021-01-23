CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
)

INSERT INTO Students([Name]) VALUES
	('Mila'),
	('Toni'),
	('Ron')

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY IDENTITY(100, 1),
	[Name] NVARCHAR(20) NOT NULL
)

INSERT INTO Exams([Name]) VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')

CREATE TABLE StudentsExams(
	StudentID INT FOREIGN KEY REFERENCES Students (StudentID),
    ExamID    INT FOREIGN KEY REFERENCES Exams (ExamID),
    PRIMARY KEY (StudentID, ExamID)
)
