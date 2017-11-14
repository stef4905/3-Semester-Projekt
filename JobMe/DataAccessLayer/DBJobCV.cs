using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBJobCV
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();

        /// <summary>
        /// Add the specifik jobcv into the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Create(JobCV obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO JobCV (Title, ApplierId) VALUES (@Title, @ApplierId)";
                        cmd.Parameters.AddWithValue("Title", obj.Title);
                        cmd.Parameters.AddWithValue("ApplierId", obj.ApplierId);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }

        }
    }
}
