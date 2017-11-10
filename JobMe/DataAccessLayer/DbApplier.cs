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
        public void Create(Applier obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Applier (Email, Password, MaxRadius) VALUES (@Email, @Password, @MaxRadius)";
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Password", obj.Password);
                    cmd.Parameters.AddWithValue("MaxRadius", 50);
                    cmd.ExecuteNonQuery();
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

        public Applier Get(int id)
        {
            //using(SqlConnection connection = conn.OpenConnection())
            //{
            //    using (SqlCommand cmd = connection.CreateCommand())
            //    {
            //        cmd.CommandText = "SELECT * FROM Applier WHERE Id = @id";
            //        cmd.Parameters.AddWithValue("id", id);
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        bool isRead = reader.Read();
            //        return new Applier(reader.getInt32(0), reader.GetString(1));

            //    }
            //}
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
