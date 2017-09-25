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

namespace BNSS.MetroApplication.Panel
{
    public partial class Settings : MetroFramework.Controls.MetroUserControl
    {
      

        public Settings() 
        {
            InitializeComponent();
            RowColor1.BackColor = UserSettings.RowColor1;
            RowColor2.BackColor = UserSettings.RowColor2;
        }

      

        private void RowColor1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                UserSettings.RowColor1 = colorDialog1.Color;
                RowColor1.BackColor = UserSettings.RowColor1;
                SaveData.SaveSettings();
            }
        }

        private void RowColor2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                UserSettings.RowColor2 = colorDialog1.Color;
                RowColor2.BackColor = UserSettings.RowColor2;
                SaveData.SaveSettings();
            }
        }
    }
}
