using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PointOfSale.Views
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedTextboxQuantitiy = new PointOfSale.Components.RoundedTextbox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.buttonCalculate = new PointOfSale.Components.RoundedButton();
            this.roundedButtonAdd = new PointOfSale.Components.RoundedButton();
            this.roundedPanel2 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.richTextBoxBill = new System.Windows.Forms.RichTextBox();
            this.roundedButtonClear = new PointOfSale.Components.RoundedButton();
            this.roundedButtonPrint = new PointOfSale.Components.RoundedButton();
            this.roundedTextboxAmountPaid = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxDiscountPercenatge = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxCustomerCard = new PointOfSale.Components.RoundedTextbox();
            this.roundedPanel3 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel16.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 666);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 666);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BottomLeftRadius = 15;
            this.roundedPanel1.BottomRightRadius = 15;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(40, 16);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(501, 233);
            this.roundedPanel1.TabIndex = 4;
            this.roundedPanel1.TopLeftRadius = 15;
            this.roundedPanel1.TopRightRadius = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxItems, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBarcode, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonCalculate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.roundedButtonAdd, 3, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 233);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.labelTotalPrice);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(263, 88);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 56);
            this.panel9.TabIndex = 4;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalPrice.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTotalPrice.Location = new System.Drawing.Point(0, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(194, 56);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "Rs. 0.00";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.roundedTextboxQuantitiy, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxUnit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 88);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 56);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // roundedTextboxQuantitiy
            // 
            this.roundedTextboxQuantitiy.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxQuantitiy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantitiy.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxQuantitiy.BorderRadius = 10;
            this.roundedTextboxQuantitiy.BorderWidth = 0;
            this.roundedTextboxQuantitiy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxQuantitiy.Location = new System.Drawing.Point(3, 10);
            this.roundedTextboxQuantitiy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.roundedTextboxQuantitiy.Name = "roundedTextboxQuantitiy";
            this.roundedTextboxQuantitiy.Padding = new System.Windows.Forms.Padding(8);
            this.roundedTextboxQuantitiy.PasswordChar = '\0';
            this.roundedTextboxQuantitiy.PlaceholderText = "Quantity";
            this.roundedTextboxQuantitiy.Size = new System.Drawing.Size(110, 36);
            this.roundedTextboxQuantitiy.TabIndex = 0;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(119, 10);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(72, 36);
            this.comboBoxUnit.TabIndex = 1;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxItems.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(43, 26);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(194, 36);
            this.comboBoxItems.TabIndex = 11;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // labelBarcode
            // 
            this.labelBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBarcode.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBarcode.Location = new System.Drawing.Point(263, 23);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(194, 62);
            this.labelBarcode.TabIndex = 12;
            this.labelBarcode.Text = "123456";
            this.labelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.buttonCalculate.BottomLeftRadius = 40;
            this.buttonCalculate.BottomRightRadius = 40;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(43, 173);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(194, 31);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.TopLeftRadius = 40;
            this.buttonCalculate.TopRightRadius = 40;
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // roundedButtonAdd
            // 
            this.roundedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedButtonAdd.BottomLeftRadius = 40;
            this.roundedButtonAdd.BottomRightRadius = 40;
            this.roundedButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonAdd.FlatAppearance.BorderSize = 0;
            this.roundedButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAdd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonAdd.ForeColor = System.Drawing.Color.White;
            this.roundedButtonAdd.Location = new System.Drawing.Point(263, 173);
            this.roundedButtonAdd.Name = "roundedButtonAdd";
            this.roundedButtonAdd.Size = new System.Drawing.Size(194, 31);
            this.roundedButtonAdd.TabIndex = 14;
            this.roundedButtonAdd.Text = "Add";
            this.roundedButtonAdd.TopLeftRadius = 40;
            this.roundedButtonAdd.TopRightRadius = 40;
            this.roundedButtonAdd.UseVisualStyleBackColor = false;
            this.roundedButtonAdd.Click += new System.EventHandler(this.roundedButtonAdd_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BottomLeftRadius = 30;
            this.roundedPanel2.BottomRightRadius = 30;
            this.roundedPanel2.Controls.Add(this.tableLayoutPanel4);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(575, 16);
            this.roundedPanel2.Name = "roundedPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.roundedPanel2, 3);
            this.roundedPanel2.Size = new System.Drawing.Size(322, 631);
            this.roundedPanel2.TabIndex = 5;
            this.roundedPanel2.TopLeftRadius = 30;
            this.roundedPanel2.TopRightRadius = 30;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.Controls.Add(this.labelBalance, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.label31, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label27, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelTotal, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.label23, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.labelDiscount, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label19, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label15, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelSubTotal, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel16, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.roundedButtonClear, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.roundedButtonPrint, 2, 11);
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxAmountPaid, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxDiscountPercenatge, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.roundedTextboxCustomerCard, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 13;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(322, 631);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelBalance.Location = new System.Drawing.Point(163, 253);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(148, 37);
            this.labelBalance.TabIndex = 40;
            this.labelBalance.Text = "Rs. 0.00";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label31.Location = new System.Drawing.Point(9, 253);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(148, 37);
            this.label31.TabIndex = 39;
            this.label31.Text = "Balance :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.Location = new System.Drawing.Point(9, 216);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(148, 37);
            this.label27.TabIndex = 35;
            this.label27.Text = "Amount Paid :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotal.Location = new System.Drawing.Point(163, 179);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(148, 37);
            this.labelTotal.TabIndex = 32;
            this.labelTotal.Text = "Rs. 0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(9, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(148, 37);
            this.label23.TabIndex = 31;
            this.label23.Text = "Total : ";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelDiscount.Location = new System.Drawing.Point(163, 142);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(148, 37);
            this.labelDiscount.TabIndex = 28;
            this.labelDiscount.Text = "Rs. 0.00";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(9, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 37);
            this.label19.TabIndex = 27;
            this.label19.Text = "Total Discount :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(9, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 37);
            this.label15.TabIndex = 23;
            this.label15.Text = "Discount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(9, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 37);
            this.label11.TabIndex = 19;
            this.label11.Text = "Loyalty Customer";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelSubTotal.Location = new System.Drawing.Point(163, 31);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(148, 37);
            this.labelSubTotal.TabIndex = 16;
            this.labelSubTotal.Text = "Rs. 0.00";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sub Total : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel16
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.panel16, 2);
            this.panel16.Controls.Add(this.richTextBoxBill);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(9, 305);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(302, 246);
            this.panel16.TabIndex = 7;
            // 
            // richTextBoxBill
            // 
            this.richTextBoxBill.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBoxBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxBill.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxBill.Name = "richTextBoxBill";
            this.richTextBoxBill.Size = new System.Drawing.Size(302, 246);
            this.richTextBoxBill.TabIndex = 0;
            this.richTextBoxBill.Text = "";
            // 
            // roundedButtonClear
            // 
            this.roundedButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedButtonClear.BottomLeftRadius = 30;
            this.roundedButtonClear.BottomRightRadius = 30;
            this.roundedButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonClear.FlatAppearance.BorderSize = 0;
            this.roundedButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonClear.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonClear.ForeColor = System.Drawing.Color.White;
            this.roundedButtonClear.Location = new System.Drawing.Point(9, 569);
            this.roundedButtonClear.Name = "roundedButtonClear";
            this.roundedButtonClear.Size = new System.Drawing.Size(148, 25);
            this.roundedButtonClear.TabIndex = 44;
            this.roundedButtonClear.Text = "Clear";
            this.roundedButtonClear.TopLeftRadius = 30;
            this.roundedButtonClear.TopRightRadius = 30;
            this.roundedButtonClear.UseVisualStyleBackColor = false;
            this.roundedButtonClear.Click += new System.EventHandler(this.roundedButtonClear_Click);
            // 
            // roundedButtonPrint
            // 
            this.roundedButtonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedButtonPrint.BottomLeftRadius = 30;
            this.roundedButtonPrint.BottomRightRadius = 30;
            this.roundedButtonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonPrint.FlatAppearance.BorderSize = 0;
            this.roundedButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonPrint.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonPrint.ForeColor = System.Drawing.Color.White;
            this.roundedButtonPrint.Location = new System.Drawing.Point(163, 569);
            this.roundedButtonPrint.Name = "roundedButtonPrint";
            this.roundedButtonPrint.Size = new System.Drawing.Size(148, 25);
            this.roundedButtonPrint.TabIndex = 45;
            this.roundedButtonPrint.Text = "Print";
            this.roundedButtonPrint.TopLeftRadius = 30;
            this.roundedButtonPrint.TopRightRadius = 30;
            this.roundedButtonPrint.UseVisualStyleBackColor = false;
            this.roundedButtonPrint.Click += new System.EventHandler(this.roundedButtonPrint_Click);
            // 
            // roundedTextboxAmountPaid
            // 
            this.roundedTextboxAmountPaid.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxAmountPaid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxAmountPaid.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxAmountPaid.BorderRadius = 10;
            this.roundedTextboxAmountPaid.BorderWidth = 0;
            this.roundedTextboxAmountPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxAmountPaid.Location = new System.Drawing.Point(165, 221);
            this.roundedTextboxAmountPaid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.roundedTextboxAmountPaid.Name = "roundedTextboxAmountPaid";
            this.roundedTextboxAmountPaid.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxAmountPaid.PasswordChar = '\0';
            this.roundedTextboxAmountPaid.PlaceholderText = "Order";
            this.roundedTextboxAmountPaid.Size = new System.Drawing.Size(144, 32);
            this.roundedTextboxAmountPaid.TabIndex = 48;
            // 
            // roundedTextboxDiscountPercenatge
            // 
            this.roundedTextboxDiscountPercenatge.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxDiscountPercenatge.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxDiscountPercenatge.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxDiscountPercenatge.BorderRadius = 10;
            this.roundedTextboxDiscountPercenatge.BorderWidth = 0;
            this.roundedTextboxDiscountPercenatge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxDiscountPercenatge.Location = new System.Drawing.Point(165, 110);
            this.roundedTextboxDiscountPercenatge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.roundedTextboxDiscountPercenatge.Name = "roundedTextboxDiscountPercenatge";
            this.roundedTextboxDiscountPercenatge.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxDiscountPercenatge.PasswordChar = '\0';
            this.roundedTextboxDiscountPercenatge.PlaceholderText = "Discount (%)";
            this.roundedTextboxDiscountPercenatge.Size = new System.Drawing.Size(144, 32);
            this.roundedTextboxDiscountPercenatge.TabIndex = 49;
            // 
            // roundedTextboxCustomerCard
            // 
            this.roundedTextboxCustomerCard.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxCustomerCard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxCustomerCard.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxCustomerCard.BorderRadius = 10;
            this.roundedTextboxCustomerCard.BorderWidth = 0;
            this.roundedTextboxCustomerCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxCustomerCard.Location = new System.Drawing.Point(165, 73);
            this.roundedTextboxCustomerCard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.roundedTextboxCustomerCard.Name = "roundedTextboxCustomerCard";
            this.roundedTextboxCustomerCard.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxCustomerCard.PasswordChar = '\0';
            this.roundedTextboxCustomerCard.PlaceholderText = "Card Number";
            this.roundedTextboxCustomerCard.Size = new System.Drawing.Size(144, 32);
            this.roundedTextboxCustomerCard.TabIndex = 50;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundedPanel3.BottomLeftRadius = 40;
            this.roundedPanel3.BottomRightRadius = 40;
            this.roundedPanel3.Controls.Add(this.tableLayoutPanel5);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(40, 274);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(501, 373);
            this.roundedPanel3.TabIndex = 6;
            this.roundedPanel3.TopLeftRadius = 40;
            this.roundedPanel3.TopRightRadius = 40;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.Controls.Add(this.panel18, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(501, 373);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Controls.Add(this.dataGridViewItems);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 37);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(501, 298);
            this.panel18.TabIndex = 0;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.Item,
            this.Quantitiy,
            this.CustomerUnit,
            this.UnitPrice,
            this.ItemTotal,
            this.ItemProfit,
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
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewItems.RowTemplate.Height = 30;
            this.dataGridViewItems.Size = new System.Drawing.Size(501, 298);
            this.dataGridViewItems.TabIndex = 2;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 160;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantitiy
            // 
            this.Quantitiy.DataPropertyName = "Quantitiy";
            this.Quantitiy.HeaderText = "Quantitiy";
            this.Quantitiy.Name = "Quantitiy";
            this.Quantitiy.ReadOnly = true;
            // 
            // CustomerUnit
            // 
            this.CustomerUnit.DataPropertyName = "CustomerUnit";
            this.CustomerUnit.HeaderText = "Unit";
            this.CustomerUnit.Name = "CustomerUnit";
            this.CustomerUnit.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 150;
            // 
            // ItemTotal
            // 
            this.ItemTotal.DataPropertyName = "ItemTotal";
            this.ItemTotal.HeaderText = "Total";
            this.ItemTotal.Name = "ItemTotal";
            this.ItemTotal.ReadOnly = true;
            // 
            // ItemProfit
            // 
            this.ItemProfit.DataPropertyName = "ItemProfit";
            this.ItemProfit.HeaderText = "Profit";
            this.ItemProfit.Name = "ItemProfit";
            this.ItemProfit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.panel1);
            this.Name = "BillingForm";
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Components.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Label labelTotalPrice;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.RoundedTextbox roundedTextboxQuantitiy;
        private ComboBox comboBoxUnit;
        private ComboBox comboBoxItems;
        private Label labelBarcode;
        private Components.RoundedButton buttonCalculate;
        private Components.RoundedButton roundedButtonAdd;
        private Components.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelBalance;
        private Label label31;
        private Label label27;
        private Label labelTotal;
        private Label label23;
        private Label labelDiscount;
        private Label label19;
        private Label label15;
        private Label label11;
        private Label labelSubTotal;
        private Label label6;
        private Panel panel16;
        private RichTextBox richTextBoxBill;
        private Components.RoundedButton roundedButtonClear;
        private Components.RoundedButton roundedButtonPrint;
        private Components.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel18;
        private DataGridView dataGridViewItems;
        private Components.RoundedTextbox roundedTextboxAmountPaid;
        private Components.RoundedTextbox roundedTextboxDiscountPercenatge;
        private Components.RoundedTextbox roundedTextboxCustomerCard;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantitiy;
        private DataGridViewTextBoxColumn CustomerUnit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn ItemTotal;
        private DataGridViewTextBoxColumn ItemProfit;
        private DataGridViewImageColumn Delete;
    }
}