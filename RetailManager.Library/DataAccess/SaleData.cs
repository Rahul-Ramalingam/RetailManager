﻿using RetailManager.Library.Internal.DataAccess;
using RetailManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManager.Library.DataAccess
{
    public class SaleData
    {
        public void SaveSale(SaleModel saleInfo, string cashierId)
        {
            List<SaleDetailDBModel> details = new List<SaleDetailDBModel>();
            ProductData products = new ProductData();
            decimal taxRate = ConfigHelper.GetTaxRate() / 100;

            foreach (SaleDetailModel item in saleInfo.SaleDetails)
            {
                SaleDetailDBModel detail = new SaleDetailDBModel
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,

                };
                ProductModel productInfo = products.GetProductById(detail.ProductId);

                if (productInfo == null)
                {
                    throw new Exception($"The Prodct Id - {detail.ProductId} is not found in the database");
                }

                detail.PurchasePrice = productInfo.RetailPrice * detail.Quantity;

                if (productInfo.IsTaxable)
                {
                    detail.Tax = detail.PurchasePrice * taxRate;
                };

                details.Add(detail);
            }

            SaleDBModel sale = new SaleDBModel
            {
                CashierId = cashierId,
                SubTotal = details.Sum(x => x.PurchasePrice),
                Tax = details.Sum(x => x.Tax)
            };

            sale.Total = sale.SubTotal + sale.Tax;

            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData("dbo.spSale_Insert", sale, "RetailManagerData");

            sale.Id = sql.LoadData<int, dynamic>("spSale_Lookup", new { sale.CashierId, sale.Saledate }, "RetailManagerData").FirstOrDefault();

            foreach (var item in details)
            {
                item.SaleId = sale.Id;
                sql.SaveData("dbo.spSaleDetail_Insert", item, "RetailManagerData");
            }
        }
    }
}
