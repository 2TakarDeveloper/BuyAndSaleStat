namespace TradeInfoSearchApp.Forms
{
    partial class Settings
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TableColorShower1 = new MetroFramework.Controls.MetroTile();
            this.TableColorShower2 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearMemoryButton = new MetroFramework.Controls.MetroTile();
            this.ExportMemoryButton = new MetroFramework.Controls.MetroTile();
            this.ImportMemoryButton = new MetroFramework.Controls.MetroTile();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(568, 350);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.TableColorShower1);
            this.metroTabPage1.Controls.Add(this.TableColorShower2);
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.metroTabPage1.Size = new System.Drawing.Size(560, 308);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Interface";
            this.metroTabPage1.UseCustomForeColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Row Color 2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Row Color 1";
            // 
            // TableColorShower1
            // 
            this.TableColorShower1.ActiveControl = null;
            this.TableColorShower1.Location = new System.Drawing.Point(136, 30);
            this.TableColorShower1.Name = "TableColorShower1";
            this.TableColorShower1.Size = new System.Drawing.Size(75, 23);
            this.TableColorShower1.TabIndex = 4;
            this.TableColorShower1.Text = "metroTile1";
            this.TableColorShower1.UseCustomBackColor = true;
            this.TableColorShower1.UseSelectable = true;
            this.TableColorShower1.Click += new System.EventHandler(this.ColorStrip1_Click);
            // 
            // TableColorShower2
            // 
            this.TableColorShower2.ActiveControl = null;
            this.TableColorShower2.Location = new System.Drawing.Point(136, 59);
            this.TableColorShower2.Name = "TableColorShower2";
            this.TableColorShower2.Size = new System.Drawing.Size(75, 23);
            this.TableColorShower2.TabIndex = 5;
            this.TableColorShower2.Text = "metroTile2";
            this.TableColorShower2.UseCustomBackColor = true;
            this.TableColorShower2.UseSelectable = true;
            this.TableColorShower2.Click += new System.EventHandler(this.TableColor2_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.metroTabPage2.Size = new System.Drawing.Size(560, 308);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Memory";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Tan;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.ClearMemoryButton);
            this.flowLayoutPanel1.Controls.Add(this.ExportMemoryButton);
            this.flowLayoutPanel1.Controls.Add(this.ImportMemoryButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 298);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ClearMemoryButton
            // 
            this.ClearMemoryButton.ActiveControl = null;
            this.ClearMemoryButton.BackColor = System.Drawing.Color.Sienna;
            this.ClearMemoryButton.Location = new System.Drawing.Point(13, 13);
            this.ClearMemoryButton.Name = "ClearMemoryButton";
            this.ClearMemoryButton.Size = new System.Drawing.Size(148, 105);
            this.ClearMemoryButton.TabIndex = 0;
            this.ClearMemoryButton.Text = "Clear Memory";
            this.ClearMemoryButton.UseCustomBackColor = true;
            this.ClearMemoryButton.UseSelectable = true;
            this.ClearMemoryButton.Click += new System.EventHandler(this.ClearMemoryButton_Click);
            // 
            // ExportMemoryButton
            // 
            this.ExportMemoryButton.ActiveControl = null;
            this.ExportMemoryButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExportMemoryButton.Location = new System.Drawing.Point(167, 13);
            this.ExportMemoryButton.Name = "ExportMemoryButton";
            this.ExportMemoryButton.Size = new System.Drawing.Size(148, 105);
            this.ExportMemoryButton.TabIndex = 1;
            this.ExportMemoryButton.Text = "Export Memory";
            this.ExportMemoryButton.UseCustomBackColor = true;
            this.ExportMemoryButton.UseSelectable = true;
            this.ExportMemoryButton.Click += new System.EventHandler(this.ExportMemoryButton_Click);
            // 
            // ImportMemoryButton
            // 
            this.ImportMemoryButton.ActiveControl = null;
            this.ImportMemoryButton.BackColor = System.Drawing.Color.Olive;
            this.ImportMemoryButton.Location = new System.Drawing.Point(321, 13);
            this.ImportMemoryButton.Name = "ImportMemoryButton";
            this.ImportMemoryButton.Size = new System.Drawing.Size(148, 105);
            this.ImportMemoryButton.TabIndex = 2;
            this.ImportMemoryButton.Text = "Import Memory";
            this.ImportMemoryButton.UseCustomBackColor = true;
            this.ImportMemoryButton.UseSelectable = true;
            this.ImportMemoryButton.Click += new System.EventHandler(this.ImportMemoryButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 430);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroTile TableColorShower2;
        private MetroFramework.Controls.MetroTile TableColorShower1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile ClearMemoryButton;
        private MetroFramework.Controls.MetroTile ExportMemoryButton;
        private MetroFramework.Controls.MetroTile ImportMemoryButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}