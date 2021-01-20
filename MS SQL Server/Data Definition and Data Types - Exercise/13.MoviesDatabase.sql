CREATE DATABASE Movies
USE master

CREATE TABLE Directors (
	Id INT IDENTITY,
	DirectorName VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Genres (
	Id INT IDENTITY,
	GenreName VARCHAR(25) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Categories (
	Id INT IDENTITY,
	CategoryName VARCHAR(25) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Movies (
	Id INT IDENTITY,
	Title VARCHAR(MAX),
	DirectorId INT NOT NULL,
	CopyrightYear DATE,
	[Length] INT,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating INT,
	Notes VARCHAR(MAX),
)

ALTER TABLE Directors ADD CONSTRAINT PK_Directors_Id PRIMARY KEY (Id)
ALTER TABLE Genres ADD CONSTRAINT PK_Genres_Id PRIMARY KEY (Id)
ALTER TABLE Categories ADD CONSTRAINT PK_Categories_Id PRIMARY KEY (Id)
ALTER TABLE Movies ADD CONSTRAINT PK_Movies_Id PRIMARY KEY (Id)

ALTER TABLE Movies
ADD CONSTRAINT FK_Directors
FOREIGN KEY (DirectorId) REFERENCES Directors(Id);

ALTER TABLE Movies
ADD CONSTRAINT FK_Genres
FOREIGN KEY (GenreId) REFERENCES Genres(Id);

ALTER TABLE Movies
ADD CONSTRAINT FK_Categories
FOREIGN KEY (CategoryId) REFERENCES Categories(Id);


INSERT INTO Directors(DirectorName) VALUES
('Orhan'),
('Orhan2'),
('Orhan3'),
('Orhan4'),
('Orhan5')


INSERT INTO Genres(GenreName) VALUES
('Action'),
('Action2'),
('Action3'),
('Action4'),
('Action5')

INSERT INTO Categories(CategoryName) VALUES
('Over 21'),
('Over 22'),
('Over 23'),
('Over 24'),
('Over 25')


INSERT INTO Movies(Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) VALUES
('87th Mile', 1, '2005-05-18', 120, 1, 1, 10, 'Worst movie ever' ),
('87th Mile', 1, '2005-05-18', 120, 1, 1, 10, 'Worst movie ever' ),
('87th Mile', 1, '2005-05-18', 120, 1, 1, 10, 'Worst movie ever' ),
('87th Mile', 1, '2005-05-18', 120, 1, 1, 10, 'Worst movie ever' ),
('87th Mile', 1, '2005-05-18', 120, 1, 1, 10, 'Worst movie ever' )



SELECT * FROM Directors
SELECT * FROM Genres
SELECT * FROM Categories

SELECT * FROM Movies
