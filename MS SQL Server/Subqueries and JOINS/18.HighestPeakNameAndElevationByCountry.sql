SELECT TOP (5) Country,
               CASE
                   WHEN PeakName IS NULL THEN '(no highest peak)'
                   ELSE PeakName
                   END AS [Highest Peak Name],
               CASE
                   WHEN Elevation IS NULL THEN 0
                   ELSE Elevation
                   END AS [Highest Peak Elevation],
               CASE
                   WHEN Mountain IS NULL THEN '(no mountain)'
                   ELSE Mountain
                   END AS Mountain
FROM (
         SELECT *,
                DENSE_RANK() OVER (PARTITION BY Country ORDER BY Elevation DESC)
                    AS PeakRank
         FROM (SELECT CountryName     AS Country,
                      p.PeakName,
                      p.Elevation,
                      M.MountainRange AS Mountain
               FROM Countries AS c
                        LEFT OUTER JOIN MountainsCountries MC
                                        ON c.CountryCode = MC.CountryCode
                        LEFT OUTER JOIN Mountains M
                                        ON MC.MountainId = M.Id
                        LEFT OUTER JOIN Peaks P
                                        ON M.Id = P.MountainId)
                  AS AllPeaksQuery)
         AS PeakRankingQuery
WHERE PeakRank = 1
ORDER BY Country, [Highest Peak Name]