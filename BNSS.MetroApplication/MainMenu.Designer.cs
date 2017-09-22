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
            this.Nameless = new MetroFramework.Controls.MetroTile();
            this.ImportOrExport = new MetroFramework.Controls.MetroTile();
            this.footerPanel = new MetroFramework.Controls.MetroPanel();
            this.HeaderPanel = new MetroFramework.Controls.MetroPanel();
            this.minimizeBtn = new MetroFramework.Controls.MetroLink();
            this.HeaderText = new MetroFramework.Controls.MetroLabel();
            this.Maximize = new MetroFramework.Controls.MetroLink();
            this.Close = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.Search);
            this.flowLayoutPanel1.Controls.Add(this.AdvanceSearch);
            this.flowLayoutPanel1.Controls.Add(this.Settings);
            this.flowLayoutPanel1.Controls.Add(this.About);
            this.flowLayoutPanel1.Controls.Add(this.Nameless);
            this.flowLayoutPanel1.Controls.Add(this.ImportOrExport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(179, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 257);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.ActiveControl = null;
            this.Search.BackColor = System.Drawing.Color.Orange;
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(3, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 125);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.TileImage = global::BNSS.MetroApplication.Properties.Resources.Search_01;
            this.Search.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Search.UseCustomBackColor = true;
            this.Search.UseCustomForeColor = true;
            this.Search.UseSelectable = true;
            this.Search.UseStyleColors = true;
            this.Search.UseTileImage = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AdvanceSearch
            // 
            this.AdvanceSearch.ActiveControl = null;
            this.AdvanceSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.AdvanceSearch.Location = new System.Drawing.Point(189, 3);
            this.AdvanceSearch.Name = "AdvanceSearch";
            this.AdvanceSearch.Size = new System.Drawing.Size(180, 125);
            this.AdvanceSearch.TabIndex = 3;
            this.AdvanceSearch.Text = "Advance Search";
            this.AdvanceSearch.TileImage = global::BNSS.MetroApplication.Properties.Resources.Data_Find;
            this.AdvanceSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdvanceSearch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AdvanceSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AdvanceSearch.UseCustomBackColor = true;
            this.AdvanceSearch.UseSelectable = true;
            this.AdvanceSearch.UseTileImage = true;
            this.AdvanceSearch.Click += new System.EventHandler(this.AdvanceSearch_Click);
            // 
            // Settings
            // 
            this.Settings.ActiveControl = null;
            this.Settings.BackColor = System.Drawing.Color.MediumPurple;
            this.Settings.Location = new System.Drawing.Point(375, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(180, 125);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.TileImage = global::BNSS.MetroApplication.Properties.Resources.Settings_01;
            this.Settings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Settings.UseCustomBackColor = true;
            this.Settings.UseSelectable = true;
            this.Settings.UseTileImage = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // About
            // 
            this.About.ActiveControl = null;
            this.About.BackColor = System.Drawing.Color.Crimson;
            this.About.Location = new System.Drawing.Point(3, 134);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(180, 125);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.TileImage = global::BNSS.MetroApplication.Properties.Resources.Dialog_Box_About;
            this.About.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.About.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.About.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.About.UseCustomBackColor = true;
            this.About.UseSelectable = true;
            this.About.UseTileImage = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Nameless
            // 
            this.Nameless.ActiveControl = null;
            this.Nameless.BackColor = System.Drawing.Color.DarkViolet;
            this.Nameless.Location = new System.Drawing.Point(189, 134);
            this.Nameless.Name = "Nameless";
            this.Nameless.Size = new System.Drawing.Size(180, 125);
            this.Nameless.TabIndex = 7;
            this.Nameless.Text = "Company Summary";
            this.Nameless.TileImage = global::BNSS.MetroApplication.Properties.Resources.Paper;
            this.Nameless.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nameless.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Nameless.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Nameless.UseCustomBackColor = true;
            this.Nameless.UseSelectable = true;
            this.Nameless.UseTileImage = true;
            this.Nameless.Click += new System.EventHandler(this.Nameless_Click);
            // 
            // ImportOrExport
            // 
            this.ImportOrExport.ActiveControl = null;
            this.ImportOrExport.Location = new System.Drawing.Point(375, 134);
            this.ImportOrExport.Name = "ImportOrExport";
            this.ImportOrExport.Size = new System.Drawing.Size(180, 125);
            this.ImportOrExport.TabIndex = 6;
            this.ImportOrExport.Text = "Import/Export";
            this.ImportOrExport.TileImage = global::BNSS.MetroApplication.Properties.Resources.Import;
            this.ImportOrExport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImportOrExport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ImportOrExport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ImportOrExport.UseSelectable = true;
            this.ImportOrExport.UseTileImage = true;
            this.ImportOrExport.Click += new System.EventHandler(this.ImportOrExport_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.footerPanel.Controls.Add(this.metroLabel1);
            this.footerPanel.HorizontalScrollbarBarColor = true;
            this.footerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.footerPanel.HorizontalScrollbarSize = 10;
            this.footerPanel.Location = new System.Drawing.Point(-1, 571);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(903, 29);
            this.footerPanel.TabIndex = 1;
            this.footerPanel.UseCustomBackColor = true;
            this.footerPanel.UseCustomForeColor = true;
            this.footerPanel.VerticalScrollbarBarColor = true;
            this.footerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.footerPanel.VerticalScrollbarSize = 10;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HeaderPanel.Controls.Add(this.minimizeBtn);
            this.HeaderPanel.Controls.Add(this.HeaderText);
            this.HeaderPanel.Controls.Add(this.Maximize);
            this.HeaderPanel.Controls.Add(this.Close);
            this.HeaderPanel.HorizontalScrollbarBarColor = true;
            this.HeaderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HeaderPanel.HorizontalScrollbarSize = 10;
            this.HeaderPanel.Location = new System.Drawing.Point(-1, -2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(903, 50);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.UseCustomBackColor = true;
            this.HeaderPanel.UseCustomForeColor = true;
            this.HeaderPanel.VerticalScrollbarBarColor = true;
            this.HeaderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HeaderPanel.VerticalScrollbarSize = 10;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Image = global::BNSS.MetroApplication.Properties.Resources.Minus;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeBtn.ImageSize = 35;
            this.minimizeBtn.Location = new System.Drawing.Point(783, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(35, 35);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.UseCustomBackColor = true;
            this.minimizeBtn.UseSelectable = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // HeaderText
            // 
            this.HeaderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderText.AutoSize = true;
            this.HeaderText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HeaderText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.HeaderText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderText.Location = new System.Drawing.Point(399, 13);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(104, 25);
            this.HeaderText.TabIndex = 4;
            this.HeaderText.Text = "Dashboard";
            this.HeaderText.UseCustomBackColor = true;
            this.HeaderText.UseCustomForeColor = true;
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Image = global::BNSS.MetroApplication.Properties.Resources.Maximize___011;
            this.Maximize.ImageSize = 35;
            this.Maximize.Location = new System.Drawing.Point(824, 3);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(35, 35);
            this.Maximize.TabIndex = 3;
            this.Maximize.UseCustomBackColor = true;
            this.Maximize.UseSelectable = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Image = global::BNSS.MetroApplication.Properties.Resources.Circle_Close___01;
            this.Close.ImageSize = 35;
            this.Close.Location = new System.Drawing.Point(865, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 35);
            this.Close.TabIndex = 2;
            this.Close.UseCustomBackColor = true;
            this.Close.UseSelectable = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(372, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = " ©2016-2017 All Rights Reserved";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile Search;
        private MetroFramework.Controls.MetroTile AdvanceSearch;
        private MetroFramework.Controls.MetroTile Settings;
        private MetroFramework.Controls.MetroTile About;
        private MetroFramework.Controls.MetroTile ImportOrExport;
        private MetroFramework.Controls.MetroTile Nameless;
        private MetroFramework.Controls.MetroPanel footerPanel;
        private MetroFramework.Controls.MetroPanel HeaderPanel;
        private MetroFramework.Controls.MetroLink Maximize;
        private new MetroFramework.Controls.MetroLink Close;
        private MetroFramework.Controls.MetroLabel HeaderText;
        private MetroFramework.Controls.MetroLink minimizeBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}