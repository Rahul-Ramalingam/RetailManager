﻿CREATE PROCEDURE [dbo].[sp_SaleReport]
AS
BEGIN
	set nocount on;

	select [s].[Id], [s].[CashierId], [s].[SaleDate], [s].[SubTotal], [s].[Tax], [s].[Total], [u].[Id], [u].[FirstName], [u].[LastName], [u].[EmailAddress]
	from dbo.Sale s
	inner join dbo.[User] u on s.CashierId = u.Id;
END