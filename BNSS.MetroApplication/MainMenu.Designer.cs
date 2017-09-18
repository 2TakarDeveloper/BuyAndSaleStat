namespace BNSS.MetroApplication
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Search = new MetroFramework.Controls.MetroTile();
            this.AdvanceSearch = new MetroFramework.Controls.MetroTile();
            this.Settings = new MetroFramework.Controls.MetroTile();
            this.About = new MetroFramework.Controls.MetroTile();
            this.ImportOrExport = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.Search);
            this.flowLayoutPanel1.Controls.Add(this.AdvanceSearch);
            this.flowLayoutPanel1.Controls.Add(this.Settings);
            this.flowLayoutPanel1.Controls.Add(this.About);
            this.flowLayoutPanel1.Controls.Add(this.ImportOrExport);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 257);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.ActiveControl = null;
            this.Search.Location = new System.Drawing.Point(3, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(179, 122);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseSelectable = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AdvanceSearch
            // 
            this.AdvanceSearch.ActiveControl = null;
            this.AdvanceSearch.Location = new System.Drawing.Point(188, 3);
            this.AdvanceSearch.Name = "AdvanceSearch";
            this.AdvanceSearch.Size = new System.Drawing.Size(152, 122);
            this.AdvanceSearch.TabIndex = 3;
            this.AdvanceSearch.Text = "Advance Search";
            this.AdvanceSearch.UseSelectable = true;
            this.AdvanceSearch.Click += new System.EventHandler(this.AdvanceSearch_Click);
            // 
            // Settings
            // 
            this.Settings.ActiveControl = null;
            this.Settings.Location = new System.Drawing.Point(346, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(194, 122);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseSelectable = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // About
            // 
            this.About.ActiveControl = null;
            this.About.Location = new System.Drawing.Point(3, 131);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(179, 122);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseSelectable = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // ImportOrExport
            // 
            this.ImportOrExport.ActiveControl = null;
            this.ImportOrExport.Location = new System.Drawing.Point(188, 131);
            this.ImportOrExport.Name = "ImportOrExport";
            this.ImportOrExport.Size = new System.Drawing.Size(152, 122);
            this.ImportOrExport.TabIndex = 6;
            this.ImportOrExport.Text = "import/export";
            this.ImportOrExport.UseSelectable = true;
            this.ImportOrExport.Click += new System.EventHandler(this.ImportOrExport_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(346, 131);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(194, 122);
            this.metroTile6.TabIndex = 7;
            this.metroTile6.Text = "NameLess";
            this.metroTile6.UseSelectable = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile Search;
        private MetroFramework.Controls.MetroTile AdvanceSearch;
        private MetroFramework.Controls.MetroTile Settings;
        private MetroFramework.Controls.MetroTile About;
        private MetroFramework.Controls.MetroTile ImportOrExport;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}