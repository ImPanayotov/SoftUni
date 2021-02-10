--Write a query that selects:
--•	CountryCode
--•	MountainRange
--•	PeakName
--•	Elevation
--Filter all peaks in Bulgaria with elevation over 2835. 
--Return all the rows sorted by elevation in descending order.

--CountryCode		MountainRange	PeakName	Elevation
--BG				Rila			Musala		2925
--BG				Pirin			Vihren		2914

SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation 
	FROM Countries AS c
	JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
	JOIN Mountains AS m ON m.Id = mc.MountainId
	JOIN Peaks AS p ON m.Id = p.MountainId
	WHERE c.CountryCode LIKE 'BG'
	  AND p.Elevation > 2835
	ORDER BY p.Elevation DESC


