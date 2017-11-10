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
        DbConnection conn = new DbConnection();
        public void Create(Applier applier)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Applier (Email), (Password) values (@Email),(@Password)";
                    cmd.Parameters.AddWithValue("Email", applier.Email);
                    cmd.Parameters.AddWithValue("Password", applier.Password);
                    cmd
                }
            }

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Applier Get(int id)
        {
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
