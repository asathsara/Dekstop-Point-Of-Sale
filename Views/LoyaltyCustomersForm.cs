using PointOfSale.Helpers;
using PointOfSale.Services;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class LoyaltyCustomersForm : Form
    {
        private readonly LoyaltyCustomerService _loyaltyCustomerService;

        public LoyaltyCustomersForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _loyaltyCustomerService = new LoyaltyCustomerService(connectionString);

            LoadLoyaltyCustomers();
        }

        private void LoadLoyaltyCustomers()
        {
            var customers = _loyaltyCustomerService.GetAllLoyaltyCustomers().ToList();
            dataGridViewLoyaltyCustomers.AutoGenerateColumns = false;
            dataGridViewLoyaltyCustomers.DataSource = customers;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim().ToLower();
            var filteredCustomers = _loyaltyCustomerService.SearchLoyaltyCustomers(searchTerm).ToList();
            dataGridViewLoyaltyCustomers.DataSource = filteredCustomers;
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewLoyaltyCustomers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridViewLoyaltyCustomers.Rows[e.RowIndex];
                string customerID = clickedRow.Cells["CustomerID"].Value?.ToString() ?? string.Empty;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(customerID))
                {
                    _loyaltyCustomerService.DeleteLoyaltyCustomer(customerID);
                    LoadLoyaltyCustomers();
                }
            }
        }

        private void dataGridViewItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridViewLoyaltyCustomers.Rows[e.RowIndex];

            string customerID = clickedRow.Cells["CustomerID"].Value?.ToString() ?? string.Empty;
            string customerName = clickedRow.Cells["CustomerName"].Value?.ToString() ?? string.Empty;
            string cardNumber = clickedRow.Cells["CustomerCardNumber"].Value?.ToString() ?? string.Empty;
            string points = clickedRow.Cells["Points"].Value?.ToString() ?? string.Empty;

            roundedTextboxID.Text = customerID;
            roundedTextboxCustomerName.Text = customerName;
            roundedTextboxCardNumber.Text = cardNumber;
            roundedTextboxPoints.Text = points;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            try
            {

                // Convert Points to integer safely
                if (!int.TryParse(roundedTextboxPoints.Text.Trim(), out int points))
                {
                    MessageBox.Show("Invalid points value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and process the data from the form
                var loyaltyCustomer = _loyaltyCustomerService.ValidateAndProcessData(
                    roundedTextboxID.Text.Trim(),
                    roundedTextboxCustomerName.Text.Trim(),
                    roundedTextboxCardNumber.Text.Trim(),
                    points,
                    UserData.EmployeeID.ToString()
                );

               

                _loyaltyCustomerService.AddLoyaltyCustomer(loyaltyCustomer);
                MessageBox.Show("Loyalty customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLoyaltyCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
