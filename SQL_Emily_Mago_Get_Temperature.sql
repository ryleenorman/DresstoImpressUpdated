USE FashionWeatherDB;
GO

Create Procedure GetTemperature 
	@WeatherID int
AS 
Select WeatherID, Temperature 
From Weather 
Where WeatherID =@WeatherID;
GO
/*
Execute GetTemperature @WeatherID =1; 
*/
