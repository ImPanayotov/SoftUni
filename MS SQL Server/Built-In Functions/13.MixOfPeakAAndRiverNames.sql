SELECT PeakName,
       RiverName,
       LOWER(
		CONCAT(
		 P.PeakName, SUBSTRING(
		  R.RiverName, 2, LEN(
		   R.RiverName) - 1)))
       AS Mix
FROM Peaks AS P,
     Rivers AS R
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix
