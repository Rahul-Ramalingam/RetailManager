CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [PorductId] INT NOT NULL,
    [Quantity] NVARCHAR(10) NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
)
