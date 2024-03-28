USE FashionWeatherDB;
GO

INSERT INTO [dbo].[Weather] ([WeatherType], [Temperature], [Precipitation])
VALUES 
    (N'Sunny', N'25°C', N'Dry'),
    (N'Rainy', N'18°C', N'Heavy rain'),
    (N'Cloudy', N'22°C', N'Light rain'),
    (N'Snowy', N'0°C', N'Snow')
GO

INSERT INTO [dbo].[Clothing] ([ClothingType], [ClothingSize], [ClothingColor], [ClothingSeason], [Price])
VALUES 
    (N'T-Shirt', N'M', N'Red', N'Summer', 19.99),
    (N'Jeans', N'32', N'Blue', N'All Seasons', 39.99),
    (N'Sweater', N'L', N'Gray', N'Winter', 49.99),
    (N'Dress', N'S', N'Black', N'Spring', 29.99);
GO

INSERT INTO [dbo].[USERS] ([UserDoB], [UserOccupation])
VALUES 
    ('1990-05-15', N'Engineer'),
    ('1985-12-10', N'Teacher'),
    ('1998-08-22', N'Designer'),
    ('1973-03-28', N'Doctor')
GO
INSERT INTO [dbo].[Outfit] ([WeatherID], [ClothingID], [OutfitOccasion])
VALUES 
    (1, 1, N'Casual'),
    (2, 3, N'Formal'),
    (3, 2, N'Outdoor'),
    (4, 4, N'Winter Sports')
GO 
