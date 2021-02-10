--Write a query that selects:
--•	ContinentCode
--•	CurrencyCode
--•	CurrencyUsage
--Find all continents and their most used currency. 
--Filter any currency that is used in only one country. 
--Sort your results by ContinentCode.

--ContinentCode	CurrencyCode	CurrencyUsage
--AF				XOF				8
--AS				AUD				2
--AS				ILS				2
--EU				EUR				26
--NA				XCD				8
--OC				USD				8

--Countries Without Any Mountains
--Find all the count of all countries, which don’t have a mountain.

--Count
--231

SELECT ContinentCode, CurrencyCode, CurrencyCount AS CurrencyUsage
FROM (SELECT ContinentCode,
             CurrencyCode,
             CurrencyCount,
             DENSE_RANK()
                     OVER (PARTITION BY ContinentCode
                         ORDER BY CurrencyCount DESC) AS CurrencyRank
      FROM (SELECT ContinentCode,
                   CurrencyCode,
                   COUNT(*) AS CurrencyCount
            FROM Countries
            GROUP BY ContinentCode, CurrencyCode
           ) AS CurrencyCountQuery
      WHERE CurrencyCount > 1) AS CurrencyRankingQuery
WHERE CurrencyRank=1
ORDER BY ContinentCode
