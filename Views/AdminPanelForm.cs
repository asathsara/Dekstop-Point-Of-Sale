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
            SetActiveLabel(labelDashboard, panelImageOne);
        }

        private void labelSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SuppliersForm());
            SetActiveLabel(labelSuppliers, panelImageFour);
        }

        private void labelManagment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemManagementForm());
            SetActiveLabel(labelManagment, panelImageTwo);
        }

        private void labelEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
            SetActiveLabel(labelEmployee, panelImageThree);
        }

        private void labelStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StoreForm());
            SetActiveLabel(labelStore, panelImageFive);
        }

        private void labelBilling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillingForm());
            SetActiveLabel(labelBilling, panelImageSix);
        }

        private void labelCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoyaltyCustomersForm());
            SetActiveLabel(labelCustomers, panelImageSeven);
        }

        // Helper function to handle active label highlighting
        private void SetActiveLabel(Label activeLabel, Panel activePanel)
        {
            // Reset all labels and panels
            labelDashboard.BackColor = Color.Transparent;
            panelImageOne.BackColor = Color.Transparent;

            labelManagment.BackColor = Color.Transparent;
            panelImageTwo.BackColor = Color.Transparent;

            labelEmployee.BackColor = Color.Transparent;
            panelImageThree.BackColor = Color.Transparent;

            labelSuppliers.BackColor = Color.Transparent;
            panelImageFour.BackColor = Color.Transparent;

            labelStore.BackColor = Color.Transparent;
            panelImageFive.BackColor = Color.Transparent;

            labelBilling.BackColor = Color.Transparent;
            panelImageSix.BackColor = Color.Transparent;

            labelCustomers.BackColor = Color.Transparent;
            panelImageSeven.BackColor = Color.Transparent;

            // Set the active label and panel colors
            activeLabel.BackColor = Color.FromArgb(104, 195, 255);
            activePanel.BackColor = Color.FromArgb(104, 195, 255);
        }


        private void AdminPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
