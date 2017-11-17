using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbJobCategory : IDataAccess<JobCategory>
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();

        public bool Create(JobCategory obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a JobCategory Object from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JobCategory Get(int id)
        {
            JobCategory jobCategory = new JobCategory();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCategories WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        jobCategory.Id = (int)reader["Id"];
                        jobCategory.Title = (string)reader["Title"];
                    }
                    return jobCategory;
                }
            }
        }

        /// <summary>
        /// Returns a A list of all JobCategories from the database
        /// </summary>
        /// <returns></returns>
        public List<JobCategory> GetAll()
        {
            List<JobCategory> jobCategoryList = new List<JobCategory>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCategories";
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        JobCategory jobCategory = new JobCategory
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"]
                        };
                        jobCategoryList.Add(jobCategory);
                    }
                }
            }
            return jobCategoryList;
        }

        public bool Update(JobCategory obj)
        {
            throw new NotImplementedException();
        }
    }
}
