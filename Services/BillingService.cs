using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace PointOfSale.Services
{
    public class BillingService
    {
        private readonly BillingRepository _billingRepository;

        private const float LOYALTY_CUSTOMER_GET_PERCENTAGE = 10f;
        private const float LOYALTY_CUSTOMER_SET_PERCENTAGE = 3f;
        private int customerPoints;
        private int customerPointsDiscount = 0;
        private float discount = 0;
        private Store store;
        private static readonly string SavePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Prints");


        public BillingService(string connectionString)
        {
            _billingRepository = new BillingRepository(connectionString);

            // Ensure the directory exists before using it
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
        }




        public string GetEmployeeName(string employeeID)
        {
            return _billingRepository.GetEmployeeName(employeeID);
        }


        public ItemData GetItemData(string itemID, string itemName)
        {
            return _billingRepository.GetItem(itemID, itemName);
        }



        public Store GetStore()
        {
            return _billingRepository.GetStore();
        }



        public void InsertBillItem(BillItem billItem, int billID)
        {
            _billingRepository.InsertBillItem(billItem, billID);
        }

        public int GetCustomerPointsDiscount()
        {
            return customerPointsDiscount;
        }

        public int GetCustomerPoints()
        {
            return customerPoints;
        }

        public float GetDiscount()
        {
            return discount;
        }

        public String GetStoreID()
        {
            return store.StoreID;
        }


        public float CalculateTotalWithDiscountAndLoyalty(int customerCardNumber, float subTotal, float discountPercentage)
        {
            float total = subTotal;
            customerPoints = 0;
            customerPointsDiscount = 0;
            discount = 0;

            if (discountPercentage > 0)
            {
                discount = total * discountPercentage / 100;
                total -= discount;
            }

            // Handle loyalty points and discount
            if (customerCardNumber > 0)
            {
                customerPoints = GetLoyaltyCustomerPoints(customerCardNumber.ToString());
                customerPointsDiscount = (int)CalculateLoyaltyDiscount(subTotal, ref customerPoints);
                total -= customerPointsDiscount;

                // gain some customer points
                customerPoints += (int)(total / 100 * LOYALTY_CUSTOMER_SET_PERCENTAGE);
            }

            // Return final total after applying loyalty and discount
            return total;
        }

        private float CalculateLoyaltyDiscount(float subTotal, ref int customerPoints)
        {
            float loyaltyPointsDiscount = 0;
            float subPoints = subTotal / 100 * LOYALTY_CUSTOMER_GET_PERCENTAGE;

            if (customerPoints >= subPoints)
            {
                loyaltyPointsDiscount = subPoints;
                customerPoints -= (int)subPoints;
            }
            else
            {
                loyaltyPointsDiscount = customerPoints;
                customerPoints = 0;
            }



            return loyaltyPointsDiscount;
        }



        public int GetLoyaltyCustomerPoints(string cardNumber)
        {
            return _billingRepository.GetLoyaltyCustomerPoints(cardNumber);
        }



        public int ProcessBill(Bill bill, string billText, BindingList<BillItem> billItems, int remainCustomerPoints)
        {
            if (bill.Total == 0.0f)
                throw new InvalidOperationException("Total amount cannot be zero.");

            // Insert bill and get Bill ID
            int billID = InsertBill(bill);

            // Update customer loyalty points
            UpdateLoyaltyCustomerPoints(bill.CustomerCardNumber, remainCustomerPoints);

            // Save bill as an image
            string filePath = $"{SavePath}\\Bill_{billID}.png";
            SaveBillAsImage(billText, filePath);

            foreach (BillItem billItem in billItems)
            {
                // Insert bill items
                InsertBillItem(billItem, billID);
            }

            return billID;
        }

        public int InsertBill(Bill bill)
        {
            return _billingRepository.InsertBill(bill);
        }

        private void UpdateLoyaltyCustomerPoints(string cardNumber, int customerPoints)
        {
            _billingRepository.UpdateLoyaltyCustomerPoints(cardNumber, customerPoints);
        }

        private void SaveBillAsImage(string billText, string filePath)
        {
            try
            {
                Font font = new Font("Arial", 12, FontStyle.Regular);
                Color textColor = Color.Black;
                Color backColor = Color.White;

                using (Bitmap dummyBitmap = new Bitmap(1, 1))
                using (Graphics drawing = Graphics.FromImage(dummyBitmap))
                {
                    SizeF textSize = drawing.MeasureString(billText, font);
                    int padding = 10;
                    int imgWidth = (int)textSize.Width + padding * 2;
                    int imgHeight = (int)textSize.Height + padding * 2;

                    using (Bitmap img = new Bitmap(imgWidth, imgHeight))
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.Clear(backColor);
                        using (Brush textBrush = new SolidBrush(textColor))
                        {
                            g.DrawString(billText, font, textBrush, padding, padding);
                            img.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving bill as image: {ex.Message}");
            }
        }


        public IEnumerable<Item> GetItemsForComboBox()
        {
            return _billingRepository.getItemsForComboBox();
        }


        public float CalculateTotalPrice(int customerQuantity, string selectedUnit, ItemData itemData)
        {
            // Validate input
            if (customerQuantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            if (itemData == null)
            {
                throw new ArgumentException("Item data is missing. Please search for an item first.");
            }

            // Ensure units are compatible
            if (!UnitConverter.AreUnitsCompatible(selectedUnit, UserData.UnitsArray[(int)itemData.RetailUnit]))
            {
                throw new ArgumentException("Selected unit is not compatible with the item's unit.");
            }

            // Convert quantities to base unit
            float baseQuantity = UnitConverter.ConvertToBaseUnit(customerQuantity, selectedUnit);
            float baseItemQuantity = UnitConverter.ConvertToBaseUnit(1, UserData.UnitsArray[(int)itemData.RetailUnit]);

            // Calculate total price
            float unitPrice = itemData.RetailUnitPrice;
            float totalPrice = 0;
            if (baseItemQuantity > 0)
            {
                totalPrice = baseQuantity * unitPrice / baseItemQuantity;
            }

            return totalPrice;

        }

        public string GenerateBill(BillData billData)
        {
            // Get the maximum width of the bill for centering and separators
            int lineWidth = 45;

            // Get store details from the repository
            store = GetStore();

            // Center the store name, address, and contact details
            string storeName = store.StoreName.PadLeft((lineWidth + store.StoreName.Length) / 2).PadRight(lineWidth).ToUpper();
            string storeAddress = store.Address.PadLeft((lineWidth + store.Address.Length) / 2).PadRight(lineWidth).ToUpper();
            string storeContact = ("CONTACT: " + store.ContactNumber).PadLeft((lineWidth + ("CONTACT: " + store.ContactNumber).Length) / 2).PadRight(lineWidth);

            // Create the bill as a string with proper alignment and full-width separators
            string billTemplate = $@"
*********************************************
{storeName}
{storeAddress}
{storeContact}
*********************************************

Cashier: {billData.EmployeeName}
Date: {billData.Date}
Time: {billData.Time}

=============================================
ITEM NAME       UNIT      UNITPRICE  QTY    AMOUNT
=============================================
";

            // Loop through items and format them properly
            foreach (var item in billData.BillItems)
            {
                billTemplate += string.Format("{0,-14} {1,-8} {2,10:F2} {3,6} {4,12:F2}\n",
                    item.ItemName, item.CustomerUnit, item.UnitPrice, item.CustomerQuantity, item.Total);
            }

            billTemplate += $@"
=============================================
Sub Total:            {billData.SubTotal,14:F2}

Discount:             {billData.Discount,14:F2}

Total:                {billData.Total,14:F2}

Amount Paid:          {billData.AmountPaid,14:F2}

Balance:              {billData.Balance,14:F2}
=============================================

Customer Points:      {billData.CustomerPoints}
Customer Card #:      {billData.CustomerCardNumber}

Thank you for shopping with us!

Please come again!

";

            return billTemplate;
        }




    }
}

