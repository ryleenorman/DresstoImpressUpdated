USE FashionWeatherDB;
GO

create procedure SeeOccupation
	@UserID int
As
Select UserID, UserOccupation 
From USERS
Where UserID=@UserID; 
GO
/*
Execute SeeOccupation @UserID =1; 
*/
