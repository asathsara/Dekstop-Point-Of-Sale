using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PointOfSale.Models;

namespace PointOfSale.Repositories
{
    internal class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(string id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd1 = new SqlCommand("DELETE FROM SupplierItem WHERE SupplierID = @SupplierID;", conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@SupplierID", id);
                            cmd1.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd2 = new SqlCommand("DELETE FROM Supplier WHERE SupplierID = @SupplierID;", conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@SupplierID", id);
                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public override IEnumerable<Supplier> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT supplier.SupplierID, supplier.SupplierName, supplier.ContactNumber, supplier.AdminID, 
                                    supplierItem.ItemName, supplierItem.WholeSaleQuantity, supplierItem.WholeSaleUnit, supplierItem.WholeSaleUnitPrice 
                                FROM Supplier supplier 
                                LEFT JOIN SupplierItem supplierItem ON supplier.SupplierID = supplierItem.SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID = reader["SupplierID"].ToString(),
                                ItemName = reader["ItemName"].ToString(),
                                SupplierName = reader["SupplierName"].ToString(),
                                ContactNumber = int.Parse(reader["ContactNumber"].ToString()),
                                WholeSaleQuantity = int.Parse(reader["WholeSaleQuantity"].ToString()),
                                WholeSaleUnit = int.Parse(reader["WholeSaleUnit"].ToString()),
                                WholeSaleUnitPrice = float.Parse(reader["WholeSaleUnitPrice"].ToString()),
                                AdminID = reader["AdminID"].ToString(),
                            });
                        }
                    }
                }
            }
            return suppliers;
        }


        public override void Insert(Supplier supplier)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string checkSupplierExistsQuery = "SELECT COUNT(1) FROM Supplier WHERE SupplierID = @SupplierID";
                        string insertSupplierQuery = @"INSERT INTO Supplier (SupplierID, SupplierName, ContactNumber, AdminID) 
                                                VALUES (@SupplierID, @SupplierName, @ContactNumber, @AdminID)";
                        string updateSupplierQuery = @"UPDATE Supplier 
                                               SET SupplierName = @SupplierName, ContactNumber = @ContactNumber, AdminID = @AdminID 
                                               WHERE SupplierID = @SupplierID";
                        string insertSupplierItemQuery = @"INSERT INTO SupplierItem (SupplierID, ItemName, WholeSaleQuantity, WholeSaleUnit, WholeSaleUnitPrice) 
                                                    VALUES (@SupplierID, @ItemName, @WholeSaleQuantity, @WholeSaleUnit, @WholeSaleUnitPrice)";
                        string updateSupplierItemQuery = @"UPDATE SupplierItem 
                                                   SET ItemName = @ItemName, WholeSaleQuantity = @WholeSaleQuantity, 
                                                       WholeSaleUnit = @WholeSaleUnit, WholeSaleUnitPrice = @WholeSaleUnitPrice
                                                   WHERE SupplierID = @SupplierID";

                        bool supplierExists = false;
                        using (SqlCommand cmd = new SqlCommand(checkSupplierExistsQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                            supplierExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                        }

                        if (supplierExists)
                        {
                            // Update the supplier if it already exists
                            using (SqlCommand cmd = new SqlCommand(updateSupplierQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                                cmd.Parameters.AddWithValue("@ContactNumber", supplier.ContactNumber);
                                cmd.Parameters.AddWithValue("@AdminID", supplier.AdminID);
                                cmd.ExecuteNonQuery();
                            }

                            // Update the supplier item if it exists
                            using (SqlCommand cmd = new SqlCommand(updateSupplierItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                                cmd.Parameters.AddWithValue("@ItemName", supplier.ItemName);
                                cmd.Parameters.AddWithValue("@WholeSaleQuantity", supplier.WholeSaleQuantity);
                                cmd.Parameters.AddWithValue("@WholeSaleUnit", supplier.WholeSaleUnit);
                                cmd.Parameters.AddWithValue("@WholeSaleUnitPrice", supplier.WholeSaleUnitPrice);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new supplier if it does not exist
                            using (SqlCommand cmd = new SqlCommand(insertSupplierQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                                cmd.Parameters.AddWithValue("@ContactNumber", supplier.ContactNumber);
                                cmd.Parameters.AddWithValue("@AdminID", supplier.AdminID);
                                cmd.ExecuteNonQuery();
                            }

                            // Insert a new supplier item
                            using (SqlCommand cmd = new SqlCommand(insertSupplierItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                                cmd.Parameters.AddWithValue("@ItemName", supplier.ItemName);
                                cmd.Parameters.AddWithValue("@WholeSaleQuantity", supplier.WholeSaleQuantity);
                                cmd.Parameters.AddWithValue("@WholeSaleUnit", supplier.WholeSaleUnit);
                                cmd.Parameters.AddWithValue("@WholeSaleUnitPrice", supplier.WholeSaleUnitPrice);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
        }





    }
}
