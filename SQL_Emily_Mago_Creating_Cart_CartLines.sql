USE FashionWeatherDB;
GO

Create Table Cart(
	CartID uniqueidentifier NOT NULL primary key 
		DEFAULT newid(), 
	UserID int NOT NULL 
	)
GO

Create TABLE CartLines (
	 CartID uniqueidentifier references Cart(CartID) not null, 
	 ClothingID int references Clothing(ClothingID) not null, 
	 Price money not null, 
	 Quantity int not null 
)
GO 
