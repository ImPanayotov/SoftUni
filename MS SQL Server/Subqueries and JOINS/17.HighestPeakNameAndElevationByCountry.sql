--For each country, find the elevation of the highest peak and the length 
--of the longest river, 
--sorted by the highest peak elevation 
--(from highest to lowest), then by the longest river length 
--(from longest to smallest), then by country name (alphabetically). 

--Display NULL when no data is available in some of the columns. 

--Limit only the first 5 rows.

--CountryName	HighestPeakElevation	LongestRiverLength
--China			8848					6300

SELECT TOP (5) CountryName,
               MAX(p.Elevation) AS HightestPeakElevation,
               MAX(r2.Length)   AS LongestRiverLength
FROM Countries AS c
         LEFT OUTER JOIN MountainsCountries MC ON c.CountryCode = MC.CountryCode
         LEFT OUTER JOIN Mountains M ON MC.MountainId = M.Id
         LEFT OUTER JOIN Peaks P ON M.Id = P.MountainId
         LEFT OUTER JOIN CountriesRivers CR ON c.CountryCode = CR.CountryCode
         LEFT OUTER JOIN Rivers R2 ON CR.RiverId = R2.Id
GROUP BY c.CountryName
ORDER BY HightestPeakElevation DESC,
         LongestRiverLength DESC,
         CountryName ASC


