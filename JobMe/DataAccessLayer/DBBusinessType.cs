using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class DBBusinessType : IDataAccess<BusinessType>
    {

        /// <summary>
        /// Opens a new connection to our database
        /// </summary>
        DbConnection conn = new DbConnection();


        public bool Create(BusinessType obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessType Get(int id)
        {
            BusinessType businessType = new BusinessType();
            using(SqlConnection connection = conn.OpenConnection())
            {
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM BusinessType WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        businessType.Id = (int)reader["Id"];
                        businessType.Type = (string)reader["Type"];
                    }
                }
            }
            return businessType;
        }

        public List<BusinessType> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(BusinessType obj)
        {
            throw new NotImplementedException();
        }
    }
}
