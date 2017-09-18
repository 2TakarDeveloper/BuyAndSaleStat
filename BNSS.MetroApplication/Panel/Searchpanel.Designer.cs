namespace BNSS.MetroApplication.Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SellertotalLable = new MetroFramework.Controls.MetroLabel();
            this.BuyerTotalLable = new MetroFramework.Controls.MetroLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.buyerRow = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BuyerExport = new MetroFramework.Controls.MetroButton();
            this.BuyerGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.sellerRow = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SellerExport = new MetroFramework.Controls.MetroButton();
            this.Sellergrid = new MetroFramework.Controls.MetroGrid();
            this.Back = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.startDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.EndDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sellergrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.splitContainer1);
            this.metroPanel1.Controls.Add(this.Back);
            this.metroPanel1.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(811, 485);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SellertotalLable
            // 
            this.SellertotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SellertotalLable.AutoSize = true;
            this.SellertotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SellertotalLable.Location = new System.Drawing.Point(349, 332);
            this.SellertotalLable.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.SellertotalLable.Name = "SellertotalLable";
            this.SellertotalLable.Size = new System.Drawing.Size(38, 19);
            this.SellertotalLable.TabIndex = 15;
            this.SellertotalLable.Text = "Total";
            this.SellertotalLable.UseCustomBackColor = true;
            // 
            // BuyerTotalLable
            // 
            this.BuyerTotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyerTotalLable.AutoSize = true;
            this.BuyerTotalLable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BuyerTotalLable.Location = new System.Drawing.Point(340, 332);
            this.BuyerTotalLable.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.BuyerTotalLable.Name = "BuyerTotalLable";
            this.BuyerTotalLable.Size = new System.Drawing.Size(38, 19);
            this.BuyerTotalLable.TabIndex = 14;
            this.BuyerTotalLable.Text = "Total";
            this.BuyerTotalLable.UseCustomBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(6, 94);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel2);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.metroPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(794, 362);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 11;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.BuyerTotalLable);
            this.metroPanel2.Controls.Add(this.buyerRow);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.BuyerExport);
            this.metroPanel2.Controls.Add(this.BuyerGrid);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(7, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel2.Size = new System.Drawing.Size(387, 356);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(211, 23);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Rows";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // buyerRow
            // 
            this.buyerRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buyerRow.Location = new System.Drawing.Point(258, 21);
            this.buyerRow.Name = "buyerRow";
            this.buyerRow.Size = new System.Drawing.Size(120, 20);
            this.buyerRow.TabIndex = 11;
            this.buyerRow.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(7, 23);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Buyers";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // BuyerExport
            // 
            this.BuyerExport.Location = new System.Drawing.Point(63, 19);
            this.BuyerExport.Name = "BuyerExport";
            this.BuyerExport.Size = new System.Drawing.Size(75, 23);
            this.BuyerExport.TabIndex = 9;
            this.BuyerExport.Text = "Export";
            this.BuyerExport.UseSelectable = true;
            this.BuyerExport.Click += new System.EventHandler(this.BuyersExport_Click);
            // 
            // BuyerGrid
            // 
            this.BuyerGrid.AllowUserToOrderColumns = true;
            this.BuyerGrid.AllowUserToResizeRows = false;
            this.BuyerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.BuyerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BuyerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BuyerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyerGrid.EnableHeadersVisualStyles = false;
            this.BuyerGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BuyerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BuyerGrid.Location = new System.Drawing.Point(8, 45);
            this.BuyerGrid.Name = "BuyerGrid";
            this.BuyerGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BuyerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BuyerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuyerGrid.Size = new System.Drawing.Size(371, 288);
            this.BuyerGrid.TabIndex = 8;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroPanel3.Controls.Add(this.SellertotalLable);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.sellerRow);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.SellerExport);
            this.metroPanel3.Controls.Add(this.Sellergrid);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel3.Size = new System.Drawing.Size(396, 356);
            this.metroPanel3.TabIndex = 12;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(220, 23);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Rows";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // sellerRow
            // 
            this.sellerRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerRow.Location = new System.Drawing.Point(267, 21);
            this.sellerRow.Name = "sellerRow";
            this.sellerRow.Size = new System.Drawing.Size(120, 20);
            this.sellerRow.TabIndex = 11;
            this.sellerRow.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(7, 23);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Seller";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // SellerExport
            // 
            this.SellerExport.Location = new System.Drawing.Point(63, 19);
            this.SellerExport.Name = "SellerExport";
            this.SellerExport.Size = new System.Drawing.Size(75, 23);
            this.SellerExport.TabIndex = 9;
            this.SellerExport.Text = "Export";
            this.SellerExport.UseSelectable = true;
            this.SellerExport.Click += new System.EventHandler(this.sellersExport_Click);
            // 
            // Sellergrid
            // 
            this.Sellergrid.AllowUserToResizeRows = false;
            this.Sellergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sellergrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sellergrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sellergrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Sellergrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sellergrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Sellergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sellergrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Sellergrid.EnableHeadersVisualStyles = false;
            this.Sellergrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Sellergrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sellergrid.Location = new System.Drawing.Point(8, 45);
            this.Sellergrid.Name = "Sellergrid";
            this.Sellergrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sellergrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Sellergrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Sellergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sellergrid.Size = new System.Drawing.Size(380, 288);
            this.Sellergrid.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(6, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseSelectable = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.SearchBox);
            this.flowLayoutPanel1.Controls.Add(this.itemBox);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel1.Controls.Add(this.startDateTime);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Controls.Add(this.EndDateTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 38);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(121, 21);
            this.SearchBox.TabIndex = 6;
            // 
            // itemBox
            // 
            this.itemBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(130, 3);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(121, 21);
            this.itemBox.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(257, 8);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "From";
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(304, 3);
            this.startDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(200, 29);
            this.startDateTime.TabIndex = 2;
            this.startDateTime.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(510, 8);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(23, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "To";
            // 
            // EndDateTime
            // 
            this.EndDateTime.Location = new System.Drawing.Point(539, 3);
            this.EndDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.Size = new System.Drawing.Size(200, 29);
            this.EndDateTime.TabIndex = 3;
            this.EndDateTime.Value = new System.DateTime(2017, 9, 18, 20, 8, 3, 0);
            this.EndDateTime.ValueChanged += new System.EventHandler(this.Search_initate);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 487);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "99 Rows";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 487);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Result:";
            // 
            // Searchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "Searchpanel";
            this.Size = new System.Drawing.Size(811, 485);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyerGrid)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sellergrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime startDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime EndDateTime;
        private MetroFramework.Controls.MetroLink Back;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton BuyerExport;
        private MetroFramework.Controls.MetroGrid BuyerGrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown buyerRow;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown sellerRow;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton SellerExport;
        private MetroFramework.Controls.MetroGrid Sellergrid;
        private MetroFramework.Controls.MetroLabel SellertotalLable;
        private MetroFramework.Controls.MetroLabel BuyerTotalLable;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.ComboBox itemBox;
    }
}
