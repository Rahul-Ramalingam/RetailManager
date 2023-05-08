CREATE PROCEDURE [dbo].[spProduct_GetById]
	@Id int
AS
begin
	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	where Id = @Id;
end
