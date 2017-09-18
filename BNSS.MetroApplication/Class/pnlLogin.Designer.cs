namespace ModernUIProject.Class
{
    partial class pnlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlLogin));
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txUsername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.Controls.Add(this.btnLogIn);
            this.pnlCenter.Controls.Add(this.txtPassword);
            this.pnlCenter.Controls.Add(this.txUsername);
            this.pnlCenter.Controls.Add(this.pictureBox1);
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(0, 104);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(793, 215);
            this.pnlCenter.TabIndex = 0;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Location = new System.Drawing.Point(439, 148);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(97, 33);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "&Login";
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(257, 114);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(279, 28);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txUsername
            // 
            this.txUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txUsername.CustomButton.Image = null;
            this.txUsername.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txUsername.CustomButton.Name = "";
            this.txUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txUsername.CustomButton.TabIndex = 1;
            this.txUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txUsername.CustomButton.UseSelectable = true;
            this.txUsername.CustomButton.Visible = false;
            this.txUsername.DisplayIcon = true;
            this.txUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txUsername.Icon")));
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(257, 80);
            this.txUsername.MaxLength = 32767;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.SelectedText = "";
            this.txUsername.SelectionLength = 0;
            this.txUsername.SelectionStart = 0;
            this.txUsername.Size = new System.Drawing.Size(279, 28);
            this.txUsername.TabIndex = 6;
            this.txUsername.UseSelectable = true;
            this.txUsername.WaterMark = "Username";
            this.txUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.panel1);
            this.pnlSettings.Controls.Add(this.mtcSettings);
            this.pnlSettings.Controls.Add(this.lnkBack);
            this.pnlSettings.HorizontalScrollbarBarColor = true;
            this.pnlSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettings.HorizontalScrollbarSize = 10;
            this.pnlSettings.Location = new System.Drawing.Point(540, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlSettings.Size = new System.Drawing.Size(253, 423);
            this.pnlSettings.TabIndex = 1;
            this.pnlSettings.VerticalScrollbarBarColor = true;
            this.pnlSettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettings.VerticalScrollbarSize = 10;
            this.pnlSettings.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 423);
            this.panel1.TabIndex = 4;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Location = new System.Drawing.Point(13, 45);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 1;
            this.mtcSettings.Size = new System.Drawing.Size(237, 381);
            this.mtcSettings.TabIndex = 3;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(229, 339);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel2);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpSettings);
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.mtpTheme.Size = new System.Drawing.Size(229, 339);
            this.mtpTheme.TabIndex = 1;
            this.mtpTheme.Text = "&theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(72, 33);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(56, 19);
            this.mrbLight.TabIndex = 6;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(3, 33);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(54, 19);
            this.mrbDark.TabIndex = 5;
            this.mrbDark.Text = "&Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSettings.Location = new System.Drawing.Point(0, 80);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(229, 259);
            this.flpSettings.TabIndex = 2;
            // 
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(5, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkBack.NoFocusImage")));
            this.lnkBack.Size = new System.Drawing.Size(138, 36);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.Text = "&Settings";
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // pnlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlCenter);
            this.Name = "pnlLogin";
            this.Size = new System.Drawing.Size(793, 423);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlCenter;
        private MetroFramework.Controls.MetroPanel pnlSettings;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroLink lnkBack;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txUsername;
    }
}
