namespace BNSS.MetroApplication.Panel
{
    partial class ImportExport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Back = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteBuyerSheetButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteSellerSheetButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExportAsJsonButton = new MetroFramework.Controls.MetroLink();
            this.ImportFromExcelButton = new MetroFramework.Controls.MetroLink();
            this.importFromJsonButton = new MetroFramework.Controls.MetroLink();
            this.BuyerGrid = new MetroFramework.Controls.MetroGrid();
            this.SellerGrid = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Back, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BuyerGrid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SellerGrid, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.Image = global::BNSS.MetroApplication.Properties.Resources.Previous;
            this.Back.ImageSize = 28;
            this.Back.Location = new System.Drawing.Point(3, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(30, 29);
            this.Back.TabIndex = 14;
            this.Back.UseSelectable = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.DeleteBuyerSheetButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 88);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(444, 44);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // DeleteBuyerSheetButton
            // 
            this.DeleteBuyerSheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBuyerSheetButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteBuyerSheetButton.Name = "DeleteBuyerSheetButton";
            this.DeleteBuyerSheetButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteBuyerSheetButton.TabIndex = 10;
            this.DeleteBuyerSheetButton.Text = "Delete";
            this.DeleteBuyerSheetButton.UseSelectable = true;
            this.DeleteBuyerSheetButton.Click += new System.EventHandler(this.DeleteBuyerSheetButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.DeleteSellerSheetButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(453, 88);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(444, 44);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // DeleteSellerSheetButton
            // 
            this.DeleteSellerSheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSellerSheetButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteSellerSheetButton.Name = "DeleteSellerSheetButton";
            this.DeleteSellerSheetButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSellerSheetButton.TabIndex = 10;
            this.DeleteSellerSheetButton.Text = "Delete";
            this.DeleteSellerSheetButton.UseSelectable = true;
            this.DeleteSellerSheetButton.Click += new System.EventHandler(this.DeleteSellerSheetButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.ExportAsJsonButton);
            this.flowLayoutPanel1.Controls.Add(this.importFromJsonButton);
            this.flowLayoutPanel1.Controls.Add(this.ImportFromExcelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 44);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // ExportAsJsonButton
            // 
            this.ExportAsJsonButton.Image = global::BNSS.MetroApplication.Properties.Resources.Upload___02;
            this.ExportAsJsonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportAsJsonButton.ImageSize = 28;
            this.ExportAsJsonButton.Location = new System.Drawing.Point(3, 3);
            this.ExportAsJsonButton.Name = "ExportAsJsonButton";
            this.ExportAsJsonButton.Size = new System.Drawing.Size(53, 30);
            this.ExportAsJsonButton.TabIndex = 19;
            this.ExportAsJsonButton.Text = "Json";
            this.ExportAsJsonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportAsJsonButton.UseSelectable = true;
            this.ExportAsJsonButton.Click += new System.EventHandler(this.ExportAsJsonButton_Click);
            // 
            // ImportFromExcelButton
            // 
            this.ImportFromExcelButton.Image = global::BNSS.MetroApplication.Properties.Resources.Import__02;
            this.ImportFromExcelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportFromExcelButton.ImageSize = 28;
            this.ImportFromExcelButton.Location = new System.Drawing.Point(121, 3);
            this.ImportFromExcelButton.Name = "ImportFromExcelButton";
            this.ImportFromExcelButton.Size = new System.Drawing.Size(53, 30);
            this.ImportFromExcelButton.TabIndex = 18;
            this.ImportFromExcelButton.Text = "Exel";
            this.ImportFromExcelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportFromExcelButton.UseSelectable = true;
            this.ImportFromExcelButton.Click += new System.EventHandler(this.ImportFromExcelButton_Click);
            // 
            // importFromJsonButton
            // 
            this.importFromJsonButton.Image = global::BNSS.MetroApplication.Properties.Resources.Import__02;
            this.importFromJsonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importFromJsonButton.ImageSize = 28;
            this.importFromJsonButton.Location = new System.Drawing.Point(62, 3);
            this.importFromJsonButton.Name = "importFromJsonButton";
            this.importFromJsonButton.Size = new System.Drawing.Size(53, 30);
            this.importFromJsonButton.TabIndex = 17;
            this.importFromJsonButton.Text = "Json";
            this.importFromJsonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importFromJsonButton.UseSelectable = true;
            this.importFromJsonButton.Click += new System.EventHandler(this.importFromJsonButton_Click);
            // 
            // BuyerGrid
            // 
            this.BuyerGrid.AllowUserToAddRows = false;
            this.BuyerGrid.AllowUserToDeleteRows = false;
            this.BuyerGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BuyerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuyerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BuyerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.BuyerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BuyerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BuyerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.BuyerGrid.EnableHeadersVisualStyles = false;
            this.BuyerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.Location = new System.Drawing.Point(3, 138);
            this.BuyerGrid.Name = "BuyerGrid";
            this.BuyerGrid.ReadOnly = true;
            this.BuyerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BuyerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BuyerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuyerGrid.Size = new System.Drawing.Size(444, 346);
            this.BuyerGrid.TabIndex = 16;
            this.BuyerGrid.SelectionChanged += new System.EventHandler(this.BuyerGrid_SelectionChanged);
            // 
            // SellerGrid
            // 
            this.SellerGrid.AllowUserToAddRows = false;
            this.SellerGrid.AllowUserToDeleteRows = false;
            this.SellerGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SellerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SellerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SellerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SellerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SellerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.SellerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SellerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.SellerGrid.EnableHeadersVisualStyles = false;
            this.SellerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SellerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SellerGrid.Location = new System.Drawing.Point(453, 138);
            this.SellerGrid.Name = "SellerGrid";
            this.SellerGrid.ReadOnly = true;
            this.SellerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SellerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SellerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerGrid.Size = new System.Drawing.Size(444, 346);
            this.SellerGrid.TabIndex = 17;
            this.SellerGrid.SelectionChanged += new System.EventHandler(this.SellerGrid_SelectionChanged);
            // 
            // ImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImportExport";
            this.Size = new System.Drawing.Size(900, 487);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLink Back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroButton DeleteBuyerSheetButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroButton DeleteSellerSheetButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink ExportAsJsonButton;
        private MetroFramework.Controls.MetroLink ImportFromExcelButton;
        private MetroFramework.Controls.MetroLink importFromJsonButton;
        private MetroFramework.Controls.MetroGrid BuyerGrid;
        private MetroFramework.Controls.MetroGrid SellerGrid;
    }
}
