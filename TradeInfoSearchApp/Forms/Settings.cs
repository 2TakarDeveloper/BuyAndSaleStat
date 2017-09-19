using System;
using System.IO;
using System.Windows.Forms;
using BNSS.Globals;
using BNSS.Local;
using MetroFramework;

namespace BNSS.Application.Forms
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
            TableColorShower1.BackColor = UserSettings.RowColor1;
            TableColorShower2.BackColor = UserSettings.RowColor2;
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
    }
}
