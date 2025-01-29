using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PointOfSale.Repositories
{
    internal class ItemRepository : BaseRepository<Item>
    {
        public ItemRepository(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(string id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Item WHERE ItemID = @ItemID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter with value
                    cmd.Parameters.AddWithValue("@ItemID", id);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public override IEnumerable<Item> GetAll()
        {
            List<Item> items = new List<Item>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Item";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new Item
                            {
                                ItemID = reader["ItemID"].ToString() ?? string.Empty,
                                ItemName = reader["ItemName"].ToString() ?? string.Empty,
                                Barcode = int.Parse(reader["Barcode"].ToString()),
                                RetailQuantity = int.Parse(reader["RetailQuantity"].ToString()),
                                RetailUnit = int.Parse(reader["RetailQuantity"].ToString()),
                                RetailUnitPrice = float.Parse(reader["RetailUnitPrice"].ToString()),
                                Stock = int.Parse(reader["Stock"].ToString()),
                                Description = reader["Description"].ToString() ?? string.Empty,
                                AdminID = reader["AdminID"].ToString() ?? string.Empty,
                                SupplierID = reader["SupplierID"].ToString() ?? string.Empty


                            });
                        }
                    }

                }
            }
            return items;
        }

        

        public override void Insert(Item item)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                // SQL Insert query
                string query = @"
            IF EXISTS (SELECT 1 FROM Item WHERE ItemID = @ItemID)
            BEGIN
                UPDATE Item
                SET ItemName = @ItemName,
                    Barcode = @Barcode,
                    RetailQuantity = @RetailQuantity,
                    RetailUnit = @RetailUnit,
                    RetailUnitPrice = @RetailUnitPrice,
                    Stock = @Stock,
                    Description = @Description,
                    AdminID = @AdminID,
                    SupplierID = @SupplierID
                WHERE ItemID = @ItemID;
            END
            ELSE
            BEGIN
                INSERT INTO Item (ItemID, ItemName, Barcode, RetailQuantity, RetailUnit, RetailUnitPrice, Stock, Description, AdminID, SupplierID)
                VALUES (@ItemID, @ItemName, @Barcode, @RetailQuantity, @RetailUnit, @RetailUnitPrice, @Stock, @Description, @AdminID, @SupplierID);
            END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters with appropriate values
                    cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@Barcode", item.Barcode);
                    cmd.Parameters.AddWithValue("@RetailQuantity", item.RetailQuantity);
                    cmd.Parameters.AddWithValue("@RetailUnit", item.RetailUnit);
                    cmd.Parameters.AddWithValue("@RetailUnitPrice", item.RetailUnitPrice);
                    cmd.Parameters.AddWithValue("@Stock", item.Stock);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@AdminID", item.AdminID);
                    cmd.Parameters.AddWithValue("@SupplierID", item.SupplierID);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        public IEnumerable<Supplier> GetSuppliers()
        {
            var suppliersComboBox = new List<Supplier>();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName FROM Supplier";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                suppliersComboBox.Add(new Supplier
                                {
                                    SupplierID = reader["SupplierID"].ToString(),
                                    SupplierName = reader["SupplierName"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }

            return suppliersComboBox;
        }

        public List<string> GetItems(string supplierID)
        {
            List<string> listItems = new List<string>(); ;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ItemName FROM SupplierItem WHERE SupplierID = @SupplierID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listItems.Add(reader["ItemName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}");
            }

            return listItems;
        }

    }
}
