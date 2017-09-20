using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BNSS.Entity;
using BNSS.Globals;
using BNSS.Local;
using MetroFramework;

namespace BNSS.Application.Forms
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        private List<BuyerSheet> SelectedBuyerSheet { get; set; }
        private List<SellerSheet> SelectedSellerSheet { get; set; }


        public Settings()
        {
            InitializeComponent();
            TableColorShower1.BackColor = UserSettings.RowColor1;
            TableColorShower2.BackColor = UserSettings.RowColor2;
            ShowDatabase();
        }

        private void ColorStrip1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                UserSettings.RowColor1 = colorDialog1.Color;
                TableColorShower1.BackColor = UserSettings.RowColor1;
            }
        }

        private void TableColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                UserSettings.RowColor2 = colorDialog1.Color;
                TableColorShower2.BackColor = UserSettings.RowColor2;
            }
        }

     
      

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveData.SaveSettings();
            DialogResult = DialogResult.OK;
            base.OnFormClosing(e);
        }

        private void ClearMemoryButton_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "This will remove all local data", "Are you sure?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
            var pathS = AppDomain.CurrentDomain.BaseDirectory + @"\memory.json";
            if (File.Exists(pathS))
                File.Delete(pathS);

          
        }

        private void ExportMemoryButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json", saveFileDialog1.FileName, true);

            }
        }

        private void ImportMemoryButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + @"\memory.json", true);
            }
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

        private void DeleteBuyerSheetButton_Click(object sender, EventArgs e)
        {
            if (SelectedBuyerSheet == null)
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
            if (SelectedSellerSheet == null)
            {
                MetroMessageBox.Show(this, "Please Select a row", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (MetroMessageBox.Show(this, "This will Remove the data permanently.Are you sure?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
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



    }
}
