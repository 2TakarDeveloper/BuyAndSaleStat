using System;
using System.Collections.Generic;
using System.Linq;
using BNSS.Entity;
using BNSS.Entity.ResultSet;

namespace BNSS.Search
{
    public class BuyerSearch
    {
        #region Buyer

        public static List<Customer> SearchCustomers(string buyerName,
            string itemName, DateTime startDateTime,
            DateTime endDateTime, List<BuyerSheet> buyerSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();

            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    List<Customer> x = buyerSheet.ListOfCustomers
                        .Where(r => r.CustomerName.ToLower().Contains(buyerName.ToLower())
                                    && r.TRADEDT >= startDateTime &&
                                    r.TRADEDT <= endDateTime).ToList();

                    x = x.Where(r => r.ItemName.ToLower().Contains(itemName.ToLower())).Take(rowCount).ToList();

                    returnData.AddRange(x);
                }
                catch (Exception exception)
                {
                    //
                }
            }

            return returnData;
        }


        public static List<ItemGroup> GroupByCustomerName(string buyerName, 
            DateTime startDateTime, DateTime endDateTime, 
            List<BuyerSheet> buyerSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();
            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    returnData.AddRange(buyerSheet.ListOfCustomers
                        .Where(r => r.CustomerName.ToLower().Contains(buyerName.ToLower()) && r.TRADEDT >= startDateTime &&
                                    r.TRADEDT <= endDateTime).ToList());
                }
                catch (Exception)
                {
                    //
                }

            }
            return returnData.GroupBy(x => x.ItemName)
                .Select(cl => new ItemGroup()
                {
                    CustomerName = cl.First().CustomerName,
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e => e.Total).Take(rowCount).ToList();

        }


        public static List<CustomerGroup> GroupByItemName(string itemName,
            DateTime startDateTime, DateTime endDateTime,
            List<BuyerSheet> buyerSheets,
            int rowCount)
        {
            var returnData = new List<Customer>();
            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    returnData.AddRange(buyerSheet.ListOfCustomers
                        .Where(r => r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime &&
                                    r.TRADEDT <= endDateTime).ToList());
                }
                catch (Exception)
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

        #region Unique

        public static List<string> GetUniqueCustomer(List<BuyerSheet> buyerSheets)
        {
            var returnData = new List<Customer>();

            foreach (var buyerSheet in buyerSheets)
            {
                returnData.AddRange(buyerSheet.ListOfCustomers.ToList());
            }

            return returnData.GroupBy(e => e.CustomerName).OrderBy(e => e.Key).Select(cl => cl.Key).ToList();

        }


        public static List<string> GetUniqueItem(List<BuyerSheet> buyerSheets)
        {
            var returnData = new List<Customer>();

            foreach (var buyerSheet in buyerSheets)
            {
                returnData.AddRange(buyerSheet.ListOfCustomers.ToList());
            }

            return returnData.GroupBy(e => e.ItemName).OrderBy(e => e.Key).Select(cl => cl.Key).ToList();

        }


        #endregion


    }
}
