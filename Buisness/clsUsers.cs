using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsBuisness;
using clsDataAccesDVDL;

namespace Buisness
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0, Update = 1, }
        public enMode Mode = enMode.AddNew;
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int UserID { get; set; }
        public bool IsActive { get; set; }


        public clsUsers()
        {
            this.UserID = -1;
            this.Password = "";
            this.UserName = "";
            this.IsActive = true;
            Mode = enMode.AddNew;

        }
        private clsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;

        }
        private bool _AddNewUser()
        {

            this.UserID = clsUserDataAcces.AddNewUser(PersonID, UserName, Password, IsActive);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAcces.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, IsActive);
        }
        public static clsUsers FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserDataAcces.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;



        }
        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserDataAcces.GetUserByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsActive)
                return new clsUsers(PersonID, UserID, UserName, Password, IsActive);
            else
                return null;
        }
        public static clsUsers FindByUserNameAndPassword(string UserName, string Password)

        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;

            bool IsFound = clsUserDataAcces.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:
                    {
                        return _UpdateUser();
                    }




            }
            return false;


        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAcces.GetAllUsers();
        }
        public static bool DeleteUserByUserID(int UserID)
        {
            return clsUserDataAcces.DeleteUser(UserID);
        }
        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAcces.IsUserExist(UserID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAcces.IsUserExist(UserName);
        }
        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserDataAcces.IsUserExistForPersonID(PersonID);
        }
    }
}
