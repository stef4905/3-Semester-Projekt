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

        DbConnection conn = new DbConnection();
        public void Create(Company obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into Companies (Email, Password) values (@Email, @Password)";
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Password", obj.Password);
                    cmd.ExecuteNonQuery();
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
