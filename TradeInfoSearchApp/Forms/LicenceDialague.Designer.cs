namespace BNSS.Application.Forms
{
    partial class LicenceDialague
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
            this.LicenceBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ValidateButton = new MetroFramework.Controls.MetroButton();
            this.CancleButton = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // LicenceBox
            // 
            // 
            // 
            // 
            this.LicenceBox.CustomButton.Image = null;
            this.LicenceBox.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.LicenceBox.CustomButton.Name = "";
            this.LicenceBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LicenceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LicenceBox.CustomButton.TabIndex = 1;
            this.LicenceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LicenceBox.CustomButton.UseSelectable = true;
            this.LicenceBox.CustomButton.Visible = false;
            this.LicenceBox.Lines = new string[0];
            this.LicenceBox.Location = new System.Drawing.Point(103, 85);
            this.LicenceBox.MaxLength = 32767;
            this.LicenceBox.Name = "LicenceBox";
            this.LicenceBox.PasswordChar = '\0';
            this.LicenceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LicenceBox.SelectedText = "";
            this.LicenceBox.SelectionLength = 0;
            this.LicenceBox.SelectionStart = 0;
            this.LicenceBox.ShortcutsEnabled = true;
            this.LicenceBox.Size = new System.Drawing.Size(316, 23);
            this.LicenceBox.TabIndex = 0;
            this.LicenceBox.UseSelectable = true;
            this.LicenceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LicenceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Key";
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(282, 202);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(96, 23);
            this.ValidateButton.TabIndex = 2;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.UseSelectable = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(397, 202);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(96, 23);
            this.CancleButton.TabIndex = 5;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(103, 130);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(207, 10);
            this.metroProgressBar1.TabIndex = 6;
            this.metroProgressBar1.Visible = false;
            // 
            // LicenceDialague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 259);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LicenceBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenceDialague";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Enter your Licence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox LicenceBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton ValidateButton;
        private MetroFramework.Controls.MetroButton CancleButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}