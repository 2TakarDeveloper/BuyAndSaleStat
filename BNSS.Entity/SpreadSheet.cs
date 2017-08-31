using System.Collections.Generic;

namespace BNSS.Entity
{
    public class SpreadSheet
    {
        public List<BuyerSheet> BuyerSheets { get; set; }
        public List<SellerSheet> SellerSheets { get; set; }

        public SpreadSheet()
        {
            BuyerSheets = new List<BuyerSheet>();
            SellerSheets = new List<SellerSheet>();
        }
    }
}
