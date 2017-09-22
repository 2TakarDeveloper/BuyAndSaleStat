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
        Settings setting;
        Searchpanel SearchPanel;
        AdvancedSearch AdvancedSearch;
        ImportExport importExport;
        CompanySummaryPanel summeryPanel;
        About about;

        public MainMenu()
        {
            InitializeComponent();
            StaticVariables.SpreadSheet = new SpreadSheet();

            SearchPanel = new Searchpanel(this, this.Width, this.Height);

            LoadData.LoadSettings();
            LoadData.LoadLocalData();
        }



        private void Settings_Click(object sender, EventArgs e)
        {

            setting = new Settings(this, this.Width, this.Height);
            setting.swipe();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchPanel = new Searchpanel(this, this.Width, this.Height);
        
            SearchPanel.swipe();
        }

        private void AdvanceSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch = new AdvancedSearch(this, this.Width, this.Height);
            AdvancedSearch.swipe();
        }

        private void About_Click(object sender, EventArgs e)
        {
              about = new About(this, this.Width, this.Height);
              about.swipe();
        }

        private void ImportOrExport_Click(object sender, EventArgs e)
        {
            importExport = new ImportExport(this, this.Width, this.Height);
            importExport.swipe();
        }

        private void Nameless_Click(object sender, EventArgs e)
        {
            summeryPanel = new CompanySummaryPanel(this, this.Width, this.Height);
            summeryPanel.swipe();
            
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
