SELECT Id, [Name], Size FROM FIles
WHERE Size > 1000 AND [Name] LIKE '%html%'
ORDER BY Size DESC, Id ASC, [Name] ASC