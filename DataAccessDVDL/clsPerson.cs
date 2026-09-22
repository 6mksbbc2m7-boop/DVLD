
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using clsDataAccesDVDL;





        public class clsPersonData
        {
            public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string
                ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth, ref short Gendor, ref string Address,
                ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
            {
                bool IsFound = false;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = "SELECT * FROM People Where PersonID=@PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        IsFound = true;
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        if (reader["ThirdName"] != DBNull.Value)
                        {
                            ThirdName = (string)reader["ThirdName"];
                        }
                        else
                        {
                            ThirdName = "";
                        }
                        LastName = (string)reader["LastName"];
                        NationalNo = (string)reader["NationalNo"];
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                        Gendor = (byte)reader["Gandor"];
                        Address = (string)reader["Address"];
                        Phone = (string)reader["Phone"];
                        if (reader["Email"] != DBNull.Value)
                        {
                            Email = (string)reader["Email"];
                        }
                        else
                        {
                            Email = "";

                        }
                        NationalityCountryID = (int)reader["NationalityCountryID"];
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = (string)reader["ImagePath"];
                        }
                        else
                        {
                            ImagePath = "";
                        }



                    }
                    else
                    {
                        IsFound = false;
                    }
                }
                catch (Exception Ex)
                {
                    IsFound = false;
                }
                finally
                {
                    connection.Close();
                }
                return IsFound;


            }
            public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string
                ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address,
                ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
            {
                bool IsFound = false;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string Query = "SELECT * FROM People WHERE NationalNo=@NationalNo";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        IsFound = true;
                        PersonID = (int)reader["PersonID"];
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        if (reader["ThirdName"] != DBNull.Value)
                        {
                            ThirdName = (string)reader["ThirdName"];
                        }
                        else
                        {
                            ThirdName = "";
                        }
                        LastName = (string)reader["LastName"];
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                        Gendor = (byte)reader["Gandor"];
                        Address = (string)reader["Address"];
                        Phone = (string)reader["Phone"];
                        if (reader["Email"] != DBNull.Value)
                        {
                            Email = (string)reader["Email"];
                        }
                        else
                        {
                            Email = "";
                        }
                        NationalityCountryID = (int)reader["NationalityCountryID"];
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = (string)reader["ImagePath"];
                        }
                        else
                        {
                            ImagePath = "";
                        }


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
                return false;
            }
            public static int AddNewPerson(string FirstName, string SecondName, string
                ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, short Gendor, string Address,
                 string Phone, string Email, int NationalityCountryID, string ImagePath)
            {
                int PersonID = -1;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"INSERT INTO ( FirstName,SecondName,
                ThirdName,  LastName,   NationalNo,  DateOfBirth,Gendor, Address,
                 Phone,  Email, NationalityCountryID, ImagePath),
                           VALUES(@FirstName,@SecondName,
                @ThirdName,@LastName,@NationalNo,@DateOfBirth,@Gendor, @Address,
                @Phone,@Email, @NationalityCountryID, @ImagePath),
                           SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                if (ThirdName != null && ThirdName != "")
                {
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                }
                else
                {
                    ThirdName = "";
                }
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                if (Email != "" && Email != null)
                {
                    command.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    Email = "";
                }
                command.Parameters.AddWithValue("@NationalCountryID", NationalityCountryID);
                if (ImagePath != null && ImagePath != "")
                {
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                }
                else
                {
                    ImagePath = "";
                }
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    {
                        PersonID = InsertedID;

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
                return PersonID;

            }
            public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string
                ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, short Gendor, string Address,
                 string Phone, string Email, int NationalityCountryID, string ImagePath)
            {
                int RowsAffected = 0;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"Update People
                             set FirstName=@FirstName,
                                 SecondName=@SecondName,
                                 ThirdName=@ThirdName,
                                 LastName=@LastName
                                 NationalNo=@NationalNo,
                                 DateOfBirth=@DateOfBirth,
                                 Gendor=@Gendor,
                                 Address=@Address,
                                 Phone=@Phone,
                                 Email=@Email,
                                 NationalityCountryID=@NationalityCountryID,
                                 ImagePath=@ImagePath
                                 Where PersonID=@PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                if (ThirdName != null && ThirdName != "")
                {
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                }
                else
                {
                    ThirdName = "";
                }
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                if (Email != "" && Email != null)
                {
                    command.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    Email = "";
                }
                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                if (ImagePath != null && ImagePath != "")
                {
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                }
                else
                {
                    ImagePath = "";
                }
                try
                {
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
                return (RowsAffected > 0);

            }
            public static DataTable GetAllPeople()
            {
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"SELECT  People.PersonID,People.NationalNo,
                          People.FirstName,People.SecondName.People.ThirdName,People.LastName,People.DateOfBirth,
                          People.Gendor,
                          CASE
                          WHERE People.Gendor=0 THEN 'Male'
                          ELSE Female
                          END AS GendorCaption,
                          People.Address,People.Phone,People.Email,People.NationalityCountryID,
                          Countries.CountryName,People.ImagePath,
                          FROM People INNER JOIN Countries ON People.NationalityCountryID=Countries.CountryID
                          ORDER BY People.FirstName";
                SqlCommand command = new SqlCommand(query, connection);
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
            public static bool DeletePeople(int PersonID)
            {
                int RowAffectted = 0;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"Delete People
                             where PersonID=PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    RowAffectted = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
                return (RowAffectted > 0);
            }
            public static bool IsPersonExist(int PersonID)
            {
                bool Isfound = false;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"SELECT Found=1 People WHERE PersonID=@PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Isfound = reader.HasRows;
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Isfound = false;
                }
                finally
                {
                    connection.Close();
                }
                return Isfound;

            }
            public static bool IsPersonExist(string NationalNo)
            {
                bool Isfound = false;
                SqlConnection connection = new SqlConnection(ConnectionStringBuilder.ConnectionString);
                string query = @"SELECT Found=1 People WHERE NationalNo=NationalNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Isfound = reader.HasRows;
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Isfound = false;
                }
                finally
                {
                    connection.Close();
                }
                return Isfound;

            }

        }





 
