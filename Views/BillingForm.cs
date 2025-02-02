using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Services;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class BillingForm : Form
    {
        private readonly BillingService _billingService;
        private ItemData _currentItemData;
        private BindingList<BillItem> _billItems;

        // Fields for local variables
        private int quantity;
        private string unit;
        private float totalPrice;
        private float subTotal = 0;
        private float totalProfit = 0;
        private float total = 0;
        private float totalDiscount;
        private int customerCardNumber;
        private float discountPercentage;
        private float amountPaid;
        private float balance;

        private DateTime date;
        private TimeSpan time;

        private string billTemplate;

        public BillingForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;



            _billItems = new BindingList<BillItem>();
            _billingService = new BillingService(connectionString);

            roundedTextboxDiscountPercenatge.EnterKeyPressed += Discount_EnterKeyPressed;
            roundedTextboxAmountPaid.EnterKeyPressed += AmountPaid_EnterKeyPressed;

            // Set combo box units when the form is initialized
            SetComboBoxUnits();
            SetComboBoxItems();
        }



        // Method to populate the combo box with units
        private void SetComboBoxUnits()
        {
            foreach (var unit in UserData.UnitsArray)
            {
                comboBoxUnit.Items.Add(unit);
            }
        }

        private void SetComboBoxItems()
        {
            // Get the items list from the service
            var items = _billingService.GetItemsForComboBox();

            // Bind the ComboBox directly to the items list
            comboBoxItems.DataSource = items;


            comboBoxItems.DisplayMember = "ItemName";
            comboBoxItems.ValueMember = "ItemID";
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedItem = comboBoxItems.SelectedItem as Item;
            if (selectedItem != null)
            {
                LoadItemData(selectedItem.ItemID, selectedItem.ItemName);
            }
        }

        private void LoadItemData(string itemId, string itemName)
        {
            _currentItemData = _billingService.GetItemData(itemId, itemName);

            if (_currentItemData != null)
            {
                labelBarcode.Text = _currentItemData.Barcode.ToString();
            }
        }

        private void CalculatePrice()
        {
            try
            {
                // Parse quantity from user input
                if (!int.TryParse(roundedTextboxQuantitiy.Text.Trim(), out quantity))
                {
                    MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate unit selection
                unit = comboBoxUnit.SelectedItem?.ToString() ?? "One";

                // Call BillingService to calculate total price
                totalPrice = _billingService.CalculateTotalPrice(quantity, unit, _currentItemData);

                // Display total price
                labelTotalPrice.Text = $"Rs. {totalPrice:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalculate_Click(object sender, System.EventArgs e)
        {
            CalculatePrice();
        }

        private float GetItemProfit()
        {
            return ProfitCalculator.CalculateProfit(_currentItemData);
        }

        private void roundedButtonAdd_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentItemData.ItemName) &&
                quantity > 0 &&
                !string.IsNullOrEmpty(unit) &&
                _currentItemData.RetailUnitPrice > 0 &&
                totalPrice > 0)
            {
                var itemProfit = GetItemProfit() * quantity;
                var billItem = new BillItem
                {
                    ItemID = _currentItemData.ItemID,
                    ItemName = _currentItemData.ItemName,
                    CustomerQuantity = quantity,
                    CustomerUnit = comboBoxUnit.SelectedIndex == -1 ? 0 : comboBoxUnit.SelectedIndex,
                    UnitPrice = _currentItemData.RetailUnitPrice,
                    Total = totalPrice,
                    ItemProfit = itemProfit,
                };

                _billItems.Add(billItem);

                // Calculate sub total when add button clicked
                subTotal += billItem.Total;
                totalProfit += itemProfit;

                SetValuesToGridView();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty or have invalid values", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetValuesToGridView()
        {
            // Clear the dataGridView before populating
            dataGridViewItems.Rows.Clear();

            int index = 1;

            foreach (var billItem in _billItems)
            {
                dataGridViewItems.Rows.Add(
                    index,
                    billItem.ItemName,
                    billItem.CustomerQuantity,
                    UserData.UnitsArray[billItem.CustomerUnit],
                    billItem.UnitPrice,
                    billItem.Total,
                    billItem.ItemProfit

                );
                index++;
            }

            labelSubTotal.Text = $"Rs. {subTotal:F2}";
        }

        private void roundedButtonClear_Click(object sender, System.EventArgs e)
        {
            //Clear all input fields
            roundedTextboxCustomerCard.Text = "";
            roundedTextboxDiscountPercenatge.Text = "";
            roundedTextboxAmountPaid.Text = "";
            roundedTextboxQuantitiy.Text = "";

            // Reset labels
            labelBarcode.Text = "";
            labelDiscount.Text = "Rs. 0.00";
            labelTotal.Text = "Rs. 0.00";
            labelBalance.Text = "Rs. 0.00";

            // Clear the item selection
            comboBoxItems.SelectedIndex = -1;
            comboBoxUnit.SelectedIndex = -1;

            // Clear the bill items list
            _billItems.Clear();
            SetValuesToGridView();

            // Reset bill variables
            subTotal = 0;
            totalProfit = 0;
            total = 0;
            amountPaid = 0;
            balance = 0;
            discountPercentage = 0;
            customerCardNumber = 0;

            // Clear bill template
            billTemplate = "";
            richTextBoxBill.Clear();

            // Reset the current item data
            _currentItemData = null;
        }

        private void roundedButtonPrint_Click(object sender, System.EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to set customer points and save the bill as an image?",
                                                  "Confirm Action",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Create Bill object
                    Bill bill = new Bill
                    {
                        Total = total,
                        TotalProfit = totalProfit,
                        DiscountPercentage = discountPercentage,
                        CustomerPoints = _billingService.GetCustomerPointsDiscount(),
                        TotalDiscount = (float)_billingService.GetDiscount(),
                        Date = date,
                        Time = time,
                        EmployeeID = UserData.EmployeeID,
                        CustomerCardNumber = customerCardNumber.ToString(),
                        StoreID = _billingService.GetStoreID()
                    };

                    int remainCustomerPoints = _billingService.GetCustomerPoints();

                    int billID = _billingService.ProcessBill(bill, billTemplate, _billItems, remainCustomerPoints);

                    MessageBox.Show($"Bill {billID} saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Discount_EnterKeyPressed(object sender, EventArgs e)
        {
            // Parse customer card number and discount percentage
            customerCardNumber = int.TryParse(roundedTextboxCustomerCard.Text.Trim(), out customerCardNumber) ? customerCardNumber : 0;

            discountPercentage = float.TryParse(roundedTextboxDiscountPercenatge.Text.Trim(), out discountPercentage) ? discountPercentage : 0f;

            // Calculate total price after loyalty points and discount
            total = _billingService.CalculateTotalWithDiscountAndLoyalty(customerCardNumber, subTotal, discountPercentage);

            totalDiscount = subTotal - total;

            // Update UI with calculated discount and total
            labelDiscount.Text = $"Rs. {totalDiscount.ToString("F2")}";
            labelTotal.Text = $"Rs. {total.ToString("F2")}";


        }


        private String GenerateBill()
        {

            string bill = "";

            date = DateTime.Now;
            time = DateTime.Now.TimeOfDay;
            try
            {
                // Create the BillData object
                var billData = new BillData
                {
                    Date = date,
                    Time = time,
                    BillItems = _billItems.ToList(),
                    SubTotal = subTotal,
                    Discount = totalDiscount,
                    Total = total,
                    AmountPaid = float.Parse(roundedTextboxAmountPaid.Text.Trim()),
                    Balance = balance,
                    CustomerCardNumber = customerCardNumber,
                    CustomerPoints = _billingService.GetCustomerPoints(),
                    EmployeeName = _billingService.GetEmployeeName(UserData.EmployeeID)
                };

                // Generate the bill using the BillData object
                bill = _billingService.GenerateBill(billData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bill;
        }


        private void AmountPaid_EnterKeyPressed(object sender, EventArgs e)
        {
            amountPaid = float.TryParse(roundedTextboxAmountPaid.Text.ToString(), out amountPaid) ? amountPaid : 0.0f;

            balance = amountPaid - total;

            labelBalance.Text = $"Rs. {balance.ToString("F2")}";

            billTemplate = GenerateBill();

            richTextBoxBill.Text = billTemplate;


        }


        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is from the Image Column 
            if (e.ColumnIndex == dataGridViewItems.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = dataGridViewItems.Rows[e.RowIndex];

                // Retrieve the value of another cell in the same row
                float itemTotal = float.TryParse(clickedRow.Cells["ItemTotal"].Value.ToString(), out itemTotal) ? itemTotal : 0f;
                float itemProfit = float.TryParse(clickedRow.Cells["ItemProfit"].Value.ToString(), out itemProfit) ? itemProfit : 0f;

                // Ask for confirmation before removing the row
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                // If the user clicked 'Yes', proceed with removal
                if (result == DialogResult.Yes)
                {
                    subTotal -= itemTotal;
                    totalProfit -= itemProfit;


                    // Remove the item from the list and update the GridView
                    _billItems.RemoveAt(e.RowIndex);
                    SetValuesToGridView();
                }

            }
        }
    }
}
