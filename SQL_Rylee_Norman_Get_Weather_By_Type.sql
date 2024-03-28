USE [FashionWeatherDB]
GO

DECLARE @RC int
DECLARE @WeatherID int

-- TODO: Set parameter values here.

EXECUTE @RC = [dbo].[GetWeatherByType] 
   @WeatherID
GO

