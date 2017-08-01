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
                returnData.AddRange( buyerSheet.ListOfBuyers.Where(r => r.Buyer.ToLower().Contains(buyerName.ToLower())&& r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT>=startDateTime && r.TRADEDT<=endDateTime ).Take( rowCount).ToList());
            }

            return returnData;
        }


        public static List<ItemGroup> GroupByBuyerName(string buyerName, DateTime startDateTime, DateTime endDateTime, List<Buyers> buyerList, int rowCount)
        {
            var returnData = buyerList.Where(r => r.Buyer.ToLower().Contains(buyerName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList();

            return returnData.GroupBy(x => x.ItemName)
                .Select(cl => new ItemGroup()
                {
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).Take(rowCount).ToList();

        }


        public static List<CustomerGroup> GroupByItemNameBuyer(string itemName, DateTime startDateTime, DateTime endDateTime, List<Buyers> buyerList, int rowCount)
        {
            var returnData = buyerList.Where(r => r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList();

            return returnData.GroupBy(x => x.Buyer)
                .Select(cl => new CustomerGroup()
                {
                    CustomerName = cl.First().Buyer,
                    Total = cl.Sum(c => c.Total)
                }).Take(rowCount).ToList();



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
                returnData.AddRange( sellerSheet.SellersList.Where(r => r.Seller.ToLower().Contains(sellerName.ToLower()) && r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).Take(rowCount).ToList());
            }

            return returnData;
        }


        public static List<ItemGroup> GroupBySellerName(string sellerName, DateTime startDateTime, DateTime endDateTime, List<Sellers> sellerList, int rowCount)
        {
            var returnData = sellerList.Where(r => r.Seller.ToLower().Contains(sellerName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList();

            return returnData.GroupBy(x => x.ItemName)
                .Select(cl => new ItemGroup
                {
                    ItemName = cl.First().ItemName,
                    Total = cl.Sum(c => c.Total)
                }).Take(rowCount).ToList();



        }

        public static List<CustomerGroup> GroupByItemNameSeller(string itemName, DateTime startDateTime, DateTime endDateTime, List<Sellers> sellerList, int rowCount)
        {
            var returnData = sellerList.Where(r => r.ItemName.ToLower().Contains(itemName.ToLower()) && r.TRADEDT >= startDateTime && r.TRADEDT <= endDateTime).ToList();

            return returnData.GroupBy(x => x.Seller)
                .Select(cl => new CustomerGroup()
                {
                    CustomerName = cl.First().Seller,
                    Total = cl.Sum(c => c.Total)
                }).Take(rowCount).ToList();



        }

        #endregion


    }
}
