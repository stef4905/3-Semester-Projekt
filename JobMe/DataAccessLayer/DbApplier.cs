using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DbApplier : IDataAccess<Applier>
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();

        /// <summary>
        /// Is a method that creates a Applier in the database with the variables Email & Password.
        /// </summary>
        /// <param name="obj">Is a Applier object</param>
        public bool Create(Applier obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {                   
                    cmd.CommandText = "INSERT INTO Applier (Email, Password, MaxRadius) VALUES (@Email, @Password, @MaxRadius)";
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Password", obj.Password);
                    cmd.Parameters.AddWithValue("MaxRadius", 50);
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

        /// <summary>
        /// Is a method that Deletes a Applier from the database by the id.
        /// </summary>
        /// <param name="id">Is the Id of the Applier</param>
        public void Delete(int id)
        {
            //using (SqlConnection connection = conn.OpenConnection())
            //{
            //    using (SqlCommand cmd = connection.CreateCommand())
            //    {
            //        cmd.CommandText = "DELETE FROM Applier WHERE Id = @id";
            //        cmd.Parameters.AddWithValue("id", id);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }

        /// <summary>
        /// Is the method to Get the applier from the Database.
        /// This includes all variables on Applier - except password.
        /// This also includes jobcategory for the specific Applier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Applier Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                Applier applier = new Applier();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Applier WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
             
                    
                    if (reader.Read())
                    {
                        applier.Id = (int)reader["Id"];
                        applier.Email = (string)reader["Email"];
                        applier.Country = (string)reader["Country"];
                        applier.Description = (string)reader["Description"];
                        applier.BannerURL = (string)reader["BannerURL"];
                        applier.ImageURL = (string)reader["ImageURL"];
                        applier.MaxRadius = (int)reader["MaxRadius"];
                        applier.HomePage = (string)reader["HomePage"];
                        applier.FName = (string)reader["FName"];
                        applier.LName = (string)reader["LName"];
                        applier.Age = (int)reader["Age"];
                        applier.Status = (bool)reader["Status"];
                      }
                    //Closes the current reader for the applier.
                    reader.Close();

                    //Executes the JobCategory command for Applier.
                    cmd.CommandText = "SELECT * FROM ApplierJobCategory WHERE ApplierId = @ApplierId";
                    cmd.Parameters.AddWithValue("ApplierId", applier.Id);
                    SqlDataReader readerA = cmd.ExecuteReader();

                    List<JobCategory> jobcategoryList = new List<JobCategory>();
                    while (readerA.Read())
                    {
                        DbJobCategory dbJobCategory = new DbJobCategory();

                        JobCategory jobCategory = dbJobCategory.Get((int)readerA["JobcategoryId"]);

                        jobcategoryList.Add(jobCategory);
                    }
                    //Sets the JobCategoryList equal to Applier JobCategoryList.
                    applier.jobCategoryList = jobcategoryList;

                    return applier;
                    

                }
            }
            throw new NotImplementedException();
        }

        public List<Applier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Applier entity)
        {
            throw new NotImplementedException();
        }
    }
}
