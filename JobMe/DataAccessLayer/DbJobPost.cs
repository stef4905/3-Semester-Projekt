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

        public JobPost Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobPost> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(JobPost obj)
        {
            throw new NotImplementedException();
        }
    }
}
