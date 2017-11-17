using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DbJobApplication : IDataAccess<JobApplication>
    {
        DbConnection conn = new DbConnection();
/// <summary>
/// Creates a jobapplication in the database
/// </summary>
/// <param name="obj"></param>
/// <returns></returns>
        public bool Create(JobApplication obj)

        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO JobApplication (Title, Description, ApplierId) VALUES (@Title, @Description, @ApplierId)";
                        cmd.Parameters.AddWithValue("Title", obj.Title);
                        cmd.Parameters.AddWithValue("Description", obj.Title);
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobApplication Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobApplication> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(JobApplication obj)
        {
            throw new NotImplementedException();
        }
    }
}
