CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY , 
    [ProductId] INT NOT NULL, 
    [Quantity] INT  DEFAULT 1  NOT  NULL, 
    [PurchasePrice] MONEY NOT  NULL, 
    [PurchaseDate] NCHAR(10)  NOT NULL
)
