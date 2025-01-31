using PointOfSale.Models;
using PointOfSale.Services;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class StoreForm : Form
    {
        private readonly StoreService _storeService;

        public StoreForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            _storeService = new StoreService(connectionString);

            LoadStoreData();
        }

        // Load store data into textboxes and DataGridView
        private void LoadStoreData()
        {
            Store store = _storeService.GetStore();

            if (store != null)
            {
                // Populate textboxes
                roundedTextboxID.Text = store.StoreID;
                roundedTextboxStoreName.Text = store.StoreName;
                roundedTextboxContactNumber.Text = store.ContactNumber;
                roundedTextboxAddress.Text = store.Address;

                // Populate DataGridView
                dataGridViewStore.Rows.Clear();
                dataGridViewStore.Rows.Add(store.StoreID, store.StoreName, store.ContactNumber, store.Address);
            }
        }

        // Handle form submit to update the store data
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string storeID = roundedTextboxID.Text.Trim();
            string storeName = roundedTextboxStoreName.Text.Trim();
            string contactNumber = roundedTextboxContactNumber.Text.Trim();
            string address = roundedTextboxAddress.Text.Trim();

            try
            {
                // Validate and process data
                Store store = _storeService.ValidateAndProcessData(storeID, storeName, contactNumber, address);

                // Update store data
                _storeService.UpdateStore(store);

                MessageBox.Show("Store updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload data to reflect the changes
                LoadStoreData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
