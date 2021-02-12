--	Your task is to create a function ufn_CalculateFutureValue that accepts as parameters – 
--		sum (decimal), 
--		yearly interest rate (float) and 
--		number of years(int). 
--	It should calculate and return the future value of the initial 
--	sum rounded to the fourth digit after the decimal delimiter. 
--	Using the following formula:
--	FV=I×(〖(1+R)〗^T)
--		I – Initial sum
--		R – Yearly interest rate
--		T – Number of years
--	Example
--	Input	Output
--	Initial sum: 1000
--	Yearly Interest rate: 10%
--	years: 5
--	ufn_CalculateFutureValue(1000, 0.1, 5)	1610.5100

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18,4), @rate FLOAT, @years INT)
RETURNS DECIMAL (18,4)
BEGIN
DECLARE @Result AS DECIMAL(18,4) = @sum * (POWER((1+@rate), @years))


RETURN @Result
END

DECLARE @Res DECIMAL(18,4) = dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
SELECT @Res