using PointOfSale.Helpers;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void roundButtonLogin_Click(object sender, EventArgs e)
        {
            string username = roundedTextboxUsername.Text.ToString().Trim().ToLower();
            string password = roundedTextboxPassword.Text.ToString().Trim().ToLower();

            login(username, password);
        }


        private void login(string username, string password)
        {


            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the credentials match an Admin or Employee
                    string query = @"IF EXISTS (SELECT 1 FROM Admin WHERE Username = @username AND Password = @password)
                    BEGIN
                    SELECT 'Admin' AS Role, AdminID AS ID FROM Admin WHERE Username = @username AND Password = @password
                    END
                    ELSE IF EXISTS (SELECT 1 FROM Employee WHERE Username = @username AND Password = @password)
                    BEGIN
                    SELECT 'Employee' AS Role, EmployeeID AS ID FROM Employee WHERE Username = @username AND Password = @password
                    END";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    string userRole = null;
                    string userId = null;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userRole = reader["Role"].ToString();
                            userId = reader["ID"].ToString();


                        }
                    }

                    if (userRole == "Admin")
                    {
                        // Admin login successful
                        UserData.AdminID = int.Parse(userId);
                        MessageBox.Show("Login succesful as admin ", "Press OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open Admin Dashboard
                        AdminPanelForm Dashboard = new AdminPanelForm();
                        Dashboard.Show();
                        this.Hide();



                    }
                    else if (userRole == "Employee")
                    {
                        UserData.EmployeeID = userId;
                        // Employee login successful
                        MessageBox.Show("Login successful as employee ", "Press OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open Employee Dashboard
                        EmployeePanelForm billingForm = new EmployeePanelForm();
                        billingForm.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Press OK to try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


    }
}
