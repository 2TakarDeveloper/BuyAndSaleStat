using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNSS.Entity.ResultSet;
using BNSS.Globals;
using BNSS.Search;

namespace BNSS.MetroApplication.Panel
{
    public partial class CompanySummaryPanel : PanelSlider
    {

        private List<ItemGroup> ItemsB { get; set; }
        private List<CustomerGroup> CustomersGroupB { get; set; }
        private List<ItemGroup> ItemsS { get; set; }
        private List<CustomerGroup> CustomersGroupS { get; set; }

        public CompanySummaryPanel(MainMenu mainMenu, int width, int height):base(mainMenu)
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
            
            try
            {
                switch (TypePicker.Text)
                {
                    case @"Customer":
                        ItemsB = BuyerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                        ItemsS = SellerSearch.GroupByCustomerName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)buyerRow.Value);

                        BuyersGrid.DataSource = CompanySummary.CustomerSummary(ItemsB, ItemsS);
                        


                        break;
                    case @"Item":
                        CustomersGroupB = BuyerSearch.GroupByItemName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.BuyerSheets, (int)buyerRow.Value);

                        CustomersGroupS = SellerSearch.GroupByItemName(SearchBox.Text, startDateTime.Value,
                            EndDateTime.Value, StaticVariables.SpreadSheet.SellerSheets, (int)buyerRow.Value);

                        BuyersGrid.DataSource = CompanySummary.ItemSummary(CustomersGroupB, CustomersGroupS);
                        break;
                }



                BuyersGrid.Columns[2].DefaultCellStyle.Format = "N0";
           




            }
            catch (Exception exception)
            {
                // MetroMessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
