using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Entity.ResultSet;
using BNSS.Export;
using BNSS.Globals;
using BNSS.Local;
using BNSS.Parser;
using BNSS.Search;


namespace BNSS.Application.Forms
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {

        
        private double _buyingTotal;
        private double _sellingTotal;

        #region SearchData

        //SearchResults
        private List<ItemGroup> ItemsB { get; set; }
        private List<CustomerGroup> CustomersGroupB { get; set; }
        private List<ItemGroup> ItemsS { get; set; }
        private List<CustomerGroup> CustomersGroupS { get; set; }
        private List<Customer> Buyers { get; set; }
        private List<Customer> Sellers { get; set; }

        #endregion


        public DashBoard()
        {
            InitializeComponent();



            StaticVariables.SpreadSheet = new SpreadSheet();

            Local.LoadData.LoadSettings();
            CheckLicence();

            //LoadLocalData();


        }


        void CheckLicence()
        {

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




            TablesComboBox.Items.Clear();
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

                BuyingGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;
                BuyingGrid.Columns[0].DefaultCellStyle.Format = "M";
                BuyingGrid.Columns[3].DefaultCellStyle.Format = "N2";

            }

            if (Regex.IsMatch(TablesComboBox.SelectedItem.ToString(), "[SS]")) //buyer
            {
                SellerSheet sellersSheet = (SellerSheet)TablesComboBox.SelectedItem;
                SellingGrid.DataSource = sellersSheet.SellersList;
                SellingGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;
                SellingGrid.Columns[0].DefaultCellStyle.Format = "M";
                SellingGrid.Columns[3].DefaultCellStyle.Format = "N2";

            }









        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ExcelParser.ExcelReader(openFileDialog.FileName);
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
            Local.LoadData.LoadLocalData();

            LoadData();
        }

        private void SaveLocalData()
        {
            SaveData.SaveLocalData();
        }



        private void Search_initate(object sender, EventArgs e)
        {
            var groupBy = GroupByChecker.Checked;
            var summary = SummaryCheck.Checked;
            BuyingGrid.DataSource = null;
            SellingGrid.DataSource = null;
            try
            {
                if (groupBy)
                {

                    switch (GroupBox.Text)
                    {
                        case @"Customer":
                            ItemsB = BuyerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            ItemsS = SellerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);


                            if (!summary)
                            {
                                BuyingGrid.DataSource = ItemsB;
                                SellingGrid.DataSource = ItemsS;
                            }
                            else
                            {
                                BuyingGrid.DataSource= CompanySummary.CustomerSummary(ItemsB, ItemsS);
                            }

                            




                            break;
                        case @"Item":
                            CustomersGroupB = BuyerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            CustomersGroupS = SellerSearch.GroupByItemName(itemBox.Text, startDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);


                            if (!summary)
                            {
                                BuyingGrid.DataSource = CustomersGroupB;
                                SellingGrid.DataSource = CustomersGroupS;
                            }
                            else
                            {
                                BuyingGrid.DataSource = CompanySummary.ItemSummary(CustomersGroupB, CustomersGroupS);
                            }

                            break;





                    }

                    BuyingGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;
                    SellingGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;

                    BuyingGrid.Columns[2].DefaultCellStyle.Format = "N0";
                    SellingGrid.Columns[2].DefaultCellStyle.Format = "N0";



                }
                else
                {
                    Buyers = BuyerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                    Sellers = SellerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);

                    BuyingGrid.DataSource = Buyers;
                    SellingGrid.DataSource = Sellers;

                    _buyingTotal = Buyers.Sum(x => x.Total);
                    _sellingTotal = Sellers.Sum(x => x.Total);

                    buyersTotalLable.Text = @"Total:" + _buyingTotal;
                    SellerrsTotalLable.Text = @"Total:" + _sellingTotal;


                    #region DataCell Style

                    #region ColorSwitch

                    var colorSwitch = true;

                    var customer = (Customer)BuyingGrid.Rows[0].DataBoundItem;

                    BuyingGrid.Columns[0].DefaultCellStyle.Format = "M";
                    BuyingGrid.Columns[3].DefaultCellStyle.Format = "N0";

                    foreach (DataGridViewRow row in BuyingGrid.Rows)
                    {
                        var customer2 = (Customer)row.DataBoundItem;

                        if (customer.TRADEDT != customer2.TRADEDT)
                        {
                            colorSwitch = !colorSwitch;
                            customer = customer2;
                        }

                        row.DefaultCellStyle.ForeColor =
                            colorSwitch ? UserSettings.RowColor1 : UserSettings.RowColor2;
                    }


                    colorSwitch = true;
                    customer = (Customer)SellingGrid.Rows[0].DataBoundItem;

                    SellingGrid.Columns[0].DefaultCellStyle.Format = "M";
                    SellingGrid.Columns[3].DefaultCellStyle.Format = "N0";


                    foreach (DataGridViewRow row in SellingGrid.Rows)
                    {
                        var customer2 = (Customer)row.DataBoundItem;

                        if (customer.TRADEDT != customer2.TRADEDT)
                        {
                            colorSwitch = !colorSwitch;
                            customer = customer2;
                        }

                        row.DefaultCellStyle.ForeColor =
                            colorSwitch ? UserSettings.RowColor1 : UserSettings.RowColor2;
                    }


                    #endregion






                    #endregion

                }
            }
            catch (Exception exception)
            {
                // MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void BuyersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);


            if (!GroupByChecker.Checked)
                dataExport.ExportCustomerData(Buyers, _sellingTotal);
            else
                switch (GroupBox.Text)
                {
                    case @"Item":

                        dataExport.GroupByItemExport(CustomersGroupB);

                        break;
                    case @"Customer":

                        dataExport.GroupByCustomerExport(ItemsB);
                        break;
                }
        }

        private void sellersExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);


            if (!GroupByChecker.Checked)
                dataExport.ExportCustomerData(Sellers, _sellingTotal);
            else
                switch (GroupBox.Text)
                {
                    case @"Item":
                        dataExport.GroupByItemExport(CustomersGroupS);
                        break;
                    case @"Customer":
                        dataExport.GroupByCustomerExport(ItemsS);
                        break;
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
            metroContextMenu1.Show(metroLink1.PointToScreen(metroLink1.Location));
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
            System.Windows.Forms.Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }
    }
}
