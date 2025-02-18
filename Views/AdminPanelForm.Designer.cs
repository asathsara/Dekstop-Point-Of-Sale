﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PointOfSale.Views
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelConetentForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelImageFive = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.panelImageFour = new System.Windows.Forms.Panel();
            this.pictureBoxSuppliers = new System.Windows.Forms.PictureBox();
            this.panelImageThree = new System.Windows.Forms.Panel();
            this.pictureBoxEmployees = new System.Windows.Forms.PictureBox();
            this.panelImageTwo = new System.Windows.Forms.Panel();
            this.pictureBoxManagment = new System.Windows.Forms.PictureBox();
            this.labelSuppliers = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelManagment = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelImageOne = new System.Windows.Forms.Panel();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.labelBilling = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.panelImageSix = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelImageSeven = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSignout = new System.Windows.Forms.Label();
            this.pictureBoxSignout = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelImageFive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelImageFour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuppliers)).BeginInit();
            this.panelImageThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployees)).BeginInit();
            this.panelImageTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagment)).BeginInit();
            this.panelImageOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            this.panelImageSix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelImageSeven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignout)).BeginInit();
            this.roundedPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.labelGreeting, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelGreeting
            // 
            this.labelGreeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGreeting.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelGreeting.Location = new System.Drawing.Point(50, 0);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(280, 56);
            this.labelGreeting.TabIndex = 0;
            this.labelGreeting.Text = "Good Morning";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = global::PointOfSale.Properties.Resources.user;
            this.pictureBox6.Location = new System.Drawing.Point(882, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // panelConetentForm
            // 
            this.panelConetentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConetentForm.Location = new System.Drawing.Point(229, 56);
            this.panelConetentForm.Name = "panelConetentForm";
            this.panelConetentForm.Size = new System.Drawing.Size(955, 705);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panelImageFive, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelStore, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panelImageFour, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panelImageThree, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panelImageTwo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSuppliers, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelEmployee, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelManagment, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelDashboard, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelImageOne, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBilling, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelCustomers, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.panelImageSix, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.panelImageSeven, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 418);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panelImageFive
            // 
            this.panelImageFive.Controls.Add(this.pictureBox4);
            this.panelImageFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageFive.Location = new System.Drawing.Point(0, 200);
            this.panelImageFive.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageFive.Name = "panelImageFive";
            this.panelImageFive.Size = new System.Drawing.Size(46, 50);
            this.panelImageFive.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::PointOfSale.Properties.Resources.store;
            this.pictureBox4.Location = new System.Drawing.Point(13, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // labelStore
            // 
            this.labelStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStore.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelStore.Location = new System.Drawing.Point(46, 200);
            this.labelStore.Margin = new System.Windows.Forms.Padding(0);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(184, 50);
            this.labelStore.TabIndex = 15;
            this.labelStore.Text = "Store";
            this.labelStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStore.Click += new System.EventHandler(this.labelStore_Click);
            // 
            // panelImageFour
            // 
            this.panelImageFour.Controls.Add(this.pictureBoxSuppliers);
            this.panelImageFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageFour.Location = new System.Drawing.Point(0, 150);
            this.panelImageFour.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageFour.Name = "panelImageFour";
            this.panelImageFour.Size = new System.Drawing.Size(46, 50);
            this.panelImageFour.TabIndex = 13;
            // 
            // pictureBoxSuppliers
            // 
            this.pictureBoxSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSuppliers.Image = global::PointOfSale.Properties.Resources.suppliers;
            this.pictureBoxSuppliers.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxSuppliers.Name = "pictureBoxSuppliers";
            this.pictureBoxSuppliers.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSuppliers.TabIndex = 2;
            this.pictureBoxSuppliers.TabStop = false;
            // 
            // panelImageThree
            // 
            this.panelImageThree.Controls.Add(this.pictureBoxEmployees);
            this.panelImageThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageThree.Location = new System.Drawing.Point(0, 100);
            this.panelImageThree.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageThree.Name = "panelImageThree";
            this.panelImageThree.Size = new System.Drawing.Size(46, 50);
            this.panelImageThree.TabIndex = 12;
            // 
            // pictureBoxEmployees
            // 
            this.pictureBoxEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxEmployees.Image = global::PointOfSale.Properties.Resources.employee;
            this.pictureBoxEmployees.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxEmployees.Name = "pictureBoxEmployees";
            this.pictureBoxEmployees.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxEmployees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmployees.TabIndex = 2;
            this.pictureBoxEmployees.TabStop = false;
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
            // pictureBoxManagment
            // 
            this.pictureBoxManagment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxManagment.Image = global::PointOfSale.Properties.Resources.managment;
            this.pictureBoxManagment.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxManagment.Name = "pictureBoxManagment";
            this.pictureBoxManagment.Size = new System.Drawing.Size(21, 22);
            this.pictureBoxManagment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagment.TabIndex = 2;
            this.pictureBoxManagment.TabStop = false;
            // 
            // labelSuppliers
            // 
            this.labelSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuppliers.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelSuppliers.Location = new System.Drawing.Point(46, 150);
            this.labelSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.labelSuppliers.Name = "labelSuppliers";
            this.labelSuppliers.Size = new System.Drawing.Size(184, 50);
            this.labelSuppliers.TabIndex = 9;
            this.labelSuppliers.Text = "Suppliers";
            this.labelSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSuppliers.Click += new System.EventHandler(this.labelSuppliers_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmployee.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelEmployee.Location = new System.Drawing.Point(46, 100);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(184, 50);
            this.labelEmployee.TabIndex = 7;
            this.labelEmployee.Text = "Employees";
            this.labelEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmployee.Click += new System.EventHandler(this.labelEmployee_Click);
            // 
            // labelManagment
            // 
            this.labelManagment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelManagment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManagment.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelManagment.Location = new System.Drawing.Point(46, 50);
            this.labelManagment.Margin = new System.Windows.Forms.Padding(0);
            this.labelManagment.Name = "labelManagment";
            this.labelManagment.Size = new System.Drawing.Size(184, 50);
            this.labelManagment.TabIndex = 3;
            this.labelManagment.Text = "Item Managment";
            this.labelManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelManagment.Click += new System.EventHandler(this.labelManagment_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.labelDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDashboard.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelDashboard.Location = new System.Drawing.Point(46, 0);
            this.labelDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(184, 50);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
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
            // labelBilling
            // 
            this.labelBilling.BackColor = System.Drawing.Color.Transparent;
            this.labelBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBilling.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelBilling.Location = new System.Drawing.Point(46, 316);
            this.labelBilling.Margin = new System.Windows.Forms.Padding(0);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(184, 50);
            this.labelBilling.TabIndex = 19;
            this.labelBilling.Text = "Billing";
            this.labelBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBilling.Click += new System.EventHandler(this.labelBilling_Click);
            // 
            // labelCustomers
            // 
            this.labelCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomers.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelCustomers.Location = new System.Drawing.Point(49, 366);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(178, 52);
            this.labelCustomers.TabIndex = 20;
            this.labelCustomers.Text = "Customers";
            this.labelCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCustomers.Click += new System.EventHandler(this.labelCustomers_Click);
            // 
            // panelImageSix
            // 
            this.panelImageSix.Controls.Add(this.pictureBox2);
            this.panelImageSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageSix.Location = new System.Drawing.Point(0, 316);
            this.panelImageSix.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageSix.Name = "panelImageSix";
            this.panelImageSix.Size = new System.Drawing.Size(46, 50);
            this.panelImageSix.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PointOfSale.Properties.Resources.dashboard;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelImageSeven
            // 
            this.panelImageSeven.Controls.Add(this.pictureBox3);
            this.panelImageSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageSeven.Location = new System.Drawing.Point(0, 366);
            this.panelImageSeven.Margin = new System.Windows.Forms.Padding(0);
            this.panelImageSeven.Name = "panelImageSeven";
            this.panelImageSeven.Size = new System.Drawing.Size(46, 52);
            this.panelImageSeven.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::PointOfSale.Properties.Resources.employee;
            this.pictureBox3.Location = new System.Drawing.Point(13, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 711);
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
            this.labelSignout.Click += new System.EventHandler(this.labelSignout_Click);
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
            // panelNavigation
            // 
            this.panelNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(229, 761);
            this.panelNavigation.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.BottomLeftRadius = 0;
            this.roundedPanel1.BottomRightRadius = 40;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel3);
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(230, 761);
            this.roundedPanel1.TabIndex = 9;
            this.roundedPanel1.TopLeftRadius = 0;
            this.roundedPanel1.TopRightRadius = 40;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panelConetentForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanelForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelImageFive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelImageFour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuppliers)).EndInit();
            this.panelImageThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployees)).EndInit();
            this.panelImageTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagment)).EndInit();
            this.panelImageOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            this.panelImageSix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelImageSeven.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignout)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelGreeting;
        private Panel panelConetentForm;
        private PictureBox pictureBox6;
        private Panel panel1;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelStore;
        private Panel panelImageFour;
        private PictureBox pictureBoxSuppliers;
        private Panel panelImageThree;
        private PictureBox pictureBoxEmployees;
        private Panel panelImageTwo;
        private PictureBox pictureBoxManagment;
        private Label labelSuppliers;
        private Label labelEmployee;
        private Label labelManagment;
        private Label labelDashboard;
        private Panel panelImageOne;
        private PictureBox pictureBoxDashboard;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelSignout;
        private PictureBox pictureBoxSignout;
        private Panel panelNavigation;
        private Components.RoundedPanel roundedPanel1;
        private Label labelBilling;
        private Panel panelImageFive;
        private PictureBox pictureBox4;
        private Label labelCustomers;
        private Panel panelImageSix;
        private PictureBox pictureBox2;
        private Panel panelImageSeven;
        private PictureBox pictureBox3;
    }
}