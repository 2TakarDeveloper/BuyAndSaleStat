using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNSS.Entity;
using BNSS.Globals;

namespace BNSS.Local
{
    public class ModifyData
    {
        public static void RemoveBuyerSheetList(List<BuyerSheet> buyerSheets)
        {
            foreach (var buyerSheet in buyerSheets)
            {
                StaticVariables.SpreadSheet.BuyerSheets.Remove(buyerSheet);
            }
        }


        public static void RemoveSellerSheetList(List<SellerSheet> sellerSheets)
        {
            foreach (var sellerSheet in sellerSheets)
            {
                StaticVariables.SpreadSheet.SellerSheets.Remove(sellerSheet);
            }
        }


    }
}
