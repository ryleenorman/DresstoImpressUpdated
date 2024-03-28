USE FashionWeatherDB;
GO

CREATE PROCEDURE IsPriceBelowTwenty
    @ClothingID int,
    @isBelow bit OUTPUT
AS
BEGIN
    DECLARE @price money;
    SELECT @price = Price 
    FROM Clothing 
    WHERE ClothingID = @ClothingID;
    
    IF @price < 20.0 -- Assuming you want to check if the price is below 20
        SET @isBelow = 1;
    ELSE
        SET @isBelow = 0;
END;
GO
/*
DECLARE @result bit;
EXEC IsPriceBelowTwenty @ClothingID = 74, @isBelow = @result OUTPUT;
PRINT @result
*/
