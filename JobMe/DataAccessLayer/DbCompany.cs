using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DbCompany : IDataAccess<Company>
    {
        /// <summary>
        /// Opens a new connection to our database
        /// </summary>
        DbConnection conn = new DbConnection();
        
        /// <summary>
        /// Creates an object and executes it into the database through the database connection.
        /// Its protected against SQL Injections with Parameters.
        /// </summary>
        /// <param name="obj"></param>
        public bool Create(Company obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {


                try
                {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Companies (Email, Password) VALUES (@Email, @Password)";
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Password", obj.Password);
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
        /// <summary>
        /// Create an JobPost Object and executes it into the databases through the database connection
        /// Its protected against SQL Injections with Parameters.
        /// </summary>
        /// <param name="obj">Is a JobPost object</param>
        /// <returns></returns>
        public bool createJobPost(JobPost obj)
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

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
