using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public ImportExport(MainMenu mainMenu, int width, int height):base(mainMenu)
        {
            InitializeComponent();
            Width = width;
            Height = height;
            ShowDatabase();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.swipe(false);
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
            SaveData.SaveLocalData(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json");
        }

        private void ShowDatabase()
        {
            BuyerGrid.DataSource = StaticVariables.SpreadSheet.BuyerSheets;
            SellerGrid.DataSource = StaticVariables.SpreadSheet.SellerSheets;
        }

    }
}
