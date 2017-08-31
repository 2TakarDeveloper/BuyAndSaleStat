using System.Collections.Generic;
using BNSS.Entity;
using BNSS.Entity.ResultSet;
using ClosedXML.Excel;

namespace BNSS.Export
{
    public class DataExport
    {
       
        //Constructor Creates an WorkBook. And takes filepath as input.
        //Functions Populated Worksheet then save it.
        //Works For Both buyer and seller as the data has same structure
        private XLWorkbook WorkBook { get; set; }

        private IXLWorksheet WorkSheet { get; set; }

        private string FilePath { get; set; }

        public DataExport(string filepath)
        {
            WorkBook = new XLWorkbook();
            WorkBook.AddWorksheet("SearchResult");
            WorkSheet = WorkBook.Worksheet("SearchResult");
            FilePath = filepath;
        }

        public  void ExportCustomerData(List<Customer> customers,double total)
        {
               
                int row = 1;
                foreach (Customer customer in customers)
                {
                    WorkSheet.Cell("A" + row).Value = customer.TRADEDT;
                    WorkSheet.Cell("B" + row).Value = customer.CustomerName;
                    WorkSheet.Cell("C" + row).Value = customer.ItemName;
                    WorkSheet.Cell("D" + row).Value = customer.Total;

                    row++;
                }
                WorkSheet.Cell("C" + row).Value = "Total=";
                WorkSheet.Cell("D" + row).Value = total;

             Save();
        }

        public  void GroupByItemExport(List<CustomerGroup> customers)
        {
            int row = 1;
            foreach (CustomerGroup item in customers)
            {
                WorkSheet.Cell("A" + row).Value = item.ItemName;
                WorkSheet.Cell("B" + row).Value = item.CustomerName;
                WorkSheet.Cell("C" + row).Value = item.Total;
                row++;
            }

           Save();

        }

        public void GroupByCustomerExport(List<ItemGroup> items)
        {
            int row = 1;
            foreach (ItemGroup item in items)
            {
                WorkSheet.Cell("A" + row).Value = item.CustomerName;
                WorkSheet.Cell("B" + row).Value = item.ItemName;
                WorkSheet.Cell("C" + row).Value = item.Total;
                row++;
            }

            Save();

        }


        private void Save()
        {
            WorkBook.SaveAs(FilePath);
        }


    }
}
