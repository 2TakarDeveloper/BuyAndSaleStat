using BNSS.MetroApplication.Panel;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNSS.MetroApplication
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }



        private void Settings_Click(object sender, EventArgs e)
        {
            Settings Setting = new Settings(this, this.Width, this.Height);
            Setting.swipe();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Searchpanel Search = new Searchpanel(this, this.Width, this.Height);
            Search.swipe();
        }

        private void AdvanceSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch AdvancedSearch = new AdvancedSearch(this, this.Width, this.Height);
            AdvancedSearch.swipe();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void ImportOrExport_Click(object sender, EventArgs e)
        {
            ImportExport ImportExport = new ImportExport(this, this.Width, this.Height);
            ImportExport.swipe();
        }
    }
}
