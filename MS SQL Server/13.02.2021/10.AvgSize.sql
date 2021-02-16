--SELECT u.Username,
--	AVG(SELECT * FROM  f 
--		JOIN  f ON f.CommitId = c.Id
--		JOIN  u ON u.Id = c.Id) as Size 
--	FROM Users as u
-- INNER JOIN Commits as c ON u.Id = c.ContributorId
--INNER JOIN Files as f ON c.id = f.CommitId
--GROUP BY u.Username, f.Size
--ORDER BY Size DESC, u.Username ASC

SELECT u.Username, AVG(f.Size) as Size FROM Users as u
JOIN Commits as c ON u.Id = c.ContributorId
JOIN FIles as f ON c.id = f.CommitId
GROUP BY u.Username
ORDER BY Size DESC, u.Username ASC