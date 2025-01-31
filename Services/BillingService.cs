using PointOfSale.Helpers;
using PointOfSale.Models;
using PointOfSale.Repositories;
using System;
using System.Collections.Generic;

namespace PointOfSale.Services
{
    public class BillingService
    {
        private readonly BillingRepository _billingRepository;

        private const float LOYALTY_CUSTOMER_GET_PERCENTAGE = 10f;
        private const float LOYALTY_CUSTOMER_SET_PERCENTAGE = 3f;

        private int customerPointsDiscount = 0;

        public BillingService(string connectionString)
        {
            _billingRepository = new BillingRepository(connectionString);
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


        public int InsertBill(Bill bill)
        {
            return _billingRepository.InsertBill(bill);
        }


        public void InsertBillItem(BillItem billItem, int billID)
        {
            _billingRepository.InsertBillItem(billItem, billID);
        }

        public int GetCustomerPointsDiscount()
        {
            return customerPointsDiscount;
        }


        public float CalculateTotalWithDiscountAndLoyalty(int customerCardNumber, float subTotal, float discountPercentage)
        {
            float total = subTotal;
            int customerPoints = 0;
            customerPointsDiscount = 0;
            float discount = 0;

            // Handle loyalty points and discount
            if (customerCardNumber > 0)
            {
                customerPoints = GetLoyaltyCustomerPoints(customerCardNumber.ToString());
                customerPointsDiscount = (int)CalculateLoyaltyDiscount(subTotal, ref customerPoints);
                total -= customerPointsDiscount;
            }

            if (discountPercentage > 0)
            {
                discount = total * discountPercentage / 100;
                total -= discount;
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



        public void UpdateLoyaltyCustomerPoints(string cardNumber, int customerPoints)
        {
            _billingRepository.UpdateLoyaltyCustomerPoints(cardNumber, customerPoints);
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
            var store = _billingRepository.GetStore();

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
            foreach (var item in billData.TableItems)
            {
                billTemplate += string.Format("{0,-14} {1,-8} {2,10:F2} {3,6} {4,12:F2}\n",
                    item.ItemName, item.Unit, item.UnitPrice, item.Quantity, item.ItemAmount);
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

