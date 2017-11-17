using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbWorkHour : IDataAccess<WorkHours>
    {
        /// <summary>
        /// Opens a new connection to our database
        /// </summary>
        DbConnection conn = new DbConnection();

        public bool Create(WorkHours obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a WorkHours Object from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WorkHours Get(int id)
        {
            WorkHours workHours = new WorkHours();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkHours WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        workHours.Id = (int)reader["Id"];
                        workHours.Type = (string)reader["Type"];
                    }
                    return workHours;
                }
            }
        }

        /// <summary>
        /// Returns a list of all JobCategories from the database
        /// </summary>
        /// <returns></returns>
        public List<WorkHours> GetAll()
        {
            List<WorkHours> workHoursList = new List<WorkHours>();
            using (SqlConnection connection = conn.OpenConnection())
            {
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkHours";
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        WorkHours workHours = new WorkHours
                        {
                            Id = (int)reader["Id"],
                            Type = (string)reader["Type"]
                        };
                        workHoursList.Add(workHours);
                    }
                }
            }
            return workHoursList;
        }

        public bool Update(WorkHours obj)
        {
            throw new NotImplementedException();
        }
    }
}
