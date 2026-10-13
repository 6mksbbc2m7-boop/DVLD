using clsBuisness;
using DataAccessDVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness
{
    public class clsDrivers
    {
        public enum enMode {Addnew=0,Update=1 };
        private enMode _Mode = enMode.Addnew;
        public clsPerson PersonInfo;
        public int  DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedBy { set; get; }
        public DateTime CreatedDate { get; }
        public clsDrivers()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedBy = -1;
            this.CreatedDate = DateTime.Now;
            _Mode = enMode.Addnew;
        }
        private clsDrivers(int DriverID,int PersonID,int CreatedBy, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedBy = CreatedBy;
            this.CreatedDate = CreatedDate;
            this.PersonInfo = clsPerson.Find(PersonID);
           _Mode = enMode.Update;
        }
        private bool _AddnewDriver()
        {
            this.DriverID = clsDriversData.AddNewDriver(PersonID, CreatedBy);

            return (this.DriverID != -1);
            

        }
        private bool _UpdateDriver ()
        {
            return clsDriversData.UpdateDirver(this.DriverID, this.PersonID, this.CreatedBy);
        }
        public static clsDrivers FindDriverByDriverID(int DriverID)
        {
            int PersonID=-1, CreatedBy = -1;
            DateTime CreatedDate = DateTime.Now;
            bool Isfound = clsDriversData.GetDriverInfoByDriverID(DriverID,ref PersonID,ref CreatedBy,ref CreatedDate);

            if (Isfound)
                return new clsDrivers(DriverID, PersonID, CreatedBy, CreatedDate);
            else
                return null;
        }
        public static clsDrivers FindDriverInfoByPersonID(int PersonID)
        {
            int DriverID=-1, CreatedBy = -1;
            DateTime CreatedDate = DateTime.Now;

            bool Isfound = clsDriversData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedBy, ref CreatedDate);
            if (Isfound)
                return new clsDrivers(DriverID, PersonID, CreatedBy, CreatedDate);
            else
                return null;

        }
        public static DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Addnew:
                    if(_AddnewDriver())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateDriver();

                   
                    
            }
            return false;
        }
        public static DataTable GetLicenses(int DriverID)
        {
           return clsLicenseData.GetDriverLicenses(DriverID);
        }

        //public static DataTable GetInternationalLicenses(int DriverID)
        //{
        //    return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        //}



    }
}
