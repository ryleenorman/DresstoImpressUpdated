USE [FashionWeatherDB]
GO
/****** Object:  StoredProcedure [dbo].[IsPriceBelowTwenty]    Script Date: 3/26/2024 2:32:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetPriceDetails]
	@ClothingID int
AS 
BEGIN
SELECT Price  
FROM Clothing 
WHERE ClothingID =@ClothingID;
END
