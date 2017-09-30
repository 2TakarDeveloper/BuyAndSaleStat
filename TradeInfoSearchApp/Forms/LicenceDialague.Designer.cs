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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.SubmitKey = new MetroFramework.Controls.MetroButton();
            this.LicenceBox = new MetroFramework.Controls.MetroTextBox();
            this.CancleButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.metroProgressBar1.Location = new System.Drawing.Point(3, 87);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(400, 10);
            this.metroProgressBar1.TabIndex = 6;
            this.metroProgressBar1.Visible = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.CancleButton);
            this.metroPanel2.Controls.Add(this.metroProgressBar1);
            this.metroPanel2.Controls.Add(this.SubmitKey);
            this.metroPanel2.Controls.Add(this.LicenceBox);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(50, 92);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(408, 100);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // SubmitKey
            // 
            this.SubmitKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitKey.Location = new System.Drawing.Point(133, 61);
            this.SubmitKey.Name = "SubmitKey";
            this.SubmitKey.Size = new System.Drawing.Size(132, 23);
            this.SubmitKey.TabIndex = 3;
            this.SubmitKey.Text = "Submit Key";
            this.SubmitKey.UseSelectable = true;
            this.SubmitKey.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // LicenceBox
            // 
            this.LicenceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.LicenceBox.CustomButton.Image = null;
            this.LicenceBox.CustomButton.Location = new System.Drawing.Point(378, 1);
            this.LicenceBox.CustomButton.Name = "";
            this.LicenceBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LicenceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LicenceBox.CustomButton.TabIndex = 1;
            this.LicenceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LicenceBox.CustomButton.UseSelectable = true;
            this.LicenceBox.CustomButton.Visible = false;
            this.LicenceBox.Lines = new string[0];
            this.LicenceBox.Location = new System.Drawing.Point(6, 32);
            this.LicenceBox.MaxLength = 32767;
            this.LicenceBox.Name = "LicenceBox";
            this.LicenceBox.PasswordChar = '\0';
            this.LicenceBox.PromptText = "Enter Product key here";
            this.LicenceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LicenceBox.SelectedText = "";
            this.LicenceBox.SelectionLength = 0;
            this.LicenceBox.SelectionStart = 0;
            this.LicenceBox.ShortcutsEnabled = true;
            this.LicenceBox.Size = new System.Drawing.Size(400, 23);
            this.LicenceBox.TabIndex = 2;
            this.LicenceBox.UseSelectable = true;
            this.LicenceBox.WaterMark = "Enter Product key here";
            this.LicenceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LicenceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancleButton
            // 
            this.CancleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancleButton.Location = new System.Drawing.Point(271, 61);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(132, 23);
            this.CancleButton.TabIndex = 7;
            this.CancleButton.Text = "Cancel";
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // LicenceDialague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 256);
            this.Controls.Add(this.metroPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenceDialague";
            this.Resizable = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Enter your Licence";
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton SubmitKey;
        private MetroFramework.Controls.MetroTextBox LicenceBox;
        private MetroFramework.Controls.MetroButton CancleButton;
    }
}