using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeInfoSearchApp.Classes;

namespace TradeInfoSearchApp.Core
{
    public static class SearchInfo
    {
        #region Buyers

        public static List<Buyers> SearchWithBuyerName(string buyerName,string itemName,DateTime startDateTime,DateTime endDateTime,List<BuyerSheet> buyerSheets,int rowCount)
        {
            var returnData=new List<Buyers>();

            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    List<Buyers> x = buyerSheet.ListOfBuyers
                        .Where(r => r.Buyer.ToLower().Contains(buyerName.ToLower())
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


        public static List<ItemGroup> GroupByBuyerName(string buyerName, DateTime startDateTime, DateTime endDateTime, List<BuyerSheet> buyerSheets, int rowCount)
        {
            var returnData=new List<Buyers>();
            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    returnData.AddRange(buyerSheet.ListOfBuyers
                        .Where(r => r.Buyer.ToLower().Contains(buyerName.ToLower()) && r.TRADEDT >= startDateTime &&
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
                    CustomerName = cl.First().Buyer,
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e=>e.Total).Take(rowCount).ToList();

        }


        public static List<CustomerGroup> GroupByItemNameBuyer(string itemName, DateTime startDateTime, DateTime endDateTime, List<BuyerSheet> buyerSheets, int rowCount)
        {
            var returnData = new List<Buyers>();
            foreach (var buyerSheet in buyerSheets)
            {
                try
                {
                    returnData.AddRange(buyerSheet.ListOfBuyers
                        .Where(r => r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime &&
                                    r.TRADEDT <= endDateTime).ToList());
                }
                catch (Exception)
                {
                    //
                }

            }
            return returnData.GroupBy(x => x.Buyer)
                .Select(cl => new CustomerGroup()
                {
                    ItemName = cl.First().ItemName,
                    CustomerName = cl.First().Buyer,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending( e=>e.Total).Take(rowCount).ToList();



        }

        #endregion


        #region Sellers

        public static List<Sellers> SearchWithSellerName(string sellerName,
            string itemName,
            DateTime startDateTime,
            DateTime endDateTime,
            List<SellersSheet> sellersSheets,
            int rowCount)
        {
            var returnData = new List<Sellers>();

            foreach (var sellerSheet in sellersSheets)
            {
                try
                {
                    List<Sellers> x = sellerSheet.SellersList
                        .Where(r => r.Seller.ToLower().Contains(sellerName.ToLower())
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


        public static List<ItemGroup> GroupBySellerName(string sellerName, DateTime startDateTime, DateTime endDateTime, List<SellersSheet> sellersSheets, int rowCount)
        {
            var returnData = new List<Sellers>();

            foreach (var sellerSheet in sellersSheets)
            {
                try
                {
                    returnData.AddRange(sellerSheet.SellersList.Where(r => r.Seller.ToLower().Contains(sellerName.ToLower())  && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList());

                }
                catch (Exception e)
                {
                    //
                }
            }

            return returnData.GroupBy(x => x.ItemName)
                .Select(cl => new ItemGroup
                {
                    CustomerName = cl.First().Seller,
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e=>e.Total).Take(rowCount).ToList();



        }

        public static List<CustomerGroup> GroupByItemNameSeller(string itemName, DateTime startDateTime, DateTime endDateTime, List<SellersSheet> sellersSheets, int rowCount)
        {
            var returnData = new List<Sellers>();

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
            return returnData.GroupBy(x => x.Seller)
                .Select(cl => new CustomerGroup()
                {
                    ItemName = cl.First().ItemName,
                    CustomerName = cl.First().Seller,
                    Total = cl.Sum(c => c.Total)
                }).OrderByDescending(e => e.Total).Take(rowCount).ToList();



        }

        #endregion

        #region Unique

        public static List<string> GetUniqueCustomer(List<BuyerSheet> buyerSheets)
        {
            var returnData = new List<Buyers>();

            foreach (var buyerSheet in buyerSheets)
            {
                returnData.AddRange(buyerSheet.ListOfBuyers.ToList());
            }

            return returnData.GroupBy(e => e.Buyer).OrderBy(e=>e.Key).Select(cl=>cl.Key).ToList();

        }


        public static List<string> GetUniqueItem(List<BuyerSheet> buyerSheets)
        {
            var returnData = new List<Buyers>();

            foreach (var buyerSheet in buyerSheets)
            {
                returnData.AddRange(buyerSheet.ListOfBuyers.ToList());
            }

            return returnData.GroupBy(e => e.ItemName).OrderBy(e=>e.Key).Select(cl => cl.Key).ToList();

        }


        #endregion


    }
}
