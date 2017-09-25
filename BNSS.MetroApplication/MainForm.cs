using BNSS.MetroApplication.Panel;
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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            setMainMenu();
        }
        private void setMainMenu()
        {
            this.PanelName.Text = "Home";
            //this.PanelHolder.Controls.Clear();
           // Searchpanel sp = new Searchpanel(this,this.Width,this.Height);
           // this.PanelHolder.Controls.Add(sp);
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
            // this.PanelHolder.Controls.Clear();
            // ImportExport IEp = new ImportExport(this, this.Width, this.Height);
            // this.PanelHolder.Controls.Add(IEp);
        }

        private void SettingsLink_Click(object sender, EventArgs e)
        {
            this.PanelName.Text = "Settings";
            // this.PanelHolder.Controls.Clear();
            // Settings sp = new Settings(this, this.Width, this.Height);
            // this.PanelHolder.Controls.Add(sp);
        }

        private void HomeLink_Click(object sender, EventArgs e)
        {
            //setMainMenu();
        }

        private void AboutLink_Click(object sender, EventArgs e)
        {
            this.PanelName.Text = "About";
            //this.PanelHolder.Controls.Clear();
            // About sp = new About(this, this.Width, this.Height);
            // this.PanelHolder.Controls.Add(sp);
        }
    }
}
