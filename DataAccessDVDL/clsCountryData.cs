using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace clsDataAccesDVDL
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID,ref string CountryName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string query = @"SELECT * FROM Countries WHERE CountryID=@CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                   
                    CountryName = (string)reader["CountryName"];
                    reader.Close();
                }
                else
                {
                    IsFound = false;
                }
            }
            catch(Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool GetCountryInfoByName(string CountryName,ref int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string query = @"SELECT * FROM Countries WHERE CountryName=CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["CountryID"];
                    CountryName = (string)reader["CountryName"];
                    reader.Close();
                }
                else
                {
                    IsFound = false;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string query = @"SELECT * FROM Countries ORDER BY CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

    }

    
}
