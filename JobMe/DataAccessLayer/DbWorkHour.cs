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

        public WorkHours Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a A list of all JobCategories from the database
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

        public void Update(WorkHours obj)
        {
            throw new NotImplementedException();
        }
    }
}
