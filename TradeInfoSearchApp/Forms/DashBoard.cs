using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClosedXML.Excel;
using Excel;
using MetroFramework;
using Newtonsoft.Json;
using TradeInfoSearchApp.Classes;
using TradeInfoSearchApp.Core;

namespace TradeInfoSearchApp.Forms
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        private SpreadSheet SpreadSheet { get; set; }


        private double buyingTotal;
        private double sellingTotal;

        public DashBoard()
        {
            InitializeComponent();
            SpreadSheet=new SpreadSheet();
            
            UserSettings.LoadSettings();
            if (UserSettings.Enabled)
            {
                LoadLocalData();
            }
            else
            {
                LicenceDialague ld = new LicenceDialague();
                if (ld.ShowDialog() == DialogResult.OK)
                {

                    LoadLocalData();
                }
                else
                {
                    Close();
                }
            }



        }

        


        void LoadData()
        {
           

            foreach (BuyerSheet sheet in SpreadSheet.BuyersSheets)
            {
                TablesComboBox.Items.Add(sheet);
            }

            foreach (SellersSheet sheet in SpreadSheet.SellersSheets)
            {
                TablesComboBox.Items.Add(sheet);
            }

            if(TablesComboBox.Items.Count<=0)return;
            TablesComboBox.SelectedIndex = 0;

            itemBox.DataSource = SearchInfo.GetUniqueItem(SpreadSheet.BuyersSheets);
            SearchBox.DataSource = SearchInfo.GetUniqueCustomer(SpreadSheet.BuyersSheets);

        }

        
        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TablesComboBox.SelectedItem.ToString(), "[BB]")) //buyer
            {

                BuyerSheet buyerSheet = (BuyerSheet) TablesComboBox.SelectedItem;
                BuyingGrid.DataSource = buyerSheet.ListOfBuyers;

            }

            if (Regex.IsMatch(TablesComboBox.SelectedItem.ToString(), "[SS]")) //buyer
            {
                SellersSheet sellersSheet = (SellersSheet)TablesComboBox.SelectedItem;
                SellingGrid.DataSource =sellersSheet.SellersList ;
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ExcelReader(openFileDialog.FileName);
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
           
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            statusTextLabel.Text = e.ProgressPercentage + @"%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadData();
            SaveLocalData();
            statusTextLabel.Visible = false;
            metroProgressBar1.Visible = false;
        }

        private void LoadLocalData()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json"))
            {
                using (StreamReader file = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    SpreadSheet = (SpreadSheet)serializer.Deserialize(file, typeof(SpreadSheet));
                }
            }
            
          

            LoadData();
        }

        private void SaveLocalData()
        {
            using (StreamWriter file = File.CreateText(AppDomain.CurrentDomain.BaseDirectory+ @"\memory.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, SpreadSheet);
                }

          
        }
       
       

        private void Search_initate(object sender, EventArgs e)
        {
            var groupBy = GroupByChecker.Checked;
            BuyingGrid.DataSource = null;
            SellingGrid.DataSource = null;
            try
            {
                if (groupBy)
                {
                    SellerrsTotalLable.Text = "";
                    buyersTotalLable.Text = "";
                    switch (GroupBox.Text)
                    {
                        case @"Customer":
                            BuyingGrid.DataSource = SearchInfo.GroupByBuyerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, SpreadSheet.BuyersSheets, (int)buyerRow.Value);

                            SellingGrid.DataSource= SearchInfo.GroupBySellerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, SpreadSheet.SellersSheets, (int)sellerRow.Value);
                            break;
                        case @"Item":
                            BuyingGrid.DataSource = SearchInfo.GroupByItemNameBuyer(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, SpreadSheet.BuyersSheets, (int)buyerRow.Value);

                            SellingGrid.DataSource = SearchInfo.GroupByItemNameSeller(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, SpreadSheet.SellersSheets, (int)sellerRow.Value);
                            break;
                    }
                }
                else
                {
                    var buyers = SearchInfo.SearchWithBuyerName(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, SpreadSheet.BuyersSheets, (int) buyerRow.Value);

                    var sellers = SearchInfo.SearchWithSellerName(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, SpreadSheet.SellersSheets, (int) sellerRow.Value);

                    BuyingGrid.DataSource = buyers;

                    SellingGrid.DataSource = sellers;

                    buyingTotal = 0;
                    foreach (var buyer in buyers)
                        buyingTotal += buyer.Total;
                    buyersTotalLable.Text = @"Total:" + buyingTotal;

                    sellingTotal = 0;
                    foreach (var seller in sellers)
                        sellingTotal += seller.Total;
                    SellerrsTotalLable.Text = @"Total:" + sellingTotal;


                    #region DataCell Style


                    var colorSwitch = true;
                    var counter = 0;
                    foreach (DataGridViewRow row in BuyingGrid.Rows)
                    {
                        row.DefaultCellStyle.ForeColor =
                            colorSwitch ? UserSettings.RowColor1 : UserSettings.RowColor2;

                        counter++;
                        if (counter == (int)buyerRow.Value)
                        {
                            counter = 0;
                            colorSwitch = !colorSwitch;
                        }
                        
                      

                    }


                    colorSwitch = true;
                    counter = 0;
                    foreach (DataGridViewRow row in SellingGrid.Rows)
                    {
                        row.DefaultCellStyle.ForeColor =
                            colorSwitch ? UserSettings.RowColor1 : UserSettings.RowColor2;
                        counter++;
                        if (counter == (int)sellerRow.Value)
                        {
                            counter = 0;
                            colorSwitch = !colorSwitch;
                        }
                        
                       
                    }



                    #endregion

                }
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        void ExcelReader(string path)
        {
            int b = 0;
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
                                Buyers buyer = new Buyers
                                {
                                    TRADEDT = DateTime.Parse(reader.GetValue(0).ToString()),
                                    Buyer = reader.GetValue(1).ToString(),
                                    ItemName = reader.GetValue(2).ToString(),
                                    Total = Double.Parse(reader.GetValue(3).ToString())
                                };

                                buyerSheet.ListOfBuyers.Add(buyer);
                            }
                            if (!SpreadSheet.BuyersSheets.Contains(buyerSheet))
                            {
                                SpreadSheet.BuyersSheets.Add(buyerSheet);
                            }


                        }


                        if (Regex.IsMatch(reader.Name, "[SS]")) //buyer
                        {
                            var sellersSheet = new SellersSheet() { SheetName = reader.Name };

                            while (reader.Read())
                            {
                                Sellers seller = new Sellers
                                {
                                    TRADEDT = reader.GetDateTime(0),
                                    Seller = reader.GetString(1),
                                    ItemName = reader.GetString(2),
                                    Total = reader.GetDouble(3)
                                };
                                sellersSheet.SellersList.Add(seller);
                            }
                            if (!SpreadSheet.SellersSheets.Contains(sellersSheet))
                            {
                                SpreadSheet.SellersSheets.Add(sellersSheet);
                            }


                        }

                        var a = reader.ResultsCount;
                        var progress = b++ * 100 / a;
                        backgroundWorker.ReportProgress(progress);
                    } while (reader.NextResult());

                    backgroundWorker.ReportProgress(100);



                }
            }




        }

        private void BuyersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)return;
           
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("BB_SearchResult");
            var ws = workbook.Worksheet("BB_SearchResult");

            if (!GroupByChecker.Checked)
            {
                List<Buyers> buyers = SearchInfo.SearchWithBuyerName(SearchBox.Text, itemBox.Text,
                    startDateTime.Value,
                    EndDateTime.Value, SpreadSheet.BuyersSheets, (int) buyerRow.Value);
                int row = 1;
                foreach (Buyers item in buyers)
                {
                    ws.Cell("A" + row).Value = item.TRADEDT;
                    ws.Cell("B" + row).Value = item.Buyer;
                    ws.Cell("C" + row).Value = item.ItemName;
                    ws.Cell("D" + row).Value = item.Total;

                    row++;
                }
                ws.Cell("C" + row).Value = "Total=";
                ws.Cell("D" + row).Value = buyingTotal;
            }
            else
            {
                switch (GroupBox.Text)
                {
                    case @"Item":
                        List<CustomerGroup> Customers = SearchInfo.GroupByItemNameBuyer( itemBox.Text,
                            startDateTime.Value,
                            EndDateTime.Value, SpreadSheet.BuyersSheets, (int)buyerRow.Value);
                        int row = 1;
                        foreach (CustomerGroup item in Customers)
                        {
                            ws.Cell("A" + row).Value = item.ItemName;
                            ws.Cell("B" + row).Value = item.CustomerName;
                            ws.Cell("C" + row).Value = item.Total;
                            row++;
                        }
                        break;
                    case @"Customer":
                        List<ItemGroup> items = SearchInfo.GroupByBuyerName(SearchBox.Text,
                            startDateTime.Value,
                            EndDateTime.Value, SpreadSheet.BuyersSheets, (int)buyerRow.Value);
                        row = 1;
                        foreach (ItemGroup item in items)
                        {
                            ws.Cell("A" + row).Value = item.CustomerName;
                            ws.Cell("B" + row).Value = item.ItemName;
                            ws.Cell("C" + row).Value = item.Total;
                            row++;
                        }
                        break;
                }

            }

            workbook.SaveAs(saveFileDialog1.FileName);
        }

        private void sellersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("SS_SearchResult");
            var ws = workbook.Worksheet("SS_SearchResult");

            if (!GroupByChecker.Checked)
            {
                int row = 1;

                List<Sellers> sellers = SearchInfo.SearchWithSellerName(SearchBox.Text, itemBox.Text,
                    startDateTime.Value,
                    EndDateTime.Value, SpreadSheet.SellersSheets, (int) buyerRow.Value);

                foreach (Sellers item in sellers)
                {
                    ws.Cell("A" + row).Value = item.TRADEDT;
                    ws.Cell("B" + row).Value = item.Seller;
                    ws.Cell("C" + row).Value = item.ItemName;
                    ws.Cell("D" + row).Value = item.Total;

                    row++;
                }

                ws.Cell("C" + row).Value = "Total=";
                ws.Cell("D" + row).Value = sellingTotal;
            }
            else
            {
                switch (GroupBox.Text)
                {
                    case @"Item":
                        List<CustomerGroup> Customers = SearchInfo.GroupByItemNameSeller(itemBox.Text,
                            startDateTime.Value,
                            EndDateTime.Value, SpreadSheet.SellersSheets, (int)buyerRow.Value);
                        int row = 1;
                        foreach (CustomerGroup item in Customers)
                        {
                            ws.Cell("A" + row).Value = item.ItemName;
                            ws.Cell("B" + row).Value = item.CustomerName;
                            ws.Cell("C" + row).Value = item.Total;
                            row++;
                        }
                        break;
                    case @"Customer":
                        List<ItemGroup> items = SearchInfo.GroupBySellerName(SearchBox.Text,
                            startDateTime.Value,
                            EndDateTime.Value, SpreadSheet.SellersSheets, (int)buyerRow.Value);
                        row = 1;
                        foreach (ItemGroup item in items)
                        {
                            ws.Cell("A" + row).Value = item.CustomerName;
                            ws.Cell("B" + row).Value = item.ItemName;
                            ws.Cell("C" + row).Value = item.Total;
                            row++;
                        }
                        break;
                }
            }

            workbook.SaveAs(saveFileDialog1.FileName);
        }

  

        

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                LoadLocalData();
            }
        }

        private void MenuClick(object sender, EventArgs e)
        {
            MenuStrip.Show(metroLink1.PointToScreen(metroLink1.Location));
        }

        private void LoadNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            statusTextLabel.Visible = true;
            metroProgressBar1.Visible = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }
    }
}
