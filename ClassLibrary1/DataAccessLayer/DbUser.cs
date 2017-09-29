using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DbUser : IDataAccess<User>
    {
        DbConnection conn = new DbConnection();
        
        public void Create(User entity)
        {
            using (SqlConnection connection = conn.OpenConnection()) {
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "Insert into Users (FName) values (@FName)";
                    cmd.Parameters.AddWithValue("FName", entity.FName);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
           
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "DELETE FROM Users WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public User Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection()) {
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isRead = reader.Read();
                    return new User(reader.GetInt32(0), reader.GetString(1));
                }
                //connection.Close();
            }
        }

        public List<User> GetAll()
        {
            List<User> UserList = new List<User>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    SqlDataReader reader = cmd.ExecuteReader();
                   
                    
                    while (reader.Read())
                    { 
                        User user = new User(reader.GetInt32(0), reader.GetString(1));
                        UserList.Add(user);
                    }

                }
            }
            return UserList;
        }

        public void Update(User entity)
        {
            using (SqlConnection connection = conn.OpenConnection()) {
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "UPDATE Users SET FName = @FName WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("FName", entity.FName);
                    cmd.Parameters.AddWithValue("Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
