using PointOfSale.Themes;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanelHome = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel1 = new PointOfSale.Components.RoundedPanel();
            this.tableLayoutPanelCard = new System.Windows.Forms.TableLayoutPanel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.roundedTextboxUsername = new PointOfSale.Components.RoundedTextbox();
            this.roundedTextboxPassword = new PointOfSale.Components.RoundedTextbox();
            this.roundButtonLogin = new PointOfSale.Components.RoundedButton();
            this.tableLayoutPanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelHome
            // 
            this.tableLayoutPanelHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelHome.ColumnCount = 2;
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelHome.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanelHome.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHome.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHome.Name = "tableLayoutPanelHome";
            this.tableLayoutPanelHome.RowCount = 1;
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHome.Size = new System.Drawing.Size(1060, 625);
            this.tableLayoutPanelHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.sale;
            this.pictureBox1.Location = new System.Drawing.Point(427, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.roundedPanel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 619);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BottomLeftRadius = 40;
            this.roundedPanel1.BottomRightRadius = 40;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanelCard);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(44, 95);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(328, 427);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.TopLeftRadius = 40;
            this.roundedPanel1.TopRightRadius = 40;
            // 
            // tableLayoutPanelCard
            // 
            this.tableLayoutPanelCard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanelCard.ColumnCount = 1;
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard.Controls.Add(this.labelLogin, 0, 0);
            this.tableLayoutPanelCard.Controls.Add(this.roundedTextboxUsername, 0, 2);
            this.tableLayoutPanelCard.Controls.Add(this.roundedTextboxPassword, 0, 4);
            this.tableLayoutPanelCard.Controls.Add(this.roundButtonLogin, 0, 6);
            this.tableLayoutPanelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCard.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCard.Name = "tableLayoutPanelCard";
            this.tableLayoutPanelCard.Padding = new System.Windows.Forms.Padding(34, 35, 34, 35);
            this.tableLayoutPanelCard.RowCount = 7;
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanelCard.Size = new System.Drawing.Size(328, 427);
            this.tableLayoutPanelCard.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogin.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelLogin.Location = new System.Drawing.Point(34, 35);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(260, 82);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedTextboxUsername
            // 
            this.roundedTextboxUsername.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxUsername.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxUsername.BorderColor = System.Drawing.Color.Transparent;
            this.roundedTextboxUsername.BorderRadius = 15;
            this.roundedTextboxUsername.BorderWidth = 0;
            this.roundedTextboxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxUsername.Location = new System.Drawing.Point(37, 155);
            this.roundedTextboxUsername.Name = "roundedTextboxUsername";
            this.roundedTextboxUsername.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxUsername.PasswordChar = '\0';
            this.roundedTextboxUsername.PlaceholderText = "Username";
            this.roundedTextboxUsername.Size = new System.Drawing.Size(254, 47);
            this.roundedTextboxUsername.TabIndex = 6;
            // 
            // roundedTextboxPassword
            // 
            this.roundedTextboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextboxPassword.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedTextboxPassword.BorderColor = System.Drawing.Color.Transparent;
            this.roundedTextboxPassword.BorderRadius = 15;
            this.roundedTextboxPassword.BorderWidth = 0;
            this.roundedTextboxPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.roundedTextboxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextboxPassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextboxPassword.Location = new System.Drawing.Point(37, 222);
            this.roundedTextboxPassword.Name = "roundedTextboxPassword";
            this.roundedTextboxPassword.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextboxPassword.PasswordChar = '•';
            this.roundedTextboxPassword.PlaceholderText = "Password";
            this.roundedTextboxPassword.Size = new System.Drawing.Size(254, 47);
            this.roundedTextboxPassword.TabIndex = 7;
            // 
            // roundButtonLogin
            // 
            this.roundButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.roundButtonLogin.BottomLeftRadius = 40;
            this.roundButtonLogin.BottomRightRadius = 40;
            this.roundButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButtonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonLogin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonLogin.ForeColor = System.Drawing.Color.White;
            this.roundButtonLogin.Location = new System.Drawing.Point(37, 310);
            this.roundButtonLogin.Name = "roundButtonLogin";
            this.roundButtonLogin.Size = new System.Drawing.Size(254, 47);
            this.roundButtonLogin.TabIndex = 8;
            this.roundButtonLogin.Text = "Log in";
            this.roundButtonLogin.TopLeftRadius = 40;
            this.roundButtonLogin.TopRightRadius = 40;
            this.roundButtonLogin.UseVisualStyleBackColor = false;
            this.roundButtonLogin.Click += new System.EventHandler(this.roundButtonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.tableLayoutPanelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelHome;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Components.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanelCard;
        private Label labelLogin;
        private Components.RoundedTextbox roundedTextboxUsername;
        private Components.RoundedTextbox roundedTextboxPassword;
        private Components.RoundedButton roundButtonLogin;
    }
}