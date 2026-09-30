using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccesDVDL;

namespace DataAccessDVD
{
    public  class clsTestTypes
    {
        public static bool GetTestTypeInfoByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"SELECT * FROM TestTypes WHERE TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue(@"TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestFees = Convert.ToSingle(reader["TestTypeFees"]);
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();


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
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = "SELECT * FROM TestTypes order by TestTypeID";
            SqlCommand command = new SqlCommand(quiry, connection);
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
        public static int AddnewTestType(string Title,string Description,float Fees )
        {
            int TestTypeID = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"Insert Into TestTypes (TestTypeTitle,TestTypeTitle,TestTypeFees)
                            Values (@TestTypeTitle,@TestTypeDescription,@ApplicationFees)
                            where TestTypeID = @TestTypeID;
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result!=null &&int.TryParse(result.ToString(), out int InsertedID))
                {
                    TestTypeID = InsertedID;

                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TestTypeID;
        }
        public static bool UpdateTestType(int TestTypeID,string TestTypeTitle,string TestTypeDescription,float TestTypeFees)
        {
            int RowEffected = 0;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"UPDATE TestTypes set
                            TestTypeTitle=@TestTypeTitl,
                            TestTypeDescription=@TestTypeDescriptio,
                            TestTypeFees=@TestTypeFees
                            Where TestTypeID=@TestTypeID ";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (RowEffected > 0);


        }
    }
}
