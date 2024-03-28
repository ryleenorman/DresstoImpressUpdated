USE FashionWeatherDB;
GO

CREATE TABLE [dbo].[Weather] (
    [WeatherID] int NOT NULL identity primary key,
    [WeatherType] nvarchar(max),
    [Temperature] nvarchar(max),
    [Precipitation] nvarchar(max)
)
GO

CREATE TABLE [dbo].[Clothing] (
    [ClothingID] int NOT NULL identity primary key,
    [ClothingType] nvarchar(max),
    [ClothingSize] nvarchar(max),
    [ClothingColor] nvarchar(max),
    [ClothingSeason] nvarchar(max),
	[Price] money
)
GO

CREATE TABLE [dbo].[USERS] (
    [UserID] int NOT NULL identity primary key,
    [UserDoB] date NOT NULL,
    [UserOccupation] nvarchar(max)
)
GO

CREATE TABLE [dbo].[Outfit] (
    [OutfitID] int NOT NULL identity primary key,
    [WeatherID] int NOT NULL,
    [ClothingID] int NOT NULL,
    [OutfitOccasion] nvarchar(max),
    FOREIGN KEY (WeatherID) REFERENCES Weather(WeatherID),
    FOREIGN KEY (ClothingID) REFERENCES Clothing(ClothingID)
)
GO