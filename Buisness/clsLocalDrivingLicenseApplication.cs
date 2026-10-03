using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness;
using DataAccessDVD;

namespace Buisness
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseID { set; get; }
        public int LicenseClassID { set; get; }
        public string PersonFullName
        {
            get
            {
                return base.personInfo.FullName;
            }
            
        }
        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.AddNew;
        }
        private clsLocalDrivingLicenseApplication(int LocalDrivingLicensID,int ApplicationID,int ApplicantPersonID,int ApplicationTypeID,
            DateTime ApplicationDate,enApplicationStatus ApplicationStatus,DateTime LastStatusDate,float PaidFees,int CreatedByUserID,
            int LicenseClassID)
        {
            this.LocalDrivingLicenseID = LocalDrivingLicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationTypeID =(int) ApplicationTypeID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;

            Mode = enMode.Update;

        }
        private bool _AddnewLocalDrivingApplication()
        {
            this.LocalDrivingLicenseID = clsLocalDrivingLicenseData.AddNewLocalDrivingLicenseApplication(this.ApplicationID,
                this.LicenseClassID);
            return (this.LocalDrivingLicenseID != -1);

        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseID,
                this.ApplicationID, this.LicenseClassID);

        }
        public static clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, licenseclassID = -1;

            bool IsFound = clsLocalDrivingLicenseData.GetLocalDrivingLicenseApplicationInfoByApplicationID(LocalDrivingLicenseApplicationID,
                ref ApplicationID, ref licenseclassID);

            if (IsFound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                      Application.ApplicationTypeID, Application.ApplicationDate,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                         Application.PaidFees, Application.CreatedByUserID, licenseclassID);

            }
            else
                return null;



        }
        public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1, LicenseclassID = -1;

            bool Isfound = clsLocalDrivingLicenseData.GetLocalDrivingLicenseApplicationInfoByID(ApplicationID,
                ref LocalDrivingLicenseApplicationID, ref LicenseclassID);

            if (Isfound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID, Application.ApplicationTypeID, Application.ApplicationDate,
                   (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                   Application.PaidFees, Application.CreatedByUserID, LicenseclassID);
            }
            else
                return null;
        }
        public bool Save()
        {
            base.Mode = (clsApplication.enMode)Mode;
            if (!base.Save())
                return false;
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddnewLocalDrivingApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return false;
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

        }
        public  bool Delete()
        {
            bool IslocalDrivingLicenseDeleted = false;
            bool IsBaseApplicationDeleted = false;

            IslocalDrivingLicenseDeleted = clsLocalDrivingLicenseData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseID);
            if (!IslocalDrivingLicenseDeleted)
                return false;

            IsBaseApplicationDeleted = base.Delete();

            return IsBaseApplicationDeleted;




        }







    }
}
