using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeInfoSearchApp.Classes
{
    public class SellersSheet
    {
        public string SheetName { get; set; }
        public List<Sellers> SellersList { get; set; }

        public SellersSheet()
        {
            SellersList=new List<Sellers>();
        }

        public override string ToString()
        {
            return SheetName;
        }
    }
}
