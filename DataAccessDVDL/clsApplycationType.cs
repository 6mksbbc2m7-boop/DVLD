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
    public class clsApplycationType
    {
        public static bool GetApplicationTypeInfoById(int ApplicationTypeID, ref string AppliCationTypeTitle, ref float ApplicationFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID=@ApplicationTypeID";

            SqlCommand command = new SqlCommand(quiry, connection);

            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    AppliCationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();


            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;

        }
        public static DataTable GetAllApplicationType()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"SELECT * FROM ApplicationTypes";

            SqlCommand command = new SqlCommand(quiry, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;

        }
        public static int AddNewApplicationType(string Title,float fees)
        {
            int ApplicationType = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry=@"INSERT INTO ApplicationTypes(ApplicationTypeTitle,ApplicationFees) VALUES(@Titel,@Fees); SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue(@"ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue(@"ApplicationFees", fees);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ApplicationType = InsertedID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return ApplicationType;
       






        }
        public static bool UpdateApplicationType(int ApplicationID, string Title, float Fees)
        {
            int IsUpdate = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"UPDATE ApplicationTypes
                           SET ApplicationTypeTitle=@Title,ApplicationFees=@Fees WHERE ApplicationTypeID=@ApplictionID";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue(@"ApplicationTypeID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);
            try
            {
                connection.Open();
                IsUpdate = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (IsUpdate > 0);

        }

    }
}
