using System;
using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Entity.ResultSet;
using BNSS.Export;
using BNSS.Globals;
using BNSS.Search;


namespace BNSS.MetroApplication.Panel
{
    public partial class Searchpanel : PanelSlider
    {
        private double _buyingTotal;
        private double _sellingTotal;

        //SearchResults
        private List<ItemGroup> ItemsB { get; set; }
        private List<CustomerGroup> CustomersGroupB { get; set; }
        private List<ItemGroup> ItemsS { get; set; }
        private List<CustomerGroup> CustomersGroupS { get; set; }
        private List<Customer> Buyers { get; set; }
        private List<Customer> Sellers { get; set; }


        public Searchpanel() :base()
        {
            InitializeComponent();
            EndDateTime.Value=DateTime.Now;
          
            LoadData();
        }



        private void Search_initate(object sender, EventArgs e)
        {
            var groupBy = GroupByChecker.Checked;
            var summary = SummaryCheck.Checked;
            BuyerGrid.DataSource = null;
            Sellergrid.DataSource = null;
            try
            {
                if (groupBy)
                {

                    switch (GroupBox.Text)
                    {
                        case @"Customer":
                            ItemsB = BuyerSearch.GroupByCustomerName(SearchBox.Text, StartDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            ItemsS = SellerSearch.GroupByCustomerName(SearchBox.Text, StartDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);


                            if (!summary)
                            {
                                BuyerGrid.DataSource = ItemsB;
                                Sellergrid.DataSource = ItemsS;
                            }
                            else
                            {
                                BuyerGrid.DataSource = CompanySummary.CustomerSummary(ItemsB, ItemsS);
                            }






                            break;
                        case @"Item":
                            CustomersGroupB = BuyerSearch.GroupByItemName(itemBox.Text, StartDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                            CustomersGroupS = SellerSearch.GroupByItemName(itemBox.Text, StartDateTime.Value,
                                EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);


                            if (!summary)
                            {
                                BuyerGrid.DataSource = CustomersGroupB;
                                Sellergrid.DataSource = CustomersGroupS;
                            }
                            else
                            {
                                BuyerGrid.DataSource = CompanySummary.ItemSummary(CustomersGroupB, CustomersGroupS);
                            }

                            break;





                    }

                    BuyerGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;
                    Sellergrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;

                    BuyerGrid.Columns[2].DefaultCellStyle.Format = "N0";
                    Sellergrid.Columns[2].DefaultCellStyle.Format = "N0";



                }
                else
                {
                    Buyers = BuyerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, StartDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                    Sellers = SellerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, StartDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);

                    BuyerGrid.DataSource = Buyers;
                    Sellergrid.DataSource = Sellers;

                    _buyingTotal = Buyers.Sum(x => x.Total);
                    _sellingTotal = Sellers.Sum(x => x.Total);

                    BuyerTotalLable.Text = @"Total:" + _buyingTotal;
                    SellertotalLable.Text = @"Total:" + _sellingTotal;


                    #region DataCell Style

                    #region ColorSwitch

                    var colorSwitch = true;

                    var customer = (Customer)BuyerGrid.Rows[0].DataBoundItem;

                    BuyerGrid.Columns[0].DefaultCellStyle.Format = "M";
                    BuyerGrid.Columns[3].DefaultCellStyle.Format = "N0";

                    foreach (DataGridViewRow row in BuyerGrid.Rows)
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
                    customer = (Customer)Sellergrid.Rows[0].DataBoundItem;

                    Sellergrid.Columns[0].DefaultCellStyle.Format = "M";
                    Sellergrid.Columns[3].DefaultCellStyle.Format = "N0";


                    foreach (DataGridViewRow row in Sellergrid.Rows)
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


        void LoadData()
        {

            itemBox.DataSource = BuyerSearch.GetUniqueItem(StaticVariables.SpreadSheet.BuyerSheets);
            SearchBox.DataSource = BuyerSearch.GetUniqueCustomer(StaticVariables.SpreadSheet.BuyerSheets);

        }

        private void GroupByChecker_CheckedChanged(object sender, EventArgs e)
        {
            SummaryCheck.Visible = !SummaryCheck.Visible;
            GroupBox.Visible = !GroupBox.Visible;
            if (!GroupByChecker.Checked)
            {
                SearchBox.Visible = true;
                itemBox.Visible = true;
            }
        }

        private void GroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (GroupBox.Text)
            {
                case @"Customer":
                    SearchBox.Visible = false;
                    itemBox.Visible = true;
                    break;
                case @"Item":
                    SearchBox.Visible = true;
                    itemBox.Visible = false;
                    break;

            }
        }
    }
}
