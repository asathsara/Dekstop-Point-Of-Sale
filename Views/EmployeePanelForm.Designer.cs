using System.Windows.Forms;

namespace PointOfSale.Views
{
    partial class EmployeePanelForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelConetentForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelImageFour = new System.Windows.Forms.Panel();
            this.panelImageThree = new System.Windows.Forms.Panel();
            this.panelImageTwo = new System.Windows.Forms.Panel();
            this.labelBilling = new System.Windows.Forms.Label();
            this.panelImageOne = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSignout = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.pictureBoxManagment = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSignout = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelImageTwo.SuspendLayout();
            this.panelImageOne.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelStatus.Location = new System.Drawing.Point(44, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(243, 56);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Good Morning";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelConetentForm
            // 
            this.panelConetentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConetentForm.Location = new System.Drawing.Point(229, 56);
            this.panelConetentForm.Name = "panelConetentForm";
            this.panelConetentForm.Size = new System.Drawing.Size(831, 569);
            this.panelConetentForm.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 189);
            this.panel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 102);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(226, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Point Of Sale";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panelImageFour, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panelImageThree, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panelImageTwo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCustomers, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBilling, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelImageOne, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 250);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panelImageFour
            // 
            this.panelImageFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageFour.Location = new System.Drawing.Point(0, 150);
            this.panelImageFour.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageFour.Name = "panelImageFour";
            this.panelImageFour.Size = new System.Drawing.Size(46, 50);
            this.panelImageFour.TabIndex = 13;
            // 
            // panelImageThree
            // 
            this.panelImageThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageThree.Location = new System.Drawing.Point(0, 100);
            this.panelImageThree.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageThree.Name = "panelImageThree";
            this.panelImageThree.Size = new System.Drawing.Size(46, 50);
            this.panelImageThree.TabIndex = 12;
            // 
            // panelImageTwo
            // 
            this.panelImageTwo.Controls.Add(this.pictureBoxManagment);
            this.panelImageTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageTwo.Location = new System.Drawing.Point(0, 50);
            this.panelImageTwo.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageTwo.Name = "panelImageTwo";
            this.panelImageTwo.Size = new System.Drawing.Size(46, 50);
            this.panelImageTwo.TabIndex = 11;
            // 
            // labelBilling
            // 
            this.labelBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.labelBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBilling.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelBilling.Location = new System.Drawing.Point(46, 0);
            this.labelBilling.Margin = new System.Windows.Forms.Padding(0);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(184, 50);
            this.labelBilling.TabIndex = 0;
            this.labelBilling.Text = "Billing";
            this.labelBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelImageOne
            // 
            this.panelImageOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.panelImageOne.Controls.Add(this.pictureBoxDashboard);
            this.panelImageOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageOne.Location = new System.Drawing.Point(0, 0);
            this.panelImageOne.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageOne.Name = "panelImageOne";
            this.panelImageOne.Size = new System.Drawing.Size(46, 50);
            this.panelImageOne.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.labelSignout, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxSignout, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 575);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 50);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // labelSignout
            // 
            this.labelSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSignout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelSignout.Location = new System.Drawing.Point(49, 0);
            this.labelSignout.Name = "labelSignout";
            this.labelSignout.Size = new System.Drawing.Size(178, 35);
            this.labelSignout.TabIndex = 0;
            this.labelSignout.Text = "Sign out";
            this.labelSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(229, 625);
            this.panelNavigation.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.BottomLeftRadius = 0;
            this.roundedPanel1.BottomRightRadius = 40;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel3);
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(230, 625);
            this.roundedPanel1.TabIndex = 9;
            this.roundedPanel1.TopLeftRadius = 0;
            this.roundedPanel1.TopRightRadius = 40;
            // 
            // pictureBoxManagment
            // 
            this.pictureBoxManagment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxManagment.Image = global::PointOfSale.Properties.Resources.employee;
            this.pictureBoxManagment.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxManagment.Name = "pictureBoxManagment";
            this.pictureBoxManagment.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxManagment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagment.TabIndex = 2;
            this.pictureBoxManagment.TabStop = false;
            // 
            // pictureBoxDashboard
            // 
            this.pictureBoxDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDashboard.Image = global::PointOfSale.Properties.Resources.dashboard;
            this.pictureBoxDashboard.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxDashboard.Name = "pictureBoxDashboard";
            this.pictureBoxDashboard.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDashboard.TabIndex = 2;
            this.pictureBoxDashboard.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.PointOfSale;
            this.pictureBox1.Location = new System.Drawing.Point(61, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSignout
            // 
            this.pictureBoxSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSignout.Image = global::PointOfSale.Properties.Resources.signout;
            this.pictureBoxSignout.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxSignout.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBoxSignout.Name = "pictureBoxSignout";
            this.pictureBoxSignout.Size = new System.Drawing.Size(30, 19);
            this.pictureBoxSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSignout.TabIndex = 1;
            this.pictureBoxSignout.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = global::PointOfSale.Properties.Resources.user;
            this.pictureBox6.Location = new System.Drawing.Point(764, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // labelCustomers
            // 
            this.labelCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomers.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelCustomers.Location = new System.Drawing.Point(49, 50);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(178, 50);
            this.labelCustomers.TabIndex = 3;
            this.labelCustomers.Text = "Customers";
            this.labelCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panelConetentForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelNavigation);
            this.Name = "EmployeePanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelImageTwo.ResumeLayout(false);
            this.panelImageOne.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelStatus;
        private Panel panelConetentForm;
        private PictureBox pictureBox6;
        private Panel panel1;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelImageFour;
        private Panel panelImageThree;
        private Panel panelImageTwo;
        private Label labelBilling;
        private Panel panelImageOne;
        private PictureBox pictureBoxDashboard;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelSignout;
        private PictureBox pictureBoxSignout;
        private Panel panelNavigation;
        private Components.RoundedPanel roundedPanel1;
        private PictureBox pictureBoxManagment;
        private Label labelCustomers;
    }
}