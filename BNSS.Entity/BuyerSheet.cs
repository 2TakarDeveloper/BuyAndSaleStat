
using System.Collections.Generic;


namespace BNSS.Entity
{
    public  class BuyerSheet
    {
        public string SheetName { get; set; }
        public List<Customer> ListOfCustomers { get; set; }


        public BuyerSheet()
        {
            ListOfCustomers = new List<Customer>();
        }

        public override string ToString()
        {
            return SheetName;
        }
    }
}
