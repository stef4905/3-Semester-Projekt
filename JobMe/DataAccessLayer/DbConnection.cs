using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DbConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        private string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public DbConnection()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(ConnectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteReader();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.WriteLine("error - Connection.excuteSelectQuery - Query: " + query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            return dataTable;
        }

        private bool ExecuteInsertQuery(string InsertQuery, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = InsertQuery;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("error - Connection.excuteSelectQuery - Query: " + InsertQuery + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool ExecuteUpdateQuery(string UpdateQuery, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = UpdateQuery;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("error - Connection.excuteSelectQuery - Query: " + UpdateQuery + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool ExecuteDeleteQuery(string DeleteQuery, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = DeleteQuery;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("error - Connection.excuteSelectQuery - Query: " + DeleteQuery + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

    }
}
