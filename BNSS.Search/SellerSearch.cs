using System;
using System.Collections.Generic;
using System.Linq;

using BNSS.Entity;
using BNSS.Entity.ResultSet;

namespace BNSS.Search
{
    public class SellerSearch
    {
        #region Seller

        public static List<Customer> SearchCustomers(string sellerName,
            string itemName,
            DateTime startDateTime,
            DateTime endDateTime,
            List<SellerSheet> sellersSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();

            foreach (var sellerSheet in sellersSheets)
            {
                try
                {
                    List<Customer> x = sellerSheet.SellersList
                        .Where(r => r.CustomerName.ToLower().Contains(sellerName.ToLower())
                                    && r.TRADEDT >= startDateTime &&
                                    r.TRADEDT <= endDateTime).ToList();

                    x = x.Where(r => r.ItemName.ToLower().Contains(itemName.ToLower())).Take(rowCount).ToList();

                    returnData.AddRange(x);
                }
                catch (Exception e)
                {
                    //
                }

            }

            return returnData;
        }


        public static List<ItemGroup> GroupByCustomerName(string sellerName,
            DateTime startDateTime, DateTime endDateTime,
            List<SellerSheet> sellersSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();

            foreach (var sellerSheet in sellersSheets)
            {
                try
                {
                    returnData.AddRange(sellerSheet.SellersList.Where(r => r.CustomerName.ToLower().Contains(sellerName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList());

                }
                catch (Exception e)
                {
                    //
                }
            }

            return returnData.GroupBy(x => x.ItemName)
                .Select(cl => new ItemGroup
                {
                    CustomerName = cl.First().CustomerName,
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e => e.Total).Take(rowCount).ToList();



        }

        public static List<CustomerGroup> GroupByItemName(string itemName,
            DateTime startDateTime,
            DateTime endDateTime,
            List<SellerSheet> sellersSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();

            foreach (var sellerSheet in sellersSheets)
            {
                try
                {
                    returnData.AddRange(sellerSheet.SellersList.Where(r => r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList());

                }
                catch (Exception e)
                {
                    //
                }
            }
            return returnData.GroupBy(x => x.CustomerName)
                .Select(cl => new CustomerGroup()
                {
                    ItemName = cl.First().ItemName,
                    CustomerName = cl.First().CustomerName,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e => e.Total).Take(rowCount).ToList();



        }


        #endregion
    }
}
