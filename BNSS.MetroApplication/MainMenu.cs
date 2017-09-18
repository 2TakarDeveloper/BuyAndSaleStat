using BNSS.MetroApplication.Panel;
using MetroFramework.Forms;
using System;
using BNSS.Entity;
using BNSS.Globals;
using BNSS.Local;

namespace BNSS.MetroApplication
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
            StaticVariables.SpreadSheet = new SpreadSheet();
            LoadData.LoadSettings(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json");
            LoadData.LoadLocalData(AppDomain.CurrentDomain.BaseDirectory + @"\memory.json");
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

        }

        private void ImportOrExport_Click(object sender, EventArgs e)
        {
            ImportExport ImportExport = new ImportExport(this, this.Width, this.Height);
            ImportExport.swipe();
        }
    }
}
