using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNSS.Entity.ResultSet;

namespace BNSS.Search
{
    public class CompanySummary
    {
        public static List<ItemGroup> CustomerSummary(List<ItemGroup> buyingList,List<ItemGroup> sellingList)
        {
            List<ItemGroup> result = (from x1 in buyingList
                join x2 in sellingList on x1.ItemName equals x2.ItemName into temp
                from x2 in temp.DefaultIfEmpty()
                select new ItemGroup
                {
                    CustomerName = x1.CustomerName,
                    ItemName = x1.ItemName,
                    Total = x1.Total - (x2?.Total ?? 0)
                }).ToList();
   
            return result;
        }


        public static List<CustomerGroup> ItemSummary(List<CustomerGroup> buyingList, List<CustomerGroup> sellingList)
        {

            List<CustomerGroup> result = (from x1 in buyingList
                join x2 in sellingList on x1.CustomerName equals x2.CustomerName into temp
                from x2 in temp.DefaultIfEmpty()
                select new CustomerGroup()
                {
                    ItemName = x1.ItemName,
                    CustomerName = x1.CustomerName,
                    Total = x1.Total - (x2?.Total ?? 0)
                }).ToList();

            return result;
        }

    }
}
