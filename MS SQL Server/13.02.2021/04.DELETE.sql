DELETE FROM StudentsTeachers
WHERE TeacherId IN (SELECT Id FROM Teachers
    WHERE Phone LIKE '%72%')

DELETE FROM Teachers
WHERE Phone LIKE '%72%'

DELETE FROM RepositoriesContributors
WHERE RepositoryId LIKE 
			(SELECT Id FROM Repositories WHERE [Name] LIKE 'Softuni-Teamwork')

DELETE FROM Issues
WHERE RepositoryId LIKE 
			(SELECT Id FROM Repositories WHERE [Name] LIKE 'Softuni-Teamwork')

