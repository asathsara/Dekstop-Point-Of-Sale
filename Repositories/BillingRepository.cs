using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PointOfSale.Repositories
{

    public class BillingRepository
    {

        private readonly string _connectionString;

        public BillingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public string GetEmployeeName(string employeeID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Name FROM Employee WHERE EmployeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    // Use ExecuteScalar to get a single value
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();

                    }
                    else
                    {
                        return null;

                    }
                }
            }

        }



        public ItemData GetItem(string itemID, string itemName)
        {
            var supplierID = GetSupplierID(itemID);  // Assuming this gets the supplierID

            ItemData itemData = new ItemData();


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
                                SELECT 
                                    item.ItemID,
                                    item.ItemName,
                                    item.Barcode,
                                    item.RetailQuantity,
                                    item.RetailUnit,
                                    item.RetailUnitPrice,
                                    item.Stock,
                                    item.Description,
                                    item.AdminID,
                                    item.SupplierID,
                                    supplierItem.WholeSaleQuantity,
                                    supplierItem.WholeSaleUnit,
                                    supplierItem.WholeSaleUnitPrice
                                FROM 
                                    Item AS item
                                INNER JOIN 
                                    SupplierItem AS supplierItem 
                                    ON item.SupplierID = supplierItem.SupplierID
                                    AND item.ItemName = supplierItem.ItemName
                                WHERE 
                                    item.SupplierID = @SupplierID
                                    AND item.ItemName = @ItemName;
                            ";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // Use 'if' instead of 'while' if only one item is expected
                        {
                            itemData.ItemID = reader["ItemID"].ToString();
                            itemData.ItemName = reader["ItemName"].ToString();
                            itemData.Barcode = int.Parse(reader["Barcode"].ToString());
                            itemData.RetailQuantity = int.Parse(reader["RetailQuantity"].ToString());
                            itemData.RetailUnit = int.Parse(reader["RetailUnit"].ToString());
                            itemData.RetailUnitPrice = float.Parse(reader["RetailUnitPrice"].ToString());
                            itemData.Stock = int.Parse(reader["Stock"].ToString());
                            itemData.Description = reader["Description"].ToString();
                            itemData.AdminID = reader["AdminID"].ToString();
                            itemData.SupplierID = reader["SupplierID"].ToString();
                            itemData.WholeSaleQuantity = int.Parse(reader["WholeSaleQuantity"].ToString());
                            itemData.WholeSaleUnit = int.Parse(reader["WholeSaleUnit"].ToString());
                            itemData.WholeSaleUnitPrice = float.Parse(reader["WholeSaleUnitPrice"].ToString());
                        }
                    }
                }
            }


            return itemData;
        }




        public int GetLoyaltyCustomerPoints(string cardNumber)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Points FROM LoyaltyCustomer WHERE CustomerCardNumber = @CardNumber";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CardNumber", cardNumber);

                    // Use ExecuteScalar to get a single value
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Int32.Parse(result.ToString());

                    }
                    else
                    {
                        return -1;

                    }
                }
            }

        }

        public Store GetStore()
        {
            Store store = new Store();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT StoreID,StoreName,Address,ContactNumber FROM Store";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            store.StoreID = reader["StoreID"].ToString();
                            store.StoreName = reader["StoreName"].ToString();
                            store.Address = reader["Address"].ToString();
                            store.ContactNumber = reader["ContactNumber"].ToString();

                        }

                    }
                }
            }

            return store;
        }

        public string GetSupplierID(string itemID)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT SupplierID FROM Item WHERE ItemID = @ItemID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    // Use ExecuteScalar to get a single value
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString(); // Return the SupplierID as a string
                    }
                    else
                    {
                        return null;

                    }
                }
            }

        }

        public int InsertBill(Bill bill)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Bill 
                    (Total, TotalProfit, DiscountPercenatge, CustomerPoints, TotalDiscount, Date, Time, EmployeeID, CustomerCardNumber, StoreID) 
                    VALUES 
                    (@Total, @TotalProfit, @DiscountPercenatge, @CustomerPoints, @TotalDiscount, @Date, @Time, @EmployeeID, @CustomerCardNumber, @StoreID);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameters and their values
                    cmd.Parameters.AddWithValue("@Total", bill.Total);
                    cmd.Parameters.AddWithValue("@TotalProfit", bill.TotalProfit);
                    cmd.Parameters.AddWithValue("@DiscountPercenatge", bill.DiscountPercentage);
                    cmd.Parameters.AddWithValue("@CustomerPoints", bill.CustomerPoints);
                    cmd.Parameters.AddWithValue("@TotalDiscount", bill.TotalDiscount);
                    cmd.Parameters.AddWithValue("@Date", bill.Date);
                    cmd.Parameters.AddWithValue("@Time", bill.Time);
                    cmd.Parameters.AddWithValue("@EmployeeID", bill.EmployeeID);
                    cmd.Parameters.AddWithValue("@StoreID", bill.StoreID);

                    // Handle nullable CustomerCardNumber
                    if (string.IsNullOrEmpty(bill.CustomerCardNumber))
                    {
                        cmd.Parameters.AddWithValue("@CustomerCardNumber", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CustomerCardNumber", bill.CustomerCardNumber);
                    }

                    // Use ExecuteScalar to get the auto-generated BillID
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

        }



        public void InsertBillItem(BillItem billItem, int billID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                // Adjust the query to include all the required fields for the BillItem table
                string query = @"INSERT INTO BillItem 
                    (Total, CustomerQuantity, ItemProfit, CustomerUnit, BillID, ItemID) 
                    VALUES 
                    (@Total, @CustomerQuantity, @ItemProfit, @CustomerUnit, @BillID, @ItemID);";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameters and their values
                    cmd.Parameters.AddWithValue("@Total", billItem.Total);
                    cmd.Parameters.AddWithValue("@CustomerQuantity", billItem.CustomerQuantity);
                    cmd.Parameters.AddWithValue("@ItemProfit", billItem.ItemProfit);
                    cmd.Parameters.AddWithValue("@CustomerUnit", billItem.CustomerUnit);
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    cmd.Parameters.AddWithValue("@ItemID", billItem.ItemID);

                    // Execute the command (no need for ExecuteScalar since it's not returning an ID)
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        return;
                    }
                }
            }

        }


        public void UpdateLoyaltyCustomerPoints(string cardNumber, int customerPoints)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE LoyaltyCustomer SET Points = @Points WHERE CustomerCardNumber = @CardNumber";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("@Points", customerPoints);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public IEnumerable<Item> getItemsForComboBox()
        {

            List<Item> items = new List<Item>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ItemID, ItemName FROM Item", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var itemID = reader["ItemID"]?.ToString() ?? string.Empty;
                    var productName = reader["ItemName"]?.ToString() ?? string.Empty;

                    items.Add(new Item
                    {
                        ItemID = itemID,
                        ItemName = productName
                    });
                }
                reader.Close();

                return items;


            }
        }
    }
}




