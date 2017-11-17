using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBJobCV : IDataAccess<JobCV>
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
                        cmd.CommandText = "INSERT INTO JobCV (ApplierId) VALUES (@ApplierId)";
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

        /// <summary>
        /// Return a single JobCV Object by the given Applier
        /// </summary>
        /// <param name="apllier"></param>
        /// <returns></returns>
        public JobCV Get(int applierId)
        {
           
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCV WHERE ApplierId = @ApplierId";
                    cmd.Parameters.AddWithValue("@ApplierId", applierId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        JobCV jobCV = new JobCV();
                        jobCV.Id = (int)reader["Id"];
                        jobCV.Title = (string)reader["Title"];
                        jobCV.Bio = (string)reader["Bio"];
                        return jobCV;
                    }
                    else {
                        return null;
                    }
                }  
            }
        }

        public List<JobCV> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the given object JobCV in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(JobCV obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "UPDATE JobCV SET Title = @Title, ApplierId = @ApplierId WHERE Id = @Id ";
                        cmd.Parameters.AddWithValue("Titlte", obj.Title);
                        cmd.Parameters.AddWithValue("StartDate", obj.ApplierId);
                        cmd.Parameters.AddWithValue("Id", obj.Id);
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
