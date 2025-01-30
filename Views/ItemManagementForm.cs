using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class ItemManagementForm : Form
    {
        private readonly ItemService _itemService;
        private IEnumerable<Supplier> suppliers;

        public ItemManagementForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _itemService = new ItemService(connectionString);

            // Set combo box units when the form is initialized
            SetComboBoxUnits();

            // Load Suppliers and Items when the form is initialized
            LoadItems();
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

        // Method to load items in the DataGridView
        private void LoadItems()
        {
            var items = _itemService.GetAllItems().ToList();
            dataGridViewItems.AutoGenerateColumns = false;
            dataGridViewItems.DataSource = items;
        }

        // Method to load suppliers in the ComboBox
        private void LoadSuppliers()
        {
            suppliers = _itemService.GetSuppliers().ToList();
            comboBoxSuppliers.Items.Clear();

            // Add each Supplier to the ComboBox
            foreach (var supplier in suppliers)
            {
                comboBoxSuppliers.Items.Add(supplier);
            }

            comboBoxSuppliers.DisplayMember = "SupplierName";  // Display the SupplierName
            comboBoxSuppliers.ValueMember = "SupplierID";  // Use SupplierID for the ValueMember
        }

        private void PopulateItemsComboBox(string supplierID)
        {

            var items = _itemService.GetItemsBySupplier(supplierID);

            // Clear the ComboBox before populating to avoid duplicate entries
            comboBoxItems.Items.Clear();

            // Add each SupplierComboBox item individually
            foreach (var item in items)
            {
                comboBoxItems.Items.Add(item);
            }
        }

        private string GetSupplierID()
        {
            if (comboBoxSuppliers.SelectedItem != null)
            {
                Supplier selectedItem = (Supplier)comboBoxSuppliers.SelectedItem;
                return selectedItem.SupplierID;

            }
            else
            {
                return String.Empty;
            }
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set Items
            string supplierID = GetSupplierID();

            PopulateItemsComboBox(supplierID);
        }

        // Button click handler for adding a new item
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Item
                {
                    ItemID = roundedTextboxID.Text.Trim(),
                    ItemName = comboBoxItems.SelectedItem.ToString(),
                    Barcode = int.TryParse(roundedTextboxBarcode.Text.Trim(), out int barcode) ? barcode : 0,
                    RetailQuantity = int.TryParse(roundedTextboxQuantity.Text.Trim(), out int quantity) ? quantity : 0,
                    RetailUnit = comboBoxUnit.SelectedIndex,
                    RetailUnitPrice = int.TryParse(roundedTextboxUnitPrice.Text.Trim(), out int unitPrice) ? unitPrice : 0,
                    Stock = int.TryParse(roundedTextboxStock.Text.Trim(), out int stock) ? stock : 0,
                    Description = roundedTextboxDescription.Text.Trim(),
                    AdminID = UserData.AdminID.ToString(),
                    SupplierID = (comboBoxSuppliers.SelectedItem as Supplier)?.SupplierID ?? string.Empty
                };

                _itemService.AddItem(item);
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TextBox event to search items by name or barcode
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim().ToLower();
            var filteredItems = _itemService.GetAllItems()
                .Where(i => i.ItemName.ToLower().Contains(searchTerm) || i.Barcode.ToString().Contains(searchTerm))
                .ToList();
            dataGridViewItems.DataSource = filteredItems;
        }

        // Handle delete button click in DataGridView
        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewItems.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridViewItems.Rows[e.RowIndex];
                string itemID = clickedRow.Cells["ItemID"].Value?.ToString() ?? string.Empty;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(itemID))
                {
                    _itemService.DeleteItem(itemID);
                    LoadItems();
                }
            }
        }

        // Handle row click to populate the form controls with item details
        private void dataGridViewItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridViewItems.Rows[e.RowIndex];

            // Extract values from the selected row
            string itemID = clickedRow.Cells["ItemID"].Value?.ToString() ?? string.Empty;
            string itemName = clickedRow.Cells["ItemName"].Value?.ToString() ?? string.Empty;
            string barcode = clickedRow.Cells["Barcode"].Value?.ToString() ?? string.Empty;
            string retailQuantity = clickedRow.Cells["RetailQuantity"].Value?.ToString() ?? string.Empty;
            string retailUnit = clickedRow.Cells["RetailUnit"].Value?.ToString() ?? string.Empty;
            string retailUnitPrice = clickedRow.Cells["RetailUnitPrice"].Value?.ToString() ?? string.Empty;
            string stock = clickedRow.Cells["Stock"].Value?.ToString() ?? string.Empty;
            string description = clickedRow.Cells["Description"].Value?.ToString() ?? string.Empty;
            string supplierID = clickedRow.Cells["SupplierID"].Value?.ToString() ?? string.Empty;

            // Populate the form controls with the selected row values
            roundedTextboxID.Text = itemID;
            roundedTextboxBarcode.Text = barcode;
            roundedTextboxQuantity.Text = retailQuantity;
            roundedTextboxUnitPrice.Text = retailUnitPrice;
            roundedTextboxStock.Text = stock;
            roundedTextboxDescription.Text = description;

            // Set the supplier ComboBox based on the selected item
            var supplier = suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
            comboBoxSuppliers.SelectedItem = supplier;

            // Set Item name
            comboBoxItems.SelectedItem = itemName;

            // Set the unit ComboBox based on the selected item
            comboBoxUnit.SelectedItem = retailUnit;  // Assuming unit names match with the RetailUnit
        }


    }
}
