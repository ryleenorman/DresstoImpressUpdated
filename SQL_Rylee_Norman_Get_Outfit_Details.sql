USE FashionWeatherDB;
GO

Create Procedure GetOutfitDetails
	@OutfitID int
AS
Select * from Outfit
Where OutfitID = @OutfitID; 
GO
/*
Execute GetOutfitDetails @OutfitID =73;
*/
