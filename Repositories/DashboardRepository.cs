using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Repositories
{
    internal class DashboardRepository
    {
        private readonly string _connectionString;

        public DashboardRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public int GetItemCount()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM Item;", connection);
                var result = command.ExecuteScalar();
                return result != null ? int.Parse(result.ToString()) : 0;
            }
        }

        public int GetCustomerCount()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM LoyaltyCustomer;", connection);
                var result = command.ExecuteScalar();
                return result != null ? int.Parse(result.ToString()) : 0;
            }
        }

        public int GetEmployeesCount()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM Employee;", connection);
                var result = command.ExecuteScalar();
                return result != null ? int.Parse(result.ToString()) : 0;
            }
        }

        public float GetMonthlyIncome(DateTime firstDay, DateTime lastDay)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT SUM(Total) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);
                var result = command.ExecuteScalar();
                return float.TryParse(result.ToString(), out float monthlyIncome) ? monthlyIncome : 0.0f;
            }
        }

        public float GetMonthlyProfit(DateTime firstDay, DateTime lastDay)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT SUM(TotalProfit) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);
                var result = command.ExecuteScalar();
                return float.TryParse(result.ToString(), out float monthlyProfit) ? monthlyProfit : 0.0f;
            }
        }

        public int GetMonthlyOrders(DateTime firstDay, DateTime lastDay)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);
                var result = command.ExecuteScalar();
                return result != null ? int.Parse(result.ToString()) : 0;
            }
        }

        public float GetTodayTotal(DateTime today)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT SUM(Total) FROM Bill WHERE Date = @Today";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Today", today);
                var result = command.ExecuteScalar();
                return float.TryParse(result.ToString(), out float todayTotal) ? todayTotal : 0.0f;
            }
        }

        public float GetTodayProfit(DateTime today)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT SUM(TotalProfit) FROM Bill WHERE Date = @Today";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Today", today);
                var result = command.ExecuteScalar();
                return float.TryParse(result.ToString(), out float todayProfit) ? todayProfit : 0.0f;
            }
        }

        public int GetTodayOrders(DateTime today)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT COUNT(*) FROM Bill WHERE Date = @Today";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Today", today);
                var result = command.ExecuteScalar();
                return result != null ? int.Parse(result.ToString()) : 0;
            }
        }
    }
}

