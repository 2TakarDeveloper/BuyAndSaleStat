using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Entity.ResultSet;
using BNSS.Export;
using BNSS.Globals;
using BNSS.Search;


namespace BNSS.MetroApplication.Panel
{
    public partial class AdvancedSearch : PanelSlider
    {

        private List<ItemGroup> ItemsB { get; set; }
        private List<CustomerGroup> CustomersGroupB { get; set; }
        private List<ItemGroup> ItemsS { get; set; }
        private List<CustomerGroup> CustomersGroupS { get; set; }


        public AdvancedSearch(MainMenu mainMenu, int width, int height):base(mainMenu)
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
          
            BuyersGrid.DataSource = null;
            SellersGrid.DataSource = null;
            try
            {
                switch (TypePicker.Text)
                {
                    case @"Customer":
                        ItemsB = BuyerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int) buyerRow.Value);

                        ItemsS = SellerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int) sellerRow.Value);

                        BuyersGrid.DataSource = ItemsB;
                        SellersGrid.DataSource = ItemsS;


                        break;
                    case @"Item":
                        CustomersGroupB = BuyerSearch.GroupByItemName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int) buyerRow.Value);

                        CustomersGroupS = SellerSearch.GroupByItemName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int) sellerRow.Value);

                        BuyersGrid.DataSource = CustomersGroupB;
                        SellersGrid.DataSource = CustomersGroupS;
                        break;
                }

                BuyersGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;
                SellersGrid.RowsDefaultCellStyle.ForeColor = UserSettings.RowColor1;

                BuyersGrid.Columns[2].DefaultCellStyle.Format = "N0";
                SellersGrid.Columns[2].DefaultCellStyle.Format = "N0";



                
            }
            catch (Exception exception)
            {
                // MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BuyersExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1=new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);


            
                switch (TypePicker.Text)
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var dataExport = new DataExport(saveFileDialog1.FileName);

                switch (TypePicker.Text)
                {
                    case @"Item":
                        dataExport.GroupByItemExport(CustomersGroupS);
                        break;
                    case @"Customer":
                        dataExport.GroupByCustomerExport(ItemsS);
                        break;
                }
        }


        private void LoadData()
        {
            switch (TypePicker.Text)
            {
                case @"Customer":
                    SearchBox.DataSource = BuyerSearch.GetUniqueCustomer(StaticVariables.SpreadSheet.BuyerSheets);
          


                    break;
                case @"Item":

                    SearchBox.DataSource = BuyerSearch.GetUniqueItem(StaticVariables.SpreadSheet.BuyerSheets);
                    break;
            }
        }

        private void TypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
