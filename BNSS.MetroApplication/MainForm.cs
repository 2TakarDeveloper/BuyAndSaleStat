using BNSS.MetroApplication.Panel;
using System;

using System.Windows.Forms;
using BNSS.Local;

namespace BNSS.MetroApplication
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData.LoadLocalData();
            LoadData.LoadSettings();
            setMainMenu();


        }
        private void setMainMenu()
        {
            PanelName.Text = "Search";
            PanelHolder.Controls.Clear();
            Searchpanel sp = new Searchpanel(){Dock = DockStyle.Fill};
            PanelHolder.Controls.Add(sp);
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

        private void IELink_Click(object sender, EventArgs e)
        {
            this.PanelName.Text = "Import/Export";
            this.PanelHolder.Controls.Clear();
            ImportExport IEp = new ImportExport(){Dock = DockStyle.Fill};
            this.PanelHolder.Controls.Add(IEp);
        }

        private void SettingsLink_Click(object sender, EventArgs e)
        {
            this.PanelName.Text = "Settings";
            this.PanelHolder.Controls.Clear();
            Settings sp = new Settings() { Dock = DockStyle.Fill };
            this.PanelHolder.Controls.Add(sp);
        }

        private void HomeLink_Click(object sender, EventArgs e)
        {
            setMainMenu();
        }

        private void AboutLink_Click(object sender, EventArgs e)
        {
            this.PanelName.Text = "About";
            this.PanelHolder.Controls.Clear();
            About sp = new About() { Dock = DockStyle.Fill };
            this.PanelHolder.Controls.Add(sp);
        }
    }
}
