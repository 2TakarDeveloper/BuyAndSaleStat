using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeInfoSearchApp.Classes
{
    public class SpreadSheet
    {
        public List<BuyerSheet> BuyersSheets { get; set; }
        public List<SellersSheet> SellersSheets { get; set; }

        public SpreadSheet()
        {
            BuyersSheets=new List<BuyerSheet>();
            SellersSheets= new List<SellersSheet>();
        }

    }
}
