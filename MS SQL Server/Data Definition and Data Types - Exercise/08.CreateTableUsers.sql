CREATE TABLE Users (
Id INT IDENTITY,
[Username] VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATE,
IsDeleted BIT
)

ALTER TABLE Users
ADD CONSTRAINT PK_Users_Id
PRIMARY KEY (Id)

INSERT INTO Users([Username], [Password], LastLoginTime, IsDeleted) VALUES
('USername1', 'Password1', '0001-01-01', 0),
('USername2', 'Password1', '0001-01-01', 0),
('USername3', 'Password1', '0001-01-01', 0),
('USername4', 'Password1', '0001-01-01', 0),
('USername5', 'Password1', '0001-01-01', 0)

--ALTER TABLE Users
--ALTER COLUMN LastLoginTime date;

--ALTER TABLE Users 
--ADD CONSTRAINT CHK_Users_PorfilePicture
--CHECK (DATALENGHT(ProfilePicture) <= 900000)

--insert into tableName (ImageColumn) 
--SELECT BulkColumn 
--FROM Openrowset( Bulk 'image..Path..here', Single_Blob) as img