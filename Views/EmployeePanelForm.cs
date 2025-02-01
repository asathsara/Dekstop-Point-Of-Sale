using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class EmployeePanelForm : Form
    {
        public EmployeePanelForm()
        {
            InitializeComponent();
        }

        private void labelBilling_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new BillingForm());
            SetActiveLabel(labelBilling, panelImageOne);
        }

        private void labelCustomers_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new LoyaltyCustomersForm());
            SetActiveLabel(labelCustomers, panelImageTwo);
        }

        // Helper function to handle active label highlighting
        private void SetActiveLabel(Label activeLabel, Panel activePanel)
        {
            // Reset all labels and panels
            labelBilling.BackColor = Color.Transparent;
            panelImageOne.BackColor = Color.Transparent;

            labelCustomers.BackColor = Color.Transparent;
            panelImageTwo.BackColor = Color.Transparent;

            // Set the active label and panel colors
            activeLabel.BackColor = Color.FromArgb(104, 195, 255);
            activePanel.BackColor = Color.FromArgb(104, 195, 255);
        }


        private void labelSignout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void EmployeePanelForm_Load(object sender, System.EventArgs e)
        {

            // Open First child form when window loaded
            OpenChildForm(new BillingForm());

            // Set the greeting when form loads
            labelGreeting.Text = GetGreeting();
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

        private void EmployeePanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
