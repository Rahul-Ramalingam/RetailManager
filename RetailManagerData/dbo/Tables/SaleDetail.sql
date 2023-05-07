CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [ProductId] INT NOT NULL,
    [Quantity] NVARCHAR(10) NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    CONSTRAINT [FK_SaleDetail_ToSale] FOREIGN KEY (SaleId) REFERENCES [Sale](Id), 
    CONSTRAINT [FK_SaleDetail_ToProduct] FOREIGN KEY (ProductId) REFERENCES Product(Id), 
)
