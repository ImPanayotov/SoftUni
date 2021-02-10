--Countries Without Any Mountains
--Find all the count of all countries, which don’t have a mountain.
--Example
--Count
--231

SELECT COUNT(*) AS [Count] FROM Countries AS c
			LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
			WHERE mc.MountainId IS NULL