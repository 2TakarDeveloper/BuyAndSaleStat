using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Export;
using BNSS.Globals;
using BNSS.Local;
using BNSS.Parser;
using MetroFramework;

namespace BNSS.MetroApplication.Panel
{
    public partial class ImportExport : PanelSlider
    {
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private List<BuyerSheet> SelectedBuyerSheet { get; set; }
        private List<SellerSheet> SelectedSellerSheet { get; set; }



        public ImportExport(Form mainMenu, int width, int height):base(mainMenu)
        {
            InitializeComponent();
            Width = width;
            Height = height;
       
            ShowDatabase();
            
        }


        private void ImportFromExcelButton_Click(object sender, EventArgs e)
        {
           
            
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ExcelParser.ExcelReader(openFileDialog.FileName);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MetroMessageBox.Show(this, "Import Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveData.SaveLocalData();
            ShowDatabase();
        }

        private void ShowDatabase()
        {
            try
            {
                BuyerGrid.DataSource = null;
                BuyerGrid.DataSource = StaticVariables.SpreadSheet.BuyerSheets;

                SellerGrid.DataSource = null;
                SellerGrid.DataSource = StaticVariables.SpreadSheet.SellerSheets;

            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void importFromJsonButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Memory.ImportFromJson(saveFileDialog.FileName);
            }
        }

        private void ExportAsJsonButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Memory.ExportAsJson(saveFileDialog.FileName);
            }
        }

        private void DeleteBuyerSheetButton_Click(object sender, EventArgs e)
        {
            if (SelectedBuyerSheet==null)
            {
                MetroMessageBox.Show(this, "Please Select a row", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroMessageBox.Show(this, "This will Remove the data permanently.Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                ModifyData.RemoveBuyerSheetList(SelectedBuyerSheet);
                ShowDatabase();
                SaveData.SaveLocalData();
            }
           
        }

        private void DeleteSellerSheetButton_Click(object sender, EventArgs e)
        {
            if (SelectedSellerSheet== null)
            {
                MetroMessageBox.Show(this, "Please Select a row", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            if (MetroMessageBox.Show(this, "This will Remove the data permanently.Are you sure?","Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                ModifyData.RemoveSellerSheetList(SelectedSellerSheet);
                ShowDatabase();
                SaveData.SaveLocalData();
            }

          
        }

        private void BuyerGrid_SelectionChanged(object sender, EventArgs e)
        {
            var length = BuyerGrid.SelectedRows.Count;
            SelectedBuyerSheet = new List<BuyerSheet>();
            for (var i = 0; i < length; i++)
            {
                try
                {
                    SelectedBuyerSheet.Add((BuyerSheet)BuyerGrid.SelectedRows[i].DataBoundItem);
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, exception.Message, "Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SellerGrid_SelectionChanged(object sender, EventArgs e)
        {
            var length = SellerGrid.SelectedRows.Count;
            SelectedSellerSheet = new List<SellerSheet>();
            for (var i = 0; i < length; i++)
            {
                try
                {
                    SelectedSellerSheet.Add((SellerSheet)SellerGrid.SelectedRows[i].DataBoundItem);
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, exception.Message, "Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            swipe(false);
            Dispose();
        }
    }
}
