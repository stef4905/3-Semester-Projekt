using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbJobPost : IDataAccess<JobPost>
    {
        /// <summary>
        /// Opens a new connection to our database
        /// </summary>
        DbConnection conn = new DbConnection();


        /// <summary>
        /// Create an JobPost Object and executes it into the databases through the database connection
        /// Its protected against SQL Injections with Parameters.
        /// </summary>
        /// <param name="obj">Is a JobPost object</param>
        /// <returns></returns>
        public bool Create(JobPost obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO JobPost (Title, Description, StartDate, EndDate, JobTitle, WorkHoursId, Address, CompanyId, JobCategoryId) VALUES (@Title, @Description, @StartDate, @EndDate, @JobTitle, @WorkHoursId, @Address, @CompanyId, @JobCategoryId)";
                        cmd.Parameters.AddWithValue("Title", obj.Title);
                        cmd.Parameters.AddWithValue("Description", obj.Description);
                        cmd.Parameters.AddWithValue("StartDate", obj.StartDate);
                        cmd.Parameters.AddWithValue("EndDate", obj.EndDate);
                        cmd.Parameters.AddWithValue("JobTitle", obj.JobTitle);
                        cmd.Parameters.AddWithValue("WorkHoursId", obj.workHours.Id);
                        cmd.Parameters.AddWithValue("Address", obj.Address);
                        cmd.Parameters.AddWithValue("CompanyId", obj.company.Id);
                        cmd.Parameters.AddWithValue("JobCategoryId", obj.jobCategory.Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }




        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a JobPost Object from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>jobPost</returns>
        public JobPost Get(int id)
        {
            DbWorkHour dbWorkHour = new DbWorkHour();
            DbCompany dbCompany = new DbCompany();
            DbJobCategory dbJobCategory = new DbJobCategory();
            JobPost jobPost = new JobPost();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobPost WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        jobPost.Id = (int)reader["Id"];
                        jobPost.Title = (string)reader["Title"];
                        jobPost.Description = (string)reader["Description"];
                        jobPost.StartDate = (DateTime)reader["StartDate"];
                        jobPost.EndDate = (DateTime)reader["EndDate"];
                        jobPost.JobTitle = (string)reader["JobTitle"];
                        jobPost.workHours = dbWorkHour.Get((int)reader["WorkHoursId"]);
                        jobPost.Address = (string)reader["Address"];
                        jobPost.company = dbCompany.Get((int)reader["CompanyId"]);
                        jobPost.jobCategory = dbJobCategory.Get((int)reader["JobCategoryId"]);
                    };
                    return jobPost;
                }
            }
        }

        /// <summary>
        /// Returns a list of all JobPost from the database
        /// </summary>
        /// <returns>a jobPostList</returns>
        public List<JobPost> GetAll()
        {
            List<JobPost> jobPostList = new List<JobPost>();
            using (SqlConnection connection = conn.OpenConnection())
            {

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobPost";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DbWorkHour dbWorkHour = new DbWorkHour();
                        DbCompany dbCompany = new DbCompany();
                        DbJobCategory dbJobCategory = new DbJobCategory();
                        JobPost jobPost = new JobPost
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            Description = (string)reader["Description"],
                            StartDate = (DateTime)reader["StartDate"],
                            EndDate = (DateTime)reader["EndDate"],
                            JobTitle = (string)reader["JobTitle"],
                            workHours = dbWorkHour.Get((int)reader["WorkHoursId"]),
                            Address = (string)reader["Address"],
                            company = dbCompany.Get((int)reader["CompanyId"]),
                            jobCategory = dbJobCategory.Get((int)reader["JobCategoryId"])
                        };
                        jobPostList.Add(jobPost);
                    }
                }
            }
            return jobPostList;
        }

        public bool Update(JobPost obj)
        {
            throw new NotImplementedException();
        }
    }
}
