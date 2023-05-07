CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasePrice] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Inventory_ToProduct] FOREIGN KEY (ProductId) REFERENCES Product(Id)
)
