using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Services;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class SuppliersForm : Form
    {
        private readonly SupplierService _supplierService;

        public SuppliersForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _supplierService = new SupplierService(connectionString);

            // Set combo box units when the form is initialized
            SetComboBoxUnits();

            LoadSuppliers();
        }

        // Method to populate the combo box with units
        private void SetComboBoxUnits()
        {
            foreach (var unit in UserData.UnitsArray)
            {
                comboBoxUnit.Items.Add(unit);
            }
        }

        private void LoadSuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers().ToList();
            dataGridViewSuppliers.AutoGenerateColumns = false;
            dataGridViewSuppliers.DataSource = suppliers;
        }

       
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim().ToLower();
            var filteredSuppliers = _supplierService.GetAllSuppliers()
                .Where(s => s.SupplierName.ToLower().Contains(searchTerm) || s.ItemName.ToLower().Contains(searchTerm))
                .ToList();
            dataGridViewSuppliers.DataSource = filteredSuppliers;
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is from the Image Column
            if (e.ColumnIndex == dataGridViewSuppliers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = dataGridViewSuppliers.Rows[e.RowIndex];
                string supplierID = clickedRow.Cells["SupplierID"].Value?.ToString() ?? string.Empty;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(supplierID))
                {
                    // Delete Supplier from database
                    _supplierService.DeleteSupplier(supplierID);
                    LoadSuppliers();
                }
            }
        }

        private void dataGridViewItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridViewSuppliers.Rows[e.RowIndex];

            // Extract values from the selected row
            string supplierID = clickedRow.Cells["SupplierID"].Value?.ToString() ?? string.Empty;
            string supplierName = clickedRow.Cells["SupplierName"].Value?.ToString() ?? string.Empty;
            string itemName = clickedRow.Cells["ItemName"].Value?.ToString() ?? string.Empty;
            string contactNumber = clickedRow.Cells["ContactNumber"].Value?.ToString() ?? string.Empty;
            string wholeSaleQuantity = clickedRow.Cells["WholeSaleQuantity"].Value?.ToString() ?? string.Empty;
            string wholeSaleUnit = clickedRow.Cells["WholeSaleUnit"].Value?.ToString() ?? string.Empty;
            string wholeSaleUnitPrice = clickedRow.Cells["WholeSaleUnitPrice"].Value?.ToString() ?? string.Empty;

            // Fill controls with the selected row's values
            roundedTextboxID.Text = supplierID;
            roundedTextboxSupplier.Text = supplierName;
            roundedTextboxItem.Text = itemName;
            roundedTextboxContact.Text = contactNumber;
            roundedTextboxQuantity.Text = wholeSaleQuantity;
            comboBoxUnit.SelectedItem = wholeSaleUnit; // Assuming comboBoxUnit items match the wholeSaleUnit values
            roundedTextboxUnitPrice.Text = wholeSaleUnitPrice;
        }

        private void roundedButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = new Supplier
                {
                    SupplierID = roundedTextboxID.Text.Trim(),
                    SupplierName = roundedTextboxSupplier.Text.Trim(),
                    ItemName = roundedTextboxItem.Text.Trim(),
                    ContactNumber = int.TryParse(roundedTextboxContact.Text.Trim(), out int contactNumber) ? contactNumber : 0,
                    WholeSaleQuantity = int.TryParse(roundedTextboxQuantity.Text.Trim(), out int quantity) ? quantity : 0,
                    WholeSaleUnit = comboBoxUnit.SelectedIndex,
                    WholeSaleUnitPrice = int.TryParse(roundedTextboxUnitPrice.Text.Trim(), out int unitPrice) ? unitPrice : 0,
                    AdminID = UserData.AdminID.ToString()
                };

                _supplierService.AddSupplier(supplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = new Supplier
                {
                    SupplierID = roundedTextboxID.Text.Trim(),
                    SupplierName = roundedTextboxSupplier.Text.Trim(),
                    ItemName = roundedTextboxItem.Text.Trim(),
                    ContactNumber = int.TryParse(roundedTextboxContact.Text.Trim(), out int contactNumber) ? contactNumber : 0,
                    WholeSaleQuantity = int.TryParse(roundedTextboxQuantity.Text.Trim(), out int quantity) ? quantity : 0,
                    WholeSaleUnit = comboBoxUnit.SelectedIndex,
                    WholeSaleUnitPrice = int.TryParse(roundedTextboxUnitPrice.Text.Trim(), out int unitPrice) ? unitPrice : 0,
                    AdminID = UserData.AdminID.ToString()
                };

                _supplierService.AddSupplier(supplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
