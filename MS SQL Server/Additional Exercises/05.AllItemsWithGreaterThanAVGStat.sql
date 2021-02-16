  
SELECT I.Name, I.Price, I.MinLevel, S.Strength, S.Defence, S.Speed, S.Luck, S.Mind
FROM Items AS I
JOIN [Statistics] S on S.Id = I.StatisticId
WHERE S.Mind> (SELECT AVG(Mind) FROM [Statistics]) AND
      S.Luck > (SELECT AVG(Luck) FROM [Statistics]) AND
      S.Speed >(SELECT AVG (Speed) FROM [Statistics])
ORDER BY I.Name