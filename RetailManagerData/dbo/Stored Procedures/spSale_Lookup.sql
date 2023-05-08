CREATE PROCEDURE [dbo].[spSale_Lookup]
	@CashierId nvarchar(128),
	@Saledate datetime2
AS
begin
	set nocount on;

	Select Id
	from dbo.Sale
	where CashierId = @CashierId and SaleDate = @Saledate; 
end
