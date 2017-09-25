namespace BNSS.MetroApplication
{
    partial class MainForm
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
            this.PanelHolder = new MetroFramework.Controls.MetroPanel();
            this.HeaderPanel = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.footerPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PanelName = new MetroFramework.Controls.MetroLabel();
            this.IELink = new MetroFramework.Controls.MetroLink();
            this.SettingsLink = new MetroFramework.Controls.MetroLink();
            this.HomeLink = new MetroFramework.Controls.MetroLink();
            this.AboutLink = new MetroFramework.Controls.MetroLink();
            this.minimizeBtn = new MetroFramework.Controls.MetroLink();
            this.Maximize = new MetroFramework.Controls.MetroLink();
            this.Close = new MetroFramework.Controls.MetroLink();
            this.HeaderPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHolder
            // 
            this.PanelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHolder.HorizontalScrollbarBarColor = true;
            this.PanelHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelHolder.HorizontalScrollbarSize = 10;
            this.PanelHolder.Location = new System.Drawing.Point(10, 60);
            this.PanelHolder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PanelHolder.Name = "PanelHolder";
            this.PanelHolder.Size = new System.Drawing.Size(868, 510);
            this.PanelHolder.TabIndex = 0;
            this.PanelHolder.VerticalScrollbarBarColor = true;
            this.PanelHolder.VerticalScrollbarHighlightOnWheel = false;
            this.PanelHolder.VerticalScrollbarSize = 10;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HeaderPanel.Controls.Add(this.PanelName);
            this.HeaderPanel.Controls.Add(this.flowLayoutPanel1);
            this.HeaderPanel.Controls.Add(this.minimizeBtn);
            this.HeaderPanel.Controls.Add(this.Maximize);
            this.HeaderPanel.Controls.Add(this.Close);
            this.HeaderPanel.HorizontalScrollbarBarColor = true;
            this.HeaderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HeaderPanel.HorizontalScrollbarSize = 10;
            this.HeaderPanel.Location = new System.Drawing.Point(0, -1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(890, 43);
            this.HeaderPanel.TabIndex = 3;
            this.HeaderPanel.UseCustomBackColor = true;
            this.HeaderPanel.UseCustomForeColor = true;
            this.HeaderPanel.VerticalScrollbarBarColor = true;
            this.HeaderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HeaderPanel.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.IELink);
            this.flowLayoutPanel1.Controls.Add(this.SettingsLink);
            this.flowLayoutPanel1.Controls.Add(this.HomeLink);
            this.flowLayoutPanel1.Controls.Add(this.AboutLink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 40);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.footerPanel.Location = new System.Drawing.Point(-10, 573);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(909, 27);
            this.footerPanel.TabIndex = 4;
            this.footerPanel.UseCustomBackColor = true;
            this.footerPanel.UseCustomForeColor = true;
            this.footerPanel.VerticalScrollbarBarColor = true;
            this.footerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.footerPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(339, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(264, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = " 2TakarDeveloper©2016-2017 All Rights Reserved";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // PanelName
            // 
            this.PanelName.AutoSize = true;
            this.PanelName.BackColor = System.Drawing.Color.Transparent;
            this.PanelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PanelName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PanelName.ForeColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(391, 6);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(118, 25);
            this.PanelName.TabIndex = 7;
            this.PanelName.Text = "metroLabel2";
            this.PanelName.UseCustomBackColor = true;
            this.PanelName.UseCustomForeColor = true;
            this.PanelName.UseMnemonic = false;
            this.PanelName.UseStyleColors = true;
            // 
            // IELink
            // 
            this.IELink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IELink.Image = global::BNSS.MetroApplication.Properties.Resources.Import;
            this.IELink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IELink.ImageSize = 35;
            this.IELink.Location = new System.Drawing.Point(3, 3);
            this.IELink.Name = "IELink";
            this.IELink.Size = new System.Drawing.Size(35, 35);
            this.IELink.TabIndex = 6;
            this.IELink.UseCustomBackColor = true;
            this.IELink.UseSelectable = true;
            this.IELink.Click += new System.EventHandler(this.IELink_Click);
            // 
            // SettingsLink
            // 
            this.SettingsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLink.Image = global::BNSS.MetroApplication.Properties.Resources.Settings_01;
            this.SettingsLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsLink.ImageSize = 35;
            this.SettingsLink.Location = new System.Drawing.Point(44, 3);
            this.SettingsLink.Name = "SettingsLink";
            this.SettingsLink.Size = new System.Drawing.Size(35, 35);
            this.SettingsLink.TabIndex = 7;
            this.SettingsLink.UseCustomBackColor = true;
            this.SettingsLink.UseSelectable = true;
            this.SettingsLink.Click += new System.EventHandler(this.SettingsLink_Click);
            // 
            // HomeLink
            // 
            this.HomeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeLink.Image = global::BNSS.MetroApplication.Properties.Resources.House_07;
            this.HomeLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeLink.ImageSize = 35;
            this.HomeLink.Location = new System.Drawing.Point(85, 3);
            this.HomeLink.Name = "HomeLink";
            this.HomeLink.Size = new System.Drawing.Size(35, 35);
            this.HomeLink.TabIndex = 8;
            this.HomeLink.UseCustomBackColor = true;
            this.HomeLink.UseSelectable = true;
            this.HomeLink.Click += new System.EventHandler(this.HomeLink_Click);
            // 
            // AboutLink
            // 
            this.AboutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutLink.Image = global::BNSS.MetroApplication.Properties.Resources.Circle_Info___01;
            this.AboutLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AboutLink.ImageSize = 35;
            this.AboutLink.Location = new System.Drawing.Point(126, 3);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(35, 35);
            this.AboutLink.TabIndex = 9;
            this.AboutLink.UseCustomBackColor = true;
            this.AboutLink.UseSelectable = true;
            this.AboutLink.Click += new System.EventHandler(this.AboutLink_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Image = global::BNSS.MetroApplication.Properties.Resources.Minus;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeBtn.ImageSize = 35;
            this.minimizeBtn.Location = new System.Drawing.Point(770, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(35, 35);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.UseCustomBackColor = true;
            this.minimizeBtn.UseSelectable = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Image = global::BNSS.MetroApplication.Properties.Resources.Maximize___011;
            this.Maximize.ImageSize = 35;
            this.Maximize.Location = new System.Drawing.Point(811, 3);
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
            this.Close.Location = new System.Drawing.Point(852, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 35);
            this.Close.TabIndex = 2;
            this.Close.UseCustomBackColor = true;
            this.Close.UseSelectable = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 600);
            this.ControlBox = false;
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.PanelHolder);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 30);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelHolder;
        private MetroFramework.Controls.MetroPanel HeaderPanel;
        private MetroFramework.Controls.MetroLink minimizeBtn;
        private MetroFramework.Controls.MetroLink Maximize;
        private MetroFramework.Controls.MetroLink Close;
        private MetroFramework.Controls.MetroPanel footerPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink IELink;
        private MetroFramework.Controls.MetroLink SettingsLink;
        private MetroFramework.Controls.MetroLink HomeLink;
        private MetroFramework.Controls.MetroLink AboutLink;
        private MetroFramework.Controls.MetroLabel PanelName;
    }
}