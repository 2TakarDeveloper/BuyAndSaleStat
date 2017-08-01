using System.Collections.Generic;

namespace TradeInfoSearchApp.Classes
{
    public class BuyerSheet
    {
        public string SheetName { get; set; }
        public List<Buyers> ListOfBuyers { get; set; }


        public BuyerSheet()
        {
            ListOfBuyers= new List<Buyers>();
        }

        public override string ToString()
        {
            return SheetName;
        }
    }
}
