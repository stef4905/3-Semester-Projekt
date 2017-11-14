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
        DbConnection conn = new DbConnection();

        public bool Create(JobCategory obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobCategory Get(int id)
        {
            throw new NotImplementedException();
        }

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

        public void Update(JobCategory obj)
        {
            throw new NotImplementedException();
        }
    }
}
