--USE Geography

--SELECT CountryName, IsoCode FROM [Geography].dbo.Countries
--	WHERE (LEN(CountryName) - LEN(REPLACE(CountryName, 'a', ''))) >= 3
--	ORDER BY IsoCode ASC

SELECT CountryName, IsoCode
FROM Countries
WHERE CountryName like ('%A%A%a%')
ORDER BY IsoCode