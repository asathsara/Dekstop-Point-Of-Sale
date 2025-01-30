using PointOfSale.Themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }




        private void AdminPanelForm_Load(object sender, System.EventArgs e)
        {
            // Open First child form when window loaded
            OpenChildForm(new DashboardForm());

            // Set the greeting when form loads
            labelGreeting.Text = GetGreeting();

        }


        private string GetGreeting()
        {

            int currentHour = DateTime.Now.Hour;
            string greeting;

            if (currentHour < 12)
            {
                greeting = "Good Morning";
            }
            else if (currentHour < 15)
            {
                greeting = "Good Afternoon";
            }
            else if (currentHour < 18)
            {
                greeting = "Good Evening";
            }
            else
            {
                greeting = " Good Night";
            }

            return greeting;
        }

        internal Form activeForm = null;

        private void OpenChildForm(Form childForm)

        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelConetentForm.Controls.Add(childForm);
            panelConetentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SetLabelColor(Label label)
        {
            label.ForeColor = ThemeColors.TextColor;
        }


        private void labelSignout_Click(object sender, EventArgs e)
        {

            // Sign out
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }
        private void labelDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());

            labelDashboard.BackColor = Color.FromArgb(104, 195, 255);
            panelImageOne.BackColor = Color.FromArgb(104, 195, 255);

            labelManagment.BackColor = Color.Transparent;
            panelImageTwo.BackColor = Color.Transparent;

            labelEmployee.BackColor = Color.Transparent;
            panelImageThree.BackColor = Color.Transparent;

            labelSuppliers.BackColor = Color.Transparent;
            panelImageFour.BackColor = Color.Transparent;
        }

        private void labelSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SuppliersForm());

            labelSuppliers.BackColor = Color.FromArgb(104, 195, 255);
            panelImageFour.BackColor = Color.FromArgb(104, 195, 255);

            labelDashboard.BackColor = Color.Transparent;
            panelImageOne.BackColor = Color.Transparent;

            labelManagment.BackColor = Color.Transparent;
            panelImageTwo.BackColor = Color.Transparent;

            labelEmployee.BackColor = Color.Transparent;
            panelImageThree.BackColor = Color.Transparent;
        }

        private void labelManagment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemManagementForm());

            labelManagment.BackColor = Color.FromArgb(104, 195, 255);
            panelImageTwo.BackColor = Color.FromArgb(104, 195, 255);

            labelDashboard.BackColor = Color.Transparent;
            panelImageOne.BackColor = Color.Transparent;

            labelEmployee.BackColor = Color.Transparent;
            panelImageThree.BackColor = Color.Transparent;

            labelSuppliers.BackColor = Color.Transparent;
            panelImageFour.BackColor = Color.Transparent;
        }

        private void labelEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());

            labelEmployee.BackColor = Color.FromArgb(104, 195, 255);
            panelImageThree.BackColor = Color.FromArgb(104, 195, 255);

            labelDashboard.BackColor = Color.Transparent;
            panelImageOne.BackColor = Color.Transparent;

            labelManagment.BackColor = Color.Transparent;
            panelImageTwo.BackColor = Color.Transparent;

            labelSuppliers.BackColor = Color.Transparent;
            panelImageFour.BackColor = Color.Transparent;
        }

        private void labelStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StoreForm());
        }
    }
}
