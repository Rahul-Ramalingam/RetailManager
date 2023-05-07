CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	order by ProductName;
end
