using System;
using System.IO;
using System.Text.RegularExpressions;
using BNSS.Entity;
using ExcelDataReader;

namespace BNSS.Parser
{
    public class ExcelParser
    {
        //This Function Parses Specific Excel Data into The Static Spreadsheet Class in ENTITY
        public static void ExcelReader(string path)
        {
            string filePath = path;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
                    do
                    {
                        reader.Read();

                        if (Regex.IsMatch(reader.Name, "[BB]")) //buyer
                        {
                            var buyerSheet = new BuyerSheet { SheetName = reader.Name };
                            while (reader.Read())
                            {
                                try
                                {
                                    Customer buyer = new Customer()
                                    {
                                        TRADEDT = DateTime.Parse(reader.GetValue(0).ToString()),
                                        CustomerName = reader.GetValue(1).ToString(),
                                        ItemName = reader.GetValue(2).ToString(),
                                        Total = Double.Parse(reader.GetValue(3).ToString())
                                    };

                                    buyerSheet.ListOfCustomers.Add(buyer);
                                }
                                catch (Exception e)
                                {
                                    //
                                }
                            }
                            if (!Globals.StaticVariables.SpreadSheet.BuyerSheets.Contains(buyerSheet))
                            {
                                Globals.StaticVariables.SpreadSheet.BuyerSheets.Add(buyerSheet);
                            }


                        }


                        if (Regex.IsMatch(reader.Name, "[SS]")) //Seller
                        {
                            var sellersSheet = new SellerSheet() { SheetName = reader.Name };

                            while (reader.Read())
                            {
                                try
                                {
                                    Customer seller =
                                        new Customer
                                        {
                                            TRADEDT = DateTime.Parse(reader.GetValue(0).ToString()),
                                            CustomerName = reader.GetValue(1).ToString(),
                                            ItemName = reader.GetValue(2).ToString(),
                                            Total = Double.Parse(reader.GetValue(3).ToString())
                                        };
                                    sellersSheet.SellersList.Add(seller);
                                }
                                catch (Exception e)
                                {
                                   //
                                }
                            }
                            if (!Globals.StaticVariables.SpreadSheet.SellerSheets.Contains(sellersSheet))
                            {
                                Globals.StaticVariables.SpreadSheet.SellerSheets.Add(sellersSheet);
                            }
                        }
                    } while (reader.NextResult());
                }
            }

        }


    }
}
