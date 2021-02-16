--Задача 9 - Трябва селектирате TOP(5) Id, Name, COUNT(*) 
--от RepositoriesContributors и да ги 
--JOIN-ете с Repositories и Commits  (edited)  

SELECT TOP(5) r.Id, r.[Name], COUNT(*) as Commits FROM RepositoriesContributors as rc
JOIN Repositories as r ON rc.RepositoryId = r.Id
JOIN Commits as c ON r.Id = c.RepositoryId
GROUP BY r.id, r.[Name]
ORDER BY Commits DESC, r.id ASC, r.Name ASC