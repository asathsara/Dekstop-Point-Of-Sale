using PointOfSale.Themes;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    partial class ItemManagementForm
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel2 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.roundedPanel3 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubmit = new PointOfSale.Components.RoundedButton();
            this.roundedTextboxID = new PointOfSale.Components.RoundedTextbox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxQuantity = new PointOfSale.Components.RoundedTextbox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.roundedTextboxUnitPrice = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxStock = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxDescription = new PointOfSale.Components.RoundedTextbox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.roundedTextboxBarcode = new PointOfSale.Components.RoundedTextbox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 666);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 666);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(423, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 593);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.roundedPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.roundedPanel3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(463, 593);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BottomLeftRadius = 30;
            this.roundedPanel2.BottomRightRadius = 30;
            this.roundedPanel2.Controls.Add(this.tableLayoutPanel6);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(95, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(271, 53);
            this.roundedPanel2.TabIndex = 3;
            this.roundedPanel2.TopLeftRadius = 30;
            this.roundedPanel2.TopRightRadius = 30;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBoxSearch, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(271, 53);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(57, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(211, 23);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedPanel3.BottomLeftRadius = 40;
            this.roundedPanel3.BottomRightRadius = 40;
            this.tableLayoutPanel3.SetColumnSpan(this.roundedPanel3, 3);
            this.roundedPanel3.Controls.Add(this.tableLayoutPanel5);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(0, 88);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(463, 505);
            this.roundedPanel3.TabIndex = 4;
            this.roundedPanel3.TopLeftRadius = 40;
            this.roundedPanel3.TopRightRadius = 40;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewItems, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(463, 505);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Barcode,
            this.RetailQuantity,
            this.RetailUnit,
            this.RetailUnitPrice,
            this.Stock,
            this.Description,
            this.AdminID,
            this.SupplierID,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.EnableHeadersVisualStyles = false;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewItems.RowTemplate.Height = 30;
            this.dataGridViewItems.Size = new System.Drawing.Size(463, 404);
            this.dataGridViewItems.TabIndex = 6;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_RowHeaderMouseClick);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = " ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 130;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // RetailQuantity
            // 
            this.RetailQuantity.DataPropertyName = "RetailQuantity";
            this.RetailQuantity.HeaderText = "Quantitiy";
            this.RetailQuantity.Name = "RetailQuantity";
            this.RetailQuantity.ReadOnly = true;
            // 
            // RetailUnit
            // 
            this.RetailUnit.DataPropertyName = "RetailUnit";
            this.RetailUnit.HeaderText = "Unit";
            this.RetailUnit.Name = "RetailUnit";
            this.RetailUnit.ReadOnly = true;
            // 
            // RetailUnitPrice
            // 
            this.RetailUnitPrice.DataPropertyName = "RetailUnitPrice";
            this.RetailUnitPrice.HeaderText = "Unit Price";
            this.RetailUnitPrice.Name = "RetailUnitPrice";
            this.RetailUnitPrice.ReadOnly = true;
            this.RetailUnitPrice.Width = 130;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 120;
            // 
            // AdminID
            // 
            this.AdminID.DataPropertyName = "AdminID";
            this.AdminID.HeaderText = "AdminID";
            this.AdminID.Name = "AdminID";
            this.AdminID.ReadOnly = true;
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierID";
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Width = 130;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BottomLeftRadius = 30;
            this.roundedPanel1.BottomRightRadius = 30;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(49, 36);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(322, 593);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.TopLeftRadius = 30;
            this.roundedPanel1.TopRightRadius = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSubmit, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxUnitPrice, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxStock, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxDescription, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxItems, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSuppliers, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxBarcode, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 593);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.buttonSubmit.BottomLeftRadius = 40;
            this.buttonSubmit.BottomRightRadius = 40;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(35, 501);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(251, 53);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TopLeftRadius = 40;
            this.buttonSubmit.TopRightRadius = 40;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // roundedTextboxID
            // 
            this.roundedTextboxID.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderRadius = 10;
            this.roundedTextboxID.BorderWidth = 0;
            this.roundedTextboxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxID.Location = new System.Drawing.Point(37, 34);
            this.roundedTextboxID.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxID.Name = "roundedTextboxID";
            this.roundedTextboxID.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxID.PasswordChar = '\0';
            this.roundedTextboxID.PlaceholderText = "ID";
            this.roundedTextboxID.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxID.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxQuantity, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUnit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(35, 197);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(251, 49);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // roundedTextboxQuantity
            // 
            this.roundedTextboxQuantity.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxQuantity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantity.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantity.BorderRadius = 10;
            this.roundedTextboxQuantity.BorderWidth = 0;
            this.roundedTextboxQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxQuantity.Location = new System.Drawing.Point(5, 5);
            this.roundedTextboxQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxQuantity.Name = "roundedTextboxQuantity";
            this.roundedTextboxQuantity.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxQuantity.PasswordChar = '\0';
            this.roundedTextboxQuantity.PlaceholderText = "Quantity";
            this.roundedTextboxQuantity.Size = new System.Drawing.Size(140, 39);
            this.roundedTextboxQuantity.TabIndex = 0;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(153, 3);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(95, 36);
            this.comboBoxUnit.TabIndex = 1;
            // 
            // roundedTextboxUnitPrice
            // 
            this.roundedTextboxUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxUnitPrice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxUnitPrice.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxUnitPrice.BorderRadius = 10;
            this.roundedTextboxUnitPrice.BorderWidth = 0;
            this.roundedTextboxUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxUnitPrice.Location = new System.Drawing.Point(37, 254);
            this.roundedTextboxUnitPrice.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxUnitPrice.Name = "roundedTextboxUnitPrice";
            this.roundedTextboxUnitPrice.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxUnitPrice.PasswordChar = '\0';
            this.roundedTextboxUnitPrice.PlaceholderText = "Unit Price";
            this.roundedTextboxUnitPrice.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxUnitPrice.TabIndex = 6;
            // 
            // roundedTextboxStock
            // 
            this.roundedTextboxStock.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxStock.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxStock.BorderRadius = 10;
            this.roundedTextboxStock.BorderWidth = 0;
            this.roundedTextboxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxStock.Location = new System.Drawing.Point(37, 309);
            this.roundedTextboxStock.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxStock.Name = "roundedTextboxStock";
            this.roundedTextboxStock.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxStock.PasswordChar = '\0';
            this.roundedTextboxStock.PlaceholderText = "Stock";
            this.roundedTextboxStock.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxStock.TabIndex = 7;
            // 
            // roundedTextboxDescription
            // 
            this.roundedTextboxDescription.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxDescription.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxDescription.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxDescription.BorderRadius = 10;
            this.roundedTextboxDescription.BorderWidth = 0;
            this.roundedTextboxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxDescription.Location = new System.Drawing.Point(37, 364);
            this.roundedTextboxDescription.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxDescription.Name = "roundedTextboxDescription";
            this.roundedTextboxDescription.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxDescription.PasswordChar = '\0';
            this.roundedTextboxDescription.PlaceholderText = "Description";
            this.roundedTextboxDescription.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxDescription.TabIndex = 8;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxItems.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(35, 142);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(251, 36);
            this.comboBoxItems.TabIndex = 9;
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(35, 87);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(251, 36);
            this.comboBoxSuppliers.TabIndex = 10;
            this.comboBoxSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppliers_SelectedIndexChanged);
            // 
            // roundedTextboxBarcode
            // 
            this.roundedTextboxBarcode.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxBarcode.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxBarcode.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxBarcode.BorderRadius = 10;
            this.roundedTextboxBarcode.BorderWidth = 0;
            this.roundedTextboxBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxBarcode.Location = new System.Drawing.Point(37, 419);
            this.roundedTextboxBarcode.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxBarcode.Name = "roundedTextboxBarcode";
            this.roundedTextboxBarcode.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxBarcode.PasswordChar = '\0';
            this.roundedTextboxBarcode.PlaceholderText = "Barcode";
            this.roundedTextboxBarcode.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxBarcode.TabIndex = 11;
            // 
            // ItemManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.panel1);
            this.Name = "ItemManagementForm";
            this.Text = "ItemManagmentForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.RoundedButton buttonSubmit;
        private Components.RoundedTextbox roundedTextboxID;
        private TableLayoutPanel tableLayoutPanel4;
        private Components.RoundedTextbox roundedTextboxQuantity;
        private ComboBox comboBoxUnit;
        private Components.RoundedTextbox roundedTextboxUnitPrice;
        private Components.RoundedTextbox roundedTextboxStock;
        private Components.RoundedTextbox roundedTextboxDescription;
        private ComboBox comboBoxItems;
        private ComboBox comboBoxSuppliers;
        private Components.RoundedTextbox roundedTextboxBarcode;
        private Components.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox1;
        private Components.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridViewItems;
        private TextBox textBoxSearch;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn RetailQuantity;
        private DataGridViewTextBoxColumn RetailUnit;
        private DataGridViewTextBoxColumn RetailUnitPrice;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn AdminID;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewImageColumn Delete;
    }
}