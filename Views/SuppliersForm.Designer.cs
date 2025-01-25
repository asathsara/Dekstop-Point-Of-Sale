using System.Windows.Forms;

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
            this.roundedTextbox3 = new PointOfSale.Components.RoundedTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel3 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxUnitPrice = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxSupplier = new PointOfSale.Components.RoundedTextbox();
            this.buttonSubmit = new PointOfSale.Components.RoundedButton();
            this.roundedTextboxContact = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxID = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxItem = new PointOfSale.Components.RoundedTextbox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxQuantitiy = new PointOfSale.Components.RoundedTextbox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel1.Size = new System.Drawing.Size(1097, 733);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 733);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(494, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 653);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(542, 653);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BottomLeftRadius = 30;
            this.roundedPanel2.BottomRightRadius = 30;
            this.roundedPanel2.Controls.Add(this.tableLayoutPanel6);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(111, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(319, 59);
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
            this.tableLayoutPanel6.Controls.Add(this.roundedTextbox3, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(319, 59);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // roundedTextbox3
            // 
            this.roundedTextbox3.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextbox3.BackgroundColor = System.Drawing.Color.White;
            this.roundedTextbox3.BorderColor = System.Drawing.Color.White;
            this.roundedTextbox3.BorderRadius = 10;
            this.roundedTextbox3.BorderWidth = 0;
            this.roundedTextbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextbox3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextbox3.Location = new System.Drawing.Point(63, 14);
            this.roundedTextbox3.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.roundedTextbox3.Name = "roundedTextbox3";
            this.roundedTextbox3.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextbox3.PasswordChar = '\0';
            this.roundedTextbox3.PlaceholderText = "Search";
            this.roundedTextbox3.Size = new System.Drawing.Size(236, 29);
            this.roundedTextbox3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedPanel3.BottomLeftRadius = 40;
            this.roundedPanel3.BottomRightRadius = 40;
            this.tableLayoutPanel3.SetColumnSpan(this.roundedPanel3, 3);
            this.roundedPanel3.Controls.Add(this.tableLayoutPanel5);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(0, 97);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(542, 556);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(542, 556);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.ItemName,
            this.SupplierName,
            this.ContactNumber,
            this.WholeSaleQuantity,
            this.WholeSaleUnit,
            this.WholeSaleUnitPrice,
            this.AdminID,
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
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 55);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewItems.RowTemplate.Height = 30;
            this.dataGridViewItems.Size = new System.Drawing.Size(542, 444);
            this.dataGridViewItems.TabIndex = 6;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BottomLeftRadius = 30;
            this.roundedPanel1.BottomRightRadius = 30;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(57, 39);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(377, 653);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.TopLeftRadius = 30;
            this.roundedPanel1.TopRightRadius = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxUnitPrice, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxSupplier, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonSubmit, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxContact, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxID, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxItem, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 5);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(377, 653);
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
            this.roundedTextboxUnitPrice.Location = new System.Drawing.Point(42, 342);
            this.roundedTextboxUnitPrice.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxUnitPrice.Name = "roundedTextboxUnitPrice";
            this.roundedTextboxUnitPrice.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxUnitPrice.PasswordChar = '\0';
            this.roundedTextboxUnitPrice.PlaceholderText = "Unit Price";
            this.roundedTextboxUnitPrice.Size = new System.Drawing.Size(291, 51);
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
            this.roundedTextboxSupplier.Location = new System.Drawing.Point(42, 220);
            this.roundedTextboxSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxSupplier.Name = "roundedTextboxSupplier";
            this.roundedTextboxSupplier.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxSupplier.PasswordChar = '\0';
            this.roundedTextboxSupplier.PlaceholderText = "Supplier";
            this.roundedTextboxSupplier.Size = new System.Drawing.Size(291, 51);
            this.roundedTextboxSupplier.TabIndex = 13;
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
            this.buttonSubmit.Location = new System.Drawing.Point(40, 555);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(295, 59);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TopLeftRadius = 40;
            this.buttonSubmit.TopRightRadius = 40;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // roundedTextboxContact
            // 
            this.roundedTextboxContact.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxContact.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxContact.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxContact.BorderRadius = 10;
            this.roundedTextboxContact.BorderWidth = 0;
            this.roundedTextboxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxContact.Location = new System.Drawing.Point(42, 403);
            this.roundedTextboxContact.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxContact.Name = "roundedTextboxContact";
            this.roundedTextboxContact.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxContact.PasswordChar = '\0';
            this.roundedTextboxContact.PlaceholderText = "Contact Number";
            this.roundedTextboxContact.Size = new System.Drawing.Size(291, 51);
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
            this.roundedTextboxID.Location = new System.Drawing.Point(42, 98);
            this.roundedTextboxID.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxID.Name = "roundedTextboxID";
            this.roundedTextboxID.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxID.PasswordChar = '\0';
            this.roundedTextboxID.PlaceholderText = "ID";
            this.roundedTextboxID.Size = new System.Drawing.Size(291, 51);
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
            this.roundedTextboxItem.Location = new System.Drawing.Point(42, 159);
            this.roundedTextboxItem.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxItem.Name = "roundedTextboxItem";
            this.roundedTextboxItem.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxItem.PasswordChar = '\0';
            this.roundedTextboxItem.PlaceholderText = "Item";
            this.roundedTextboxItem.Size = new System.Drawing.Size(291, 51);
            this.roundedTextboxItem.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxQuantitiy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUnit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(40, 279);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(295, 55);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // roundedTextboxQuantitiy
            // 
            this.roundedTextboxQuantitiy.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxQuantitiy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantitiy.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantitiy.BorderRadius = 10;
            this.roundedTextboxQuantitiy.BorderWidth = 0;
            this.roundedTextboxQuantitiy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxQuantitiy.Location = new System.Drawing.Point(5, 5);
            this.roundedTextboxQuantitiy.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxQuantitiy.Name = "roundedTextboxQuantitiy";
            this.roundedTextboxQuantitiy.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxQuantitiy.PasswordChar = '\0';
            this.roundedTextboxQuantitiy.PlaceholderText = "Quantity";
            this.roundedTextboxQuantitiy.Size = new System.Drawing.Size(167, 45);
            this.roundedTextboxQuantitiy.TabIndex = 0;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(180, 3);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(112, 36);
            this.comboBoxUnit.TabIndex = 1;
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
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1097, 733);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersForm";
            this.Text = "ItemManagmentForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
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
        private Components.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private Components.RoundedTextbox roundedTextbox3;
        private PictureBox pictureBox1;
        private Components.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridViewItems;
        private Components.RoundedTextbox roundedTextboxUnitPrice;
        private Components.RoundedTextbox roundedTextboxSupplier;
        private Components.RoundedTextbox roundedTextboxID;
        private Components.RoundedTextbox roundedTextboxContact;
        private Components.RoundedTextbox roundedTextboxItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Components.RoundedTextbox roundedTextboxQuantitiy;
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
    }
}