using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Repositories
{
    internal abstract class BaseRepository<T>
    {
        protected string _connectionString;

        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Abstract methods for CRUD operations (implemented in derived classes)
        
        public abstract IEnumerable<T> GetAll();
        public abstract void Insert(T entity);
        public abstract void Delete(string id);

        // Get a new database connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
