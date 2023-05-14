CREATE PROCEDURE [dbo].[spInventory_Insert]
@ProductId int,
@Quantity int,
@PurchasePrice money,
@purchaseDate datetime2
AS
BEGIN
	set nocount on;

	insert into dbo.Inventory(ProductId,Quantity,PurchasePrice,purchaseDate)
	values (@ProductId,@Quantity,@PurchasePrice,@purchaseDate)
END