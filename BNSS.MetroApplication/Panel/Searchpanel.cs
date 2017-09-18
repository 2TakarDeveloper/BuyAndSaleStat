using System;
using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Export;
using BNSS.Globals;
using BNSS.Search;


namespace BNSS.MetroApplication.Panel
{
    public partial class Searchpanel : PanelSlider
    {
        private double _buyingTotal;
        private double _sellingTotal;

        private List<Customer> Buyers { get; set; }
        private List<Customer> Sellers { get; set; }


        public Searchpanel(Form Owner, int width, int height) :base(Owner)
        {
            InitializeComponent();
            Width = width;
            Height = height;
            LoadData();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }

        private void Search_initate(object sender, EventArgs e)
        {
            
            BuyerGrid.DataSource = null;
            Sellergrid.DataSource = null;
            try
            {
                
               
               Buyers = BuyerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

               Sellers = SellerSearch.SearchCustomers(SearchBox.Text, itemBox.Text, startDateTime.Value,
                        EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)sellerRow.Value);

                BuyerGrid.DataSource = Buyers;
                Sellergrid.DataSource = Sellers;

                    _buyingTotal = Buyers.Sum(x => x.Total);
                    _sellingTotal = Sellers.Sum(x => x.Total);

                    BuyerTotalLable.Text = @"Total:" + _buyingTotal;
                    SellertotalLable.Text = @"Total:" + _sellingTotal;


                    

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


               
            }
            catch (Exception exception)
            {
                // MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BuyersExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1= new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);
            dataExport.ExportCustomerData(Buyers, _sellingTotal);
          
        }

        private void sellersExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1= new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);
            dataExport.ExportCustomerData(Sellers, _sellingTotal);
        
        }


        void LoadData()
        {

            itemBox.DataSource = BuyerSearch.GetUniqueItem(StaticVariables.SpreadSheet.BuyerSheets);
            SearchBox.DataSource = BuyerSearch.GetUniqueCustomer(StaticVariables.SpreadSheet.BuyerSheets);

        }


    }
}
