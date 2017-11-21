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
        public JobCV Create(JobCV jobCV)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO JobCV (Title, Bio) output INSERTED.Id VALUES (@Title, @Bio)";
                        cmd.Parameters.AddWithValue("Title", jobCV.Title);
                        cmd.Parameters.AddWithValue("Bio", jobCV.Bio);
                        int modefied =  (int)cmd.ExecuteScalar();
                        jobCV.Id = modefied; //Get primary id after creation
                        return jobCV;
                    }
                    catch (SqlException e)
                    {
                        throw e;
                        return null;
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
        public JobCV Get(int id)
        {
           
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCV WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
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
                        cmd.CommandText = "UPDATE JobCV SET Title = @Title, Bio = @Bio WHERE Id = @Id ";
                        cmd.Parameters.AddWithValue("Title", obj.Title);
                        cmd.Parameters.AddWithValue("Bio", obj.Bio);
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
