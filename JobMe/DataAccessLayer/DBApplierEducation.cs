using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class DBApplierEducation : IDataAccess<ApplierEducation>
    {
        //Is an instance of DBConnection
        DbConnection conn = new DbConnection();


        /// <summary>
        /// Inserts the ApplierEducation Object into the database
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Create(ApplierEducation obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO ApplierEducation (EducationName, Institution, StartDate, EndDate, JobCVId) VALUES (@EducationName, @Institution, @StartDate, @EndDate, @JobCVId) WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("EducationName", obj.EducationName);
                        cmd.Parameters.AddWithValue("Institution", obj.Institution);
                        cmd.Parameters.AddWithValue("StartDate", obj.StartDate);
                        cmd.Parameters.AddWithValue("EndDate", obj.EndDate);
                        cmd.Parameters.AddWithValue("JobCVId", obj.JobCVId);
                        cmd.Parameters.AddWithValue("Id", obj.id);
                        return true;
                    }
                    catch (SqlException) {
                        return false;
                    }

                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a single object of ApplierEducation by the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ApplierEducation Get(int id)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ApplierEducation WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ApplierEducation applierEducation = new ApplierEducation();
                        applierEducation.id = (int)reader["id"];
                        applierEducation.EducationName = (string)reader["EducationName"];
                        applierEducation.Institution = (string)reader["Institution"];
                        applierEducation.StartDate = (DateTime)reader["StartDate"];
                        applierEducation.EndDate = (DateTime)reader["EndDate"];
                        applierEducation.JobCVId = (int)reader["JobCVId"];
                        return applierEducation;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public List<ApplierEducation> GetAll()
        {
            return null;
        }

        /// <summary>
        /// Returns a list of all ApplierEducations with the corosponding JobCVID
        /// </summary>
        /// <param name="jobCVId"></param>
        /// <returns></returns>
        public List<ApplierEducation> GetAllByJobCVId(int jobCVId)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ApplierEducation WHERE JobCVId = @JobCVId";
                    cmd.Parameters.AddWithValue("JobCVId", jobCVId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<ApplierEducation> EducationList = new List<ApplierEducation>();
                    while(reader.Read())
                    {
                        ApplierEducation applierEducation = new ApplierEducation();
                        applierEducation.id = (int)reader["id"];
                        applierEducation.EducationName = (string)reader["EducationName"];
                        applierEducation.Institution = (string)reader["Institution"];
                        applierEducation.StartDate = (DateTime)reader["StartDate"];
                        applierEducation.EndDate = (DateTime)reader["EndDate"];
                        applierEducation.JobCVId = (int)reader["JobCVId"];
                        EducationList.Add(applierEducation);
                    }
                    return EducationList;
                }
            }
        }

        public bool Update(ApplierEducation obj)
        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "UPDATE ApplierEducation SET EducationName = @EducationName, Institution = @Institution, StartDate = @StartDate, EndDate = @EndDate, JobCVId = @JobCVId WHERE Id = @Id ";
                        cmd.Parameters.AddWithValue("EducationName", obj.EducationName);
                        cmd.Parameters.AddWithValue("Institution", obj.Institution);
                        cmd.Parameters.AddWithValue("StartDate", obj.StartDate);
                        cmd.Parameters.AddWithValue("EndDate", obj.EndDate);
                        cmd.Parameters.AddWithValue("JobCVId", obj.JobCVId);
                        cmd.Parameters.AddWithValue("Id", obj.id);
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
    }
}
