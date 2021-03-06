SELECT CO.ContinentName,
      (SUM(CAST((C.AreaInSqKm) AS BIGINT))) AS CountriesArea,
      (SUM(CAST((C.Population) AS BIGINT)))  AS CountriesPopulation
FROM Continents AS CO
LEFT JOIN Countries C on CO.ContinentCode = C.ContinentCode
GROUP BY CO.ContinentName
ORDER BY CountriesPopulation DESC