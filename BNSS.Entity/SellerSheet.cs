using System.Collections.Generic;

namespace BNSS.Entity
{
    public class SellerSheet
    {
        public string SheetName { get; set; }
        public List<Customer> SellersList { get; set; }

        public SellerSheet()
        {
            SellersList = new List<Customer>();
        }

        public override string ToString()
        {
            return SheetName;
        }
    }
}
