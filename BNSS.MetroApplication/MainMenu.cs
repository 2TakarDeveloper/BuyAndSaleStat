using BNSS.MetroApplication.Panel;
using MetroFramework.Forms;
using System;
using BNSS.Entity;
using BNSS.Globals;
using BNSS.Local;
using System.Windows.Forms;

namespace BNSS.MetroApplication
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
            StaticVariables.SpreadSheet = new SpreadSheet();
            
            LoadData.LoadSettings();
            LoadData.LoadLocalData();
        }



        private void Settings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(this, this.Width, this.Height);
            setting.swipe();

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
            About About = new About(this, this.Width, this.Height);
            About.swipe();
        }

        private void ImportOrExport_Click(object sender, EventArgs e)
        {
            ImportExport ImportExport = new ImportExport(this, this.Width, this.Height);
            ImportExport.swipe();
        }

        private void Nameless_Click(object sender, EventArgs e)
        {
            CompanySummary Nameless = new CompanySummary(this, this.Width, this.Height);
            Nameless.swipe();
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }
    }
}
