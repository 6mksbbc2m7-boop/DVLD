using clsDataAccesDVDL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDVD
{
    public class clsApplicationData
    {
        public static bool GetApplicationInfoByID(int ApplicationID,ref int ApplicationPersonID,ref DateTime ApplicationDate,
             ref int ApplicationTypeID,ref byte ApplicationStatus,ref DateTime LastStatusDate,ref float PaidFees,ref int CreatedByUserID)
        {
            bool Isfound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"SELECT * FROM Applications WHERE ApplicationID=@ApplicationID";


            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Isfound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicationPersonID = (int)reader["ApplicationID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }
                else
                {
                    Isfound = false;
                }
                    reader.Close();
            }
            catch(Exception ex)
            {
                Isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return Isfound;

        }
        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"select * from Applications order by Applications desc";

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
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;


        }
        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue(" @CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result !=null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    ApplicationID = InsertedID;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Open();
            }
            return ApplicationID; 


        }
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            byte ApplicationStatus, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            int RowEffected = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            command.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            command.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            command.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            command.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            command.Parameters.AddWithValue("PaidFees", @PaidFees);
            command.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);
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
        public static bool DeleteApplication(int ApplicationID)
        {
            int RowEffected = 0;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"Delet Applications
                           where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowEffected > 0);


        }
        public static bool IsApplicationExist(int ApplicationID)
        {
            bool Isfound = false;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Isfound = reader.HasRows;

                reader.Close();

            }
            catch(Exception ex)
            {
                Isfound = false;

            }
            finally
            {
                connection.Close();
            }
            return Isfound;

        }
        public static bool DoesPersonHasActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return (GetActiveApplicationID(PersonID, ApplicationTypeID) != -1);
        }
          
        public static int  GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = "SELECT ActiveApplicationID=ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(quiry, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result !=null && int.TryParse(result.ToString(),out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch(Exception ex)
            {
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }
            return ApplicationTypeID;

        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
            string quiry = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";
            SqlCommand command = new SqlCommand(quiry, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result !=null && int.TryParse(result.ToString(),out int AppID))
                {
                    ActiveApplicationID = AppID;

                }
            }
            catch(Exception ex)
            {
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }
            return ActiveApplicationID;

        }
        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {
            int RowEffected = 0;
            SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
             string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
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
