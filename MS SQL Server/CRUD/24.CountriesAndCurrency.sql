SELECT CountryName, CountryCode,
	CASE
		WHEN CurrencyCode = 'Eur' THEN 'Euro'
		ELSE 'Not Euro'
	END  AS 'Currency'
FROM Countries
ORDER BY CountryName


SELECT * FROM Countries