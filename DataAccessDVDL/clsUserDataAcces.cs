using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clsDataAccesDVDL
{
    public  class clsUserDataAcces
    {
        public static bool GetUserInfoByID(int UserID,ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string query = @"SELECT * Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
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
        public static bool GetUserByPersonID(int PersonID,ref int UserID,ref string UserName,ref string Password,ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string Quiery = @"SELECT * FROM Users WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Quiery, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
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
        public static bool GetUserInfoByUserNameAndPassword(string UserName,string Password,ref int PersonID,ref int UserID,ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiery = @"SELECT * FROM Users WHERE UserName=@UserName and Password=@Password;";
            SqlCommand command = new SqlCommand(quiery, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

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
       

    }


}
