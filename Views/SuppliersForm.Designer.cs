﻿using System.Windows.Forms;

namespace PointOfSale.Views
{
    partial class SuppliersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxUnitPrice = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxSupplier = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxContact = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxID = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxItem = new PointOfSale.Components.RoundedTextbox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxQuantity = new PointOfSale.Components.RoundedTextbox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedButtonUpdate = new PointOfSale.Components.RoundedButton();
            this.roundedButtonSubmit = new PointOfSale.Components.RoundedButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
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
            this.textBoxSearch.TabIndex = 2;
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
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewSuppliers, 0, 1);
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
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AllowUserToResizeColumns = false;
            this.dataGridViewSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.ItemName,
            this.SupplierName,
            this.ContactNumber,
            this.WholeSaleQuantity,
            this.WholeSaleUnit,
            this.WholeSaleUnitPrice,
            this.AdminID,
            this.Delete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSuppliers.RowTemplate.Height = 30;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(463, 404);
            this.dataGridViewSuppliers.TabIndex = 6;
            this.dataGridViewSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewSuppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_RowHeaderMouseClick);
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierID";
            this.SupplierID.HeaderText = " ID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 140;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 170;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 190;
            // 
            // WholeSaleQuantity
            // 
            this.WholeSaleQuantity.DataPropertyName = "WholeSaleQuantity";
            this.WholeSaleQuantity.HeaderText = "Quantity";
            this.WholeSaleQuantity.Name = "WholeSaleQuantity";
            this.WholeSaleQuantity.ReadOnly = true;
            // 
            // WholeSaleUnit
            // 
            this.WholeSaleUnit.DataPropertyName = "WholeSaleUnit";
            this.WholeSaleUnit.HeaderText = "Unit";
            this.WholeSaleUnit.Name = "WholeSaleUnit";
            this.WholeSaleUnit.ReadOnly = true;
            // 
            // WholeSaleUnitPrice
            // 
            this.WholeSaleUnitPrice.DataPropertyName = "WholeSaleUnitPrice";
            this.WholeSaleUnitPrice.HeaderText = "Unit Price";
            this.WholeSaleUnitPrice.Name = "WholeSaleUnitPrice";
            this.WholeSaleUnitPrice.ReadOnly = true;
            this.WholeSaleUnitPrice.Width = 140;
            // 
            // AdminID
            // 
            this.AdminID.DataPropertyName = "AdminID";
            this.AdminID.HeaderText = "Admin ID";
            this.AdminID.Name = "AdminID";
            this.AdminID.ReadOnly = true;
            this.AdminID.Width = 130;
            // 
            // Delete
            // 
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
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxUnitPrice, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxSupplier, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxContact, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxID, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxItem, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 10);
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
            // roundedTextboxUnitPrice
            // 
            this.roundedTextboxUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxUnitPrice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxUnitPrice.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxUnitPrice.BorderRadius = 10;
            this.roundedTextboxUnitPrice.BorderWidth = 0;
            this.roundedTextboxUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxUnitPrice.Location = new System.Drawing.Point(37, 309);
            this.roundedTextboxUnitPrice.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxUnitPrice.Name = "roundedTextboxUnitPrice";
            this.roundedTextboxUnitPrice.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxUnitPrice.PasswordChar = '\0';
            this.roundedTextboxUnitPrice.PlaceholderText = "Unit Price";
            this.roundedTextboxUnitPrice.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxUnitPrice.TabIndex = 11;
            // 
            // roundedTextboxSupplier
            // 
            this.roundedTextboxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxSupplier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxSupplier.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxSupplier.BorderRadius = 10;
            this.roundedTextboxSupplier.BorderWidth = 0;
            this.roundedTextboxSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxSupplier.Location = new System.Drawing.Point(37, 199);
            this.roundedTextboxSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxSupplier.Name = "roundedTextboxSupplier";
            this.roundedTextboxSupplier.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxSupplier.PasswordChar = '\0';
            this.roundedTextboxSupplier.PlaceholderText = "Supplier";
            this.roundedTextboxSupplier.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxSupplier.TabIndex = 13;
            // 
            // roundedTextboxContact
            // 
            this.roundedTextboxContact.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxContact.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxContact.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxContact.BorderRadius = 10;
            this.roundedTextboxContact.BorderWidth = 0;
            this.roundedTextboxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxContact.Location = new System.Drawing.Point(37, 364);
            this.roundedTextboxContact.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxContact.Name = "roundedTextboxContact";
            this.roundedTextboxContact.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxContact.PasswordChar = '\0';
            this.roundedTextboxContact.PlaceholderText = "Contact Number";
            this.roundedTextboxContact.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxContact.TabIndex = 15;
            // 
            // roundedTextboxID
            // 
            this.roundedTextboxID.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderRadius = 10;
            this.roundedTextboxID.BorderWidth = 0;
            this.roundedTextboxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxID.Location = new System.Drawing.Point(37, 89);
            this.roundedTextboxID.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxID.Name = "roundedTextboxID";
            this.roundedTextboxID.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxID.PasswordChar = '\0';
            this.roundedTextboxID.PlaceholderText = "ID";
            this.roundedTextboxID.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxID.TabIndex = 14;
            // 
            // roundedTextboxItem
            // 
            this.roundedTextboxItem.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxItem.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxItem.BorderRadius = 10;
            this.roundedTextboxItem.BorderWidth = 0;
            this.roundedTextboxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxItem.Location = new System.Drawing.Point(37, 144);
            this.roundedTextboxItem.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxItem.Name = "roundedTextboxItem";
            this.roundedTextboxItem.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxItem.PasswordChar = '\0';
            this.roundedTextboxItem.PlaceholderText = "Item";
            this.roundedTextboxItem.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxItem.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxQuantity, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUnit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(35, 252);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(251, 49);
            this.tableLayoutPanel4.TabIndex = 17;
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
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.roundedButtonUpdate, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.roundedButtonSubmit, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(32, 498);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(257, 59);
            this.tableLayoutPanel7.TabIndex = 18;
            // 
            // roundedButtonUpdate
            // 
            this.roundedButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedButtonUpdate.BottomLeftRadius = 25;
            this.roundedButtonUpdate.BottomRightRadius = 25;
            this.roundedButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonUpdate.FlatAppearance.BorderSize = 0;
            this.roundedButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonUpdate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.roundedButtonUpdate.Location = new System.Drawing.Point(133, 5);
            this.roundedButtonUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.roundedButtonUpdate.Name = "roundedButtonUpdate";
            this.roundedButtonUpdate.Size = new System.Drawing.Size(119, 49);
            this.roundedButtonUpdate.TabIndex = 3;
            this.roundedButtonUpdate.Text = "Update";
            this.roundedButtonUpdate.TopLeftRadius = 25;
            this.roundedButtonUpdate.TopRightRadius = 25;
            this.roundedButtonUpdate.UseVisualStyleBackColor = false;
            this.roundedButtonUpdate.Click += new System.EventHandler(this.roundedButtonUpdate_Click);
            // 
            // roundedButtonSubmit
            // 
            this.roundedButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedButtonSubmit.BottomLeftRadius = 25;
            this.roundedButtonSubmit.BottomRightRadius = 25;
            this.roundedButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonSubmit.FlatAppearance.BorderSize = 0;
            this.roundedButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonSubmit.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.roundedButtonSubmit.Location = new System.Drawing.Point(5, 5);
            this.roundedButtonSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.roundedButtonSubmit.Name = "roundedButtonSubmit";
            this.roundedButtonSubmit.Size = new System.Drawing.Size(118, 49);
            this.roundedButtonSubmit.TabIndex = 2;
            this.roundedButtonSubmit.Text = "Submit";
            this.roundedButtonSubmit.TopLeftRadius = 25;
            this.roundedButtonSubmit.TopRightRadius = 25;
            this.roundedButtonSubmit.UseVisualStyleBackColor = false;
            this.roundedButtonSubmit.Click += new System.EventHandler(this.roundedButtonSubmit_Click);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox1;
        private Components.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridViewSuppliers;
        private Components.RoundedTextbox roundedTextboxUnitPrice;
        private Components.RoundedTextbox roundedTextboxSupplier;
        private Components.RoundedTextbox roundedTextboxID;
        private Components.RoundedTextbox roundedTextboxContact;
        private Components.RoundedTextbox roundedTextboxItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Components.RoundedTextbox roundedTextboxQuantity;
        private ComboBox comboBoxUnit;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn WholeSaleQuantity;
        private DataGridViewTextBoxColumn WholeSaleUnit;
        private DataGridViewTextBoxColumn WholeSaleUnitPrice;
        private DataGridViewTextBoxColumn AdminID;
        private DataGridViewImageColumn Delete;
        private TextBox textBoxSearch;
        private TableLayoutPanel tableLayoutPanel7;
        private Components.RoundedButton roundedButtonUpdate;
        private Components.RoundedButton roundedButtonSubmit;
    }
}