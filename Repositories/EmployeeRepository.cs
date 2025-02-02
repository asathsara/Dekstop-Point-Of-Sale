using PointOfSale.Helpers;
using PointOfSale.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PointOfSale.Repositories
{
    internal class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }

        public override void Delete(string id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter with value
                    cmd.Parameters.AddWithValue("@EmployeeID", id);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Get employee values from the database
        // return as a list
        public override IEnumerable<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Employee";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                EmployeeID = reader["EmployeeID"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                EmployeeName = reader["Name"].ToString(),
                                AdminID = reader["AdminID"].ToString()

                            });
                        }
                    }

                }
            }
            return employees;
        }


        public override void Insert(Employee employee)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();


                string query = @"
        IF EXISTS (SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID)
        BEGIN
            UPDATE Employee
            SET Username = @Username,
                Password = @Password,
                Name = @Name,
                AdminID = @AdminID
            WHERE EmployeeID = @EmployeeID;
        END
        ELSE
        BEGIN
            INSERT INTO Employee (EmployeeID, Username, Password, Name, AdminID)
            VALUES (@EmployeeID, @Username, @Password, @Name, @AdminID);
        END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters with appropriate values
                    cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                    cmd.Parameters.AddWithValue("@Username", employee.Username);
                    cmd.Parameters.AddWithValue("@Password", employee.Password);
                    cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@AdminID", employee.AdminID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateLoyaltyCustomer(string employeeID)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"
            UPDATE LoyaltyCustomer
            SET EmployeeID = @AdminID
            WHERE EmployeeID = @EmployeeID;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@AdminID", UserData.EmployeeID);

                command.ExecuteNonQuery();
            }

        }

        public void UpdateBill(string employeeID)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"
            UPDATE Bill
            SET EmployeeID = @AdminID
            WHERE EmployeeID = @EmployeeID;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@AdminID", UserData.EmployeeID);

                command.ExecuteNonQuery();
            }

        }
    }
}


