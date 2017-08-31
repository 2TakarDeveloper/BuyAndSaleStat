using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text.RegularExpressions;
using System.Windows.Forms;

using MetroFramework;

using BNSS.Globals;
using BNSS.Entity;
using BNSS.Entity.ResultSet;
using BNSS.Search;
using BNSS.Parser;
using BNSS.Export;
using BNSS.Local;


namespace TradeInfoSearchApp.Forms
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {


        private double _buyingTotal;
        private double _sellingTotal;

        public DashBoard()
        {
            InitializeComponent();
            StaticVariables.SpreadSheet = new SpreadSheet();

            //UserSettings.LoadSettings();
            //if (UserSettings.Enabled)
            //{
            //    LoadLocalData();
            //}
            //else
            //{
            //    LicenceDialague ld = new LicenceDialague();
            //    if (ld.ShowDialog() == DialogResult.OK)
            //    {

            //        LoadLocalData();
            //    }
            //    else
            //    {
            //        Close();
            //    }
            //}

            LoadLocalData();


        }




        void LoadData()
        {


            foreach (BuyerSheet sheet in StaticVariables.SpreadSheet.BuyerSheets)
            {
                TablesComboBox.Items.Add(sheet);
            }

            foreach (SellerSheet sheet in StaticVariables.SpreadSheet.SellerSheets)
            {
                TablesComboBox.Items.Add(sheet);
            }

            if (TablesComboBox.Items.Count <= 0) return;
            TablesComboBox.SelectedIndex = 0;

            itemBox.DataSource = BuyerSearch.GetUniqueItem(StaticVariables.SpreadSheet.BuyerSheets);

            SearchBox.DataSource = BuyerSearch.GetUniqueCustomer(StaticVariables.SpreadSheet.BuyerSheets);

        }


        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TablesComboBox.SelectedItem.ToString(), "[BB]")) //buyer
            {

                BuyerSheet buyerSheet = (BuyerSheet)TablesComboBox.SelectedItem;
                BuyingGrid.DataSource = buyerSheet.ListOfCustomers;

            }

            if (Regex.IsMatch(TablesComboBox.SelectedItem.ToString(), "[SS]")) //buyer
            {
                SellerSheet sellersSheet = (SellerSheet)TablesComboBox.SelectedItem;
                SellingGrid.DataSource = sellersSheet.SellersList;
            }

        }



        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
                ExcelParser.ExcelReader(openFileDialog.FileName);
            //}
            //catch (Exception exception)
            //{
            //    MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}


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
            BNSS.Local.LoadData.LoadLocalData(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json");

            LoadData();
        }

        private void SaveLocalData()
        {
            SaveData.SaveLocalData(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json");
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

                    switch (GroupBox.Text)
                    {
                        case @"Customer":
                            BuyingGrid.DataSource = BuyerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            SellingGrid.DataSource = SellerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);
                            break;
                        case @"Item":
                            BuyingGrid.DataSource = BuyerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            SellingGrid.DataSource = SellerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);
                            break;
                    }
                }
                else
                {
                    var buyers = BuyerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                    var sellers = SellerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);

                    BuyingGrid.DataSource = buyers;

                    SellingGrid.DataSource = sellers;

                    _buyingTotal = 0;
                    foreach (var buyer in buyers)
                        _buyingTotal += buyer.Total;
                    buyersTotalLable.Text = @"Total:" + _buyingTotal;

                    _sellingTotal = 0;
                    foreach (var seller in sellers)
                        _sellingTotal += seller.Total;
                    SellerrsTotalLable.Text = @"Total:" + _sellingTotal;


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



        private void BuyersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            DataExport dataExport = new DataExport(saveFileDialog1.FileName);


            if (!GroupByChecker.Checked)
            {
                List<Customer> buyers = BuyerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                    EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);
                dataExport.ExportCustomerData(buyers, _sellingTotal);

            }
            else
            {
                switch (GroupBox.Text)
                {
                    case @"Item":
                        List<CustomerGroup> Customers = BuyerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);
                        dataExport.GroupByItemExport(Customers);

                        break;
                    case @"Customer":
                        List<ItemGroup> items = BuyerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);
                        dataExport.GroupByCustomerExport(items);
                        break;
                }

            }


        }

        private void sellersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            DataExport dataExport = new DataExport(saveFileDialog1.FileName);


            if (!GroupByChecker.Checked)
            {
                List<Customer> sellers = SellerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                    EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);
                dataExport.ExportCustomerData(sellers, _sellingTotal);

            }
            else
            {
                switch (GroupBox.Text)
                {
                    case @"Item":
                        List<CustomerGroup> customers = SellerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);
                        dataExport.GroupByItemExport(customers);
                        break;
                    case @"Customer":
                        List<ItemGroup> items = SellerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)buyerRow.Value);
                        dataExport.GroupByCustomerExport(items);
                        break;
                }

            }


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
