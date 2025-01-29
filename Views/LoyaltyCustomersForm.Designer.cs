using System.Windows.Forms;

namespace PointOfSale.Views
{
    partial class LoyaltyCustomersForm
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
            this.roundedPanel3 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubmit = new PointOfSale.Components.RoundedButton();
            this.roundedTextboxPoints = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextBoxCardNumber = new PointOfSale.Components.RoundedTextbox();
            this.roundedTtextboxCustomerName = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxID = new PointOfSale.Components.RoundedTextbox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.CardNumber,
            this.Points,
            this.EmployeeID,
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
            // 
            // ID
            // 
            this.ID.DataPropertyName = "EmployeeID";
            this.ID.HeaderText = " ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 200;
            // 
            // CardNumber
            // 
            this.CardNumber.DataPropertyName = "CustomerCardNumber";
            this.CardNumber.HeaderText = "Card Number";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            this.CardNumber.Width = 165;
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 190;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 150;
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
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSubmit, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxPoints, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextBoxCardNumber, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.roundedTtextboxCustomerName, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.roundedTextboxID, 1, 3);
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
            this.buttonSubmit.Location = new System.Drawing.Point(35, 417);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(251, 49);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TopLeftRadius = 40;
            this.buttonSubmit.TopRightRadius = 40;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // roundedTextboxPoints
            // 
            this.roundedTextboxPoints.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxPoints.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxPoints.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxPoints.BorderRadius = 10;
            this.roundedTextboxPoints.BorderWidth = 0;
            this.roundedTextboxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxPoints.Location = new System.Drawing.Point(37, 309);
            this.roundedTextboxPoints.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxPoints.Name = "roundedTextboxPoints";
            this.roundedTextboxPoints.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxPoints.PasswordChar = '\0';
            this.roundedTextboxPoints.PlaceholderText = "Points";
            this.roundedTextboxPoints.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxPoints.TabIndex = 11;
            // 
            // roundedTextBoxCardNumber
            // 
            this.roundedTextBoxCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxCardNumber.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextBoxCardNumber.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextBoxCardNumber.BorderRadius = 10;
            this.roundedTextBoxCardNumber.BorderWidth = 0;
            this.roundedTextBoxCardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextBoxCardNumber.Location = new System.Drawing.Point(37, 254);
            this.roundedTextBoxCardNumber.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextBoxCardNumber.Name = "roundedTextBoxCardNumber";
            this.roundedTextBoxCardNumber.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextBoxCardNumber.PasswordChar = '\0';
            this.roundedTextBoxCardNumber.PlaceholderText = "Card Number";
            this.roundedTextBoxCardNumber.Size = new System.Drawing.Size(247, 45);
            this.roundedTextBoxCardNumber.TabIndex = 12;
            // 
            // roundedTtextboxCustomerName
            // 
            this.roundedTtextboxCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.roundedTtextboxCustomerName.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTtextboxCustomerName.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTtextboxCustomerName.BorderRadius = 10;
            this.roundedTtextboxCustomerName.BorderWidth = 0;
            this.roundedTtextboxCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTtextboxCustomerName.Location = new System.Drawing.Point(37, 199);
            this.roundedTtextboxCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTtextboxCustomerName.Name = "roundedTtextboxCustomerName";
            this.roundedTtextboxCustomerName.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTtextboxCustomerName.PasswordChar = '\0';
            this.roundedTtextboxCustomerName.PlaceholderText = "Name";
            this.roundedTtextboxCustomerName.Size = new System.Drawing.Size(247, 45);
            this.roundedTtextboxCustomerName.TabIndex = 13;
            // 
            // roundedTextboxID
            // 
            this.roundedTextboxID.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxID.BorderRadius = 10;
            this.roundedTextboxID.BorderWidth = 0;
            this.roundedTextboxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxID.Location = new System.Drawing.Point(37, 144);
            this.roundedTextboxID.Margin = new System.Windows.Forms.Padding(5);
            this.roundedTextboxID.Name = "roundedTextboxID";
            this.roundedTextboxID.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxID.PasswordChar = '\0';
            this.roundedTextboxID.PlaceholderText = "ID";
            this.roundedTextboxID.Size = new System.Drawing.Size(247, 45);
            this.roundedTextboxID.TabIndex = 14;
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
            // 
            // LoyaltyCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.panel1);
            this.Name = "LoyaltyCustomersForm";
            this.Text = "Loyalty Customers ";
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
        private PictureBox pictureBox1;
        private Components.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridViewItems;
        private Components.RoundedTextbox roundedTextboxPoints;
        private Components.RoundedTextbox roundedTextBoxCardNumber;
        private Components.RoundedTextbox roundedTtextboxCustomerName;
        private Components.RoundedTextbox roundedTextboxID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CardNumber;
        private DataGridViewTextBoxColumn Points;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewImageColumn Delete;
        private TextBox textBoxSearch;
    }
}