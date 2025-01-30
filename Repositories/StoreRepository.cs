using PointOfSale.Models;
using System.Data.SqlClient;

namespace PointOfSale.Repositories
{
    internal class StoreRepository
    {
        private readonly string _connectionString;

        public StoreRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public Store GetStore()
        {
            Store store = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 * FROM Store";  // Fetch the first entry (assuming only one record)
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // Only one record should be returned
                        {
                            store = new Store
                            {
                                StoreID = reader["StoreID"].ToString(),
                                StoreName = reader["StoreName"].ToString(),
                                Address = reader["Address"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                            };
                        }
                    }
                }
            }

            return store;
        }


        public void Update(Store store)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "UPDATE Store SET StoreName = @StoreName, ContactNumber = @ContactNumber, " +
                               "Address = @Address WHERE StoreID = @StoreID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StoreID", store.StoreID);
                    cmd.Parameters.AddWithValue("@StoreName", store.StoreName);
                    cmd.Parameters.AddWithValue("@ContactNumber", store.ContactNumber);
                    cmd.Parameters.AddWithValue("@Address", store.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
    }
}
