using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PointOfSale.Repositories
{
    internal class LoyaltyCustomerRepository : BaseRepository<LoyaltyCustomer>
    {
        public LoyaltyCustomerRepository(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(string id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM LoyaltyCustomer WHERE CustomerID = @CustomerID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter with value
                    cmd.Parameters.AddWithValue("@CustomerID", id);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override IEnumerable<LoyaltyCustomer> GetAll()
        {
            List<LoyaltyCustomer> loyaltyCustomers = new List<LoyaltyCustomer>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM LoyaltyCustomer";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loyaltyCustomers.Add(new LoyaltyCustomer
                            {
                                CustomerID = reader["CustomerID"].ToString(),
                                CustomerName = reader["Name"].ToString(),
                                CustomerCardNumber = reader["CustomerCardNumber"].ToString(),
                                Points = int.Parse(reader["Points"].ToString()),
                                EmployeeID = reader["EmployeeID"].ToString()

                            });
                        }
                    }

                }
            }
            return loyaltyCustomers;
        }


        public override void Insert(LoyaltyCustomer loyaltyCustomer)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                // SQL query to update if exists, otherwise insert
                string query = @"
                            IF EXISTS (SELECT 1 FROM LoyaltyCustomer WHERE CustomerID = @CustomerID)
                            BEGIN
                                UPDATE LoyaltyCustomer
                                SET Name = @Name,
                                    CustomerCardNumber = @CustomerCardNumber,
                                    Points = @Points,
                                    EmployeeID = @EmployeeID
                                WHERE CustomerID = @CustomerID;
                            END
                            ELSE
                            BEGIN
                                INSERT INTO LoyaltyCustomer (CustomerID, Name, CustomerCardNumber, Points, EmployeeID)
                                VALUES (@CustomerID, @Name, @CustomerCardNumber, @Points, @EmployeeID);
                            END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters with appropriate values
                    cmd.Parameters.AddWithValue("@CustomerID", loyaltyCustomer.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", loyaltyCustomer.CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerCardNumber", loyaltyCustomer.CustomerCardNumber);
                    cmd.Parameters.AddWithValue("@Points", loyaltyCustomer.Points);
                    cmd.Parameters.AddWithValue("@EmployeeID", loyaltyCustomer.EmployeeID);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBill(int customerCardNumber)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"
            UPDATE Bill
            SET CustomerCardNumber = @CustomerDeleted
            WHERE CustomerCardNumber = @CustomerCardNumber;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CustomerCardNumber", customerCardNumber);
                command.Parameters.AddWithValue("@CustomerDeleted", DBNull.Value);

                command.ExecuteNonQuery();
            }

        }
    }
}
