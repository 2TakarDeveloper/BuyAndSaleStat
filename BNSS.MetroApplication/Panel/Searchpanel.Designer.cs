﻿namespace BNSS.MetroApplication.Panel
{
    partial class Searchpanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BuyerGrid = new MetroFramework.Controls.MetroGrid();
            this.Sellergrid = new MetroFramework.Controls.MetroGrid();
            this.BuyerTotalLable = new MetroFramework.Controls.MetroLabel();
            this.SellertotalLable = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.buyerRow = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BuyerExport = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.sellerRow = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SellerExport = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.GroupByChecker = new System.Windows.Forms.CheckBox();
            this.SummaryCheck = new System.Windows.Forms.CheckBox();
            this.StartDateTime = new System.Windows.Forms.DateTimePicker();
            this.EndDateTime = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sellergrid)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerRow)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerRow)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuyerGrid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Sellergrid, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BuyerTotalLable, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SellertotalLable, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 485);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.SearchBox);
            this.flowLayoutPanel1.Controls.Add(this.itemBox);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel1.Controls.Add(this.StartDateTime);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Controls.Add(this.EndDateTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(805, 34);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(184, 28);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.SelectedIndexChanged += new System.EventHandler(this.Search_initate);
            // 
            // itemBox
            // 
            this.itemBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(193, 3);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(201, 28);
            this.itemBox.TabIndex = 7;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(400, 8);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "From";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(653, 8);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(23, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "To";
            // 
            // BuyerGrid
            // 
            this.BuyerGrid.AllowUserToOrderColumns = true;
            this.BuyerGrid.AllowUserToResizeRows = false;
            this.BuyerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BuyerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BuyerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BuyerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.BuyerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.BuyerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BuyerGrid.DefaultCellStyle = dataGridViewCellStyle32;
            this.BuyerGrid.EnableHeadersVisualStyles = false;
            this.BuyerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.Location = new System.Drawing.Point(3, 123);
            this.BuyerGrid.Name = "BuyerGrid";
            this.BuyerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.BuyerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BuyerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuyerGrid.Size = new System.Drawing.Size(399, 329);
            this.BuyerGrid.TabIndex = 9;
            // 
            // Sellergrid
            // 
            this.Sellergrid.AllowUserToResizeRows = false;
            this.Sellergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sellergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Sellergrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Sellergrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sellergrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sellergrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Sellergrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sellergrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.Sellergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sellergrid.DefaultCellStyle = dataGridViewCellStyle35;
            this.Sellergrid.EnableHeadersVisualStyles = false;
            this.Sellergrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Sellergrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sellergrid.Location = new System.Drawing.Point(408, 123);
            this.Sellergrid.Name = "Sellergrid";
            this.Sellergrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sellergrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.Sellergrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Sellergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sellergrid.Size = new System.Drawing.Size(400, 329);
            this.Sellergrid.TabIndex = 10;
            // 
            // BuyerTotalLable
            // 
            this.BuyerTotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyerTotalLable.AutoSize = true;
            this.BuyerTotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BuyerTotalLable.Location = new System.Drawing.Point(364, 466);
            this.BuyerTotalLable.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.BuyerTotalLable.Name = "BuyerTotalLable";
            this.BuyerTotalLable.Size = new System.Drawing.Size(38, 19);
            this.BuyerTotalLable.TabIndex = 15;
            this.BuyerTotalLable.Text = "Total";
            this.BuyerTotalLable.UseCustomBackColor = true;
            // 
            // SellertotalLable
            // 
            this.SellertotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SellertotalLable.AutoSize = true;
            this.SellertotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SellertotalLable.Location = new System.Drawing.Point(770, 466);
            this.SellertotalLable.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.SellertotalLable.Name = "SellertotalLable";
            this.SellertotalLable.Size = new System.Drawing.Size(38, 19);
            this.SellertotalLable.TabIndex = 16;
            this.SellertotalLable.Text = "Total";
            this.SellertotalLable.UseCustomBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.metroLabel5);
            this.flowLayoutPanel2.Controls.Add(this.buyerRow);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel6);
            this.flowLayoutPanel2.Controls.Add(this.BuyerExport);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(399, 34);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 8);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Rows";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // buyerRow
            // 
            this.buyerRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buyerRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerRow.Location = new System.Drawing.Point(50, 3);
            this.buyerRow.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.buyerRow.Name = "buyerRow";
            this.buyerRow.Size = new System.Drawing.Size(120, 23);
            this.buyerRow.TabIndex = 15;
            this.buyerRow.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.buyerRow.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(176, 8);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Buyers";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // BuyerExport
            // 
            this.BuyerExport.Location = new System.Drawing.Point(232, 3);
            this.BuyerExport.Name = "BuyerExport";
            this.BuyerExport.Size = new System.Drawing.Size(75, 23);
            this.BuyerExport.TabIndex = 13;
            this.BuyerExport.Text = "Export";
            this.BuyerExport.UseSelectable = true;
            this.BuyerExport.Click += new System.EventHandler(this.BuyersExport_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.metroLabel7);
            this.flowLayoutPanel3.Controls.Add(this.sellerRow);
            this.flowLayoutPanel3.Controls.Add(this.metroLabel8);
            this.flowLayoutPanel3.Controls.Add(this.SellerExport);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(408, 83);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(400, 34);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 8);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Rows";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // sellerRow
            // 
            this.sellerRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerRow.Location = new System.Drawing.Point(50, 3);
            this.sellerRow.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.sellerRow.Name = "sellerRow";
            this.sellerRow.Size = new System.Drawing.Size(120, 23);
            this.sellerRow.TabIndex = 15;
            this.sellerRow.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sellerRow.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(176, 8);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Seller";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // SellerExport
            // 
            this.SellerExport.Location = new System.Drawing.Point(223, 3);
            this.SellerExport.Name = "SellerExport";
            this.SellerExport.Size = new System.Drawing.Size(75, 23);
            this.SellerExport.TabIndex = 13;
            this.SellerExport.Text = "Export";
            this.SellerExport.UseSelectable = true;
            this.SellerExport.Click += new System.EventHandler(this.sellersExport_Click);
            // 
            // flowLayoutPanel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.GroupByChecker);
            this.flowLayoutPanel4.Controls.Add(this.SummaryCheck);
            this.flowLayoutPanel4.Controls.Add(this.GroupBox);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(805, 34);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // GroupBox
            // 
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Items.AddRange(new object[] {
            "Customer",
            "Item"});
            this.GroupBox.Location = new System.Drawing.Point(201, 3);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(184, 28);
            this.GroupBox.TabIndex = 7;
            this.GroupBox.Text = "Customer";
            this.GroupBox.Visible = false;
            this.GroupBox.SelectedIndexChanged += new System.EventHandler(this.GroupBox_SelectedIndexChanged);
            // 
            // GroupByChecker
            // 
            this.GroupByChecker.AutoSize = true;
            this.GroupByChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupByChecker.Location = new System.Drawing.Point(3, 3);
            this.GroupByChecker.Name = "GroupByChecker";
            this.GroupByChecker.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.GroupByChecker.Size = new System.Drawing.Size(91, 28);
            this.GroupByChecker.TabIndex = 9;
            this.GroupByChecker.Text = "GroupBy";
            this.GroupByChecker.UseVisualStyleBackColor = true;
            this.GroupByChecker.CheckedChanged += new System.EventHandler(this.GroupByChecker_CheckedChanged);
            // 
            // SummaryCheck
            // 
            this.SummaryCheck.AutoSize = true;
            this.SummaryCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryCheck.Location = new System.Drawing.Point(100, 3);
            this.SummaryCheck.Name = "SummaryCheck";
            this.SummaryCheck.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SummaryCheck.Size = new System.Drawing.Size(95, 28);
            this.SummaryCheck.TabIndex = 10;
            this.SummaryCheck.Text = "Summary";
            this.SummaryCheck.UseVisualStyleBackColor = true;
            this.SummaryCheck.Visible = false;
            // 
            // StartDateTime
            // 
            this.StartDateTime.Location = new System.Drawing.Point(447, 3);
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.Size = new System.Drawing.Size(200, 20);
            this.StartDateTime.TabIndex = 8;
            this.StartDateTime.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.StartDateTime.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // EndDateTime
            // 
            this.EndDateTime.Location = new System.Drawing.Point(3, 37);
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.Size = new System.Drawing.Size(200, 20);
            this.EndDateTime.TabIndex = 9;
            this.EndDateTime.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // Searchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Searchpanel";
            this.Size = new System.Drawing.Size(811, 485);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sellergrid)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerRow)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerRow)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroGrid BuyerGrid;
        private MetroFramework.Controls.MetroGrid Sellergrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.ComboBox itemBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown buyerRow;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton BuyerExport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown sellerRow;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton SellerExport;
        private MetroFramework.Controls.MetroLabel BuyerTotalLable;
        private MetroFramework.Controls.MetroLabel SellertotalLable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.CheckBox GroupByChecker;
        private System.Windows.Forms.CheckBox SummaryCheck;
        private System.Windows.Forms.DateTimePicker StartDateTime;
        private System.Windows.Forms.DateTimePicker EndDateTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
