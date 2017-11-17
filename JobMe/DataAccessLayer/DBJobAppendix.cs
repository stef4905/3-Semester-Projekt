using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBJobAppendix : IDataAccess<JobAppendix>
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();

        /// <summary>
        /// Inserts a object of JobAppendix into the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Create(JobAppendix obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try {
                        cmd.CommandText = "INSERT INTO JobAppendix (Title, FilePath, JobCVId) VALUES (@Title, @FilePath, @JobCVId) WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("Title", obj.Title);
                        cmd.Parameters.AddWithValue("FilePath", obj.FilePath);
                        cmd.Parameters.AddWithValue("JobCVId", obj.JobCVId);
                        cmd.Parameters.AddWithValue("Id", obj.Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch (SqlException) {
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
        /// Returns a single object of JobAppendix with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JobAppendix Get(int id)
        {
            JobAppendix jobAppendix = new JobAppendix();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobAppendix WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        jobAppendix.Id = (int)reader["Id"];
                        jobAppendix.Title = (string)reader["Title"];
                        jobAppendix.FilePath = (string)reader["FilePath"];
                        jobAppendix.JobCVId = (int)reader["JobCVId"];
                    }
                }
                return jobAppendix;
            }
        }

        public List<JobAppendix> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of all JobAppendix coresponding with the given JobCVId
        /// </summary>
        /// <param name="jobCVId"></param>
        /// <returns></returns>
        public List<JobAppendix> GetAllByJobCVId(int jobCVId)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobAppendix WHERE JobCVId = @JobCVId";
                    cmd.Parameters.AddWithValue("JobCVId", jobCVId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<JobAppendix> AppendixList = new List<JobAppendix>();
                    while (reader.Read())
                    {
                        JobAppendix jobAppendix = new JobAppendix();
                        jobAppendix.Id = (int)reader["Id"];
                        jobAppendix.Title = (string)reader["Title"];
                        jobAppendix.FilePath = (string)reader["FilePath"];
                        jobAppendix.JobCVId = (int)reader["JobCVId"];
                        AppendixList.Add(jobAppendix);
                    }
                    return AppendixList;
                }
            }
        }

        /// <summary>
        /// Updates the given JobAppendix object in the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(JobAppendix obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "UPDATE JobAppendix SET Title = @Title, FilePath = @FilePath, JobCVId = @JobCVId WHERE Id = @Id ";
                        cmd.Parameters.AddWithValue("Titlte", obj.Title);
                        cmd.Parameters.AddWithValue("FilePath", obj.FilePath);
                        cmd.Parameters.AddWithValue("JobCVId", obj.JobCVId);
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
