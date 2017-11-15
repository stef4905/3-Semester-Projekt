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


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            Company company = new Company();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Company WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        company.Id = (int)reader["Id"];
                        company.Email = (string)reader["Email"];
                        company.Password = (string)reader["Password"];
                        company.Phone = (int)reader["Phone"];
                        company.Address = (string)reader["Address"];
                        company.Country = (string)reader["Country"];
                        company.ImageURL = (string)reader["ImageURL"];
                        company.Description = (string)reader["Description"];
                        company.BannerURL = (string)reader["BannerURL"];
                        company.MaxRadius = (int)reader["MaxRadius"];
                        company.Homepage = (string)reader["HomePage"];
                        company.CompanyName = (string)reader["CompanyName"];
                        company.CVR = (int)reader["CVR"];
                        //Mangler at kunne trække BusinessType 
                        //objekterne med sig.


                    }
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
    }
}
