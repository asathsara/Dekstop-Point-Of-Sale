using PointOfSale.Services;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeService _employeeService;

        public EmployeeForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _employeeService = new EmployeeService(connectionString);

            LoadEmployees();
        }


        private void LoadEmployees()
        {
            var employees = _employeeService.GetAllEmployees().ToList();
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.DataSource = employees;
        }

       

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim().ToLower();
            var filteredEmployees = _employeeService.SearchEmployees(searchTerm).ToList();
            dataGridViewEmployees.DataSource = filteredEmployees;
        }

        // Handle delete button click in DataGridView
        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewEmployees.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridViewEmployees.Rows[e.RowIndex];
                string employeeID = clickedRow.Cells["EmployeeID"].Value?.ToString() ?? string.Empty;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(employeeID))
                {
                    _employeeService.DeleteEmployee(employeeID);
                    LoadEmployees();
                }
            }
        }

        // Handle row click to populate the form controls with employee details
        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridViewEmployees.Rows[e.RowIndex];

            // Extract values from the selected row
            string employeeID = clickedRow.Cells["EmployeeID"].Value?.ToString() ?? string.Empty;
            string username = clickedRow.Cells["Username"].Value?.ToString() ?? string.Empty;
            string password = clickedRow.Cells["Password"].Value?.ToString() ?? string.Empty;
            string name = clickedRow.Cells["EmployeeName"].Value?.ToString() ?? string.Empty;

            // Populate the form controls with the selected row values
            roundedTextboxID.Text = employeeID;
            roundedTextboxUsername.Text = username;
            roundedTextboxPassword.Text = password;
            roundedTextboxName.Text = name;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = _employeeService.ValidateAndProcessData(
                    roundedTextboxID.Text.Trim(),
                    roundedTextboxUsername.Text.Trim(),
                    roundedTextboxPassword.Text.Trim(),
                    roundedTextboxName.Text.Trim()
                );

                _employeeService.AddEmployee(employee);

                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
