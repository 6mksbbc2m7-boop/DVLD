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
    public class clsInterNationalLicenses:clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsDrivers DriverInfo;
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInterNationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;


            Mode = enMode.AddNew;

        }
        public clsInterNationalLicenses(int ApplicationID,int ApplicantPersonID,DateTime ApplicationDate,
            enApplicationStatus ApplicationStatus,DateTime LastStatusDate,float PaidFees,int CreatedByUser,
            int InterNationalLicenseID,int DriverID,int IssuedUsingLocalLicenseID,DateTime IssueDate,
            DateTime ExpirationDate,bool IsActive)
        {
            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.InternationalLicenseID = InterNationalLicenseID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDrivers.FindDriverByDriverID(DriverID);

            Mode = enMode.Update;

            
        }
        private bool _AddNewInterNationalLicense()
        {
            this.InternationalLicenseID = clsInterNationalLicensesData.AddNewInternationalLicense(this.ApplicationID,this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            return (InternationalLicenseID != -1);

        }
        private bool _UpdateInterNationalLicense()
        {
            return clsInterNationalLicensesData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
               this.IssueDate, this.ExpirationDate,
               this.IsActive, this.CreatedByUserID);
        }
        public static clsInterNationalLicenses Find(int InterNationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1; int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true; int CreatedByUserID = 1;

            if (clsInterNationalLicensesData.GetInternationalLicenseInfoByID(InterNationalLicenseID, ref ApplicationID,
               ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsInterNationalLicenses(Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees,
                    Application.CreatedByUserID, InterNationalLicenseID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive);

            }
            else
                return null;
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsInterNationalLicensesData.GetAllInternationalLicenses();

        }

        public bool Save()
        {
            base.Mode = (clsApplication.enMode)Mode;
            if (!base.Save())
                return false;


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInterNationalLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInterNationalLicense();

            }

            return false;
        }
        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return clsInterNationalLicensesData.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInterNationalLicensesData.GetDriverInternationalLicenses(DriverID);
        }




    }
}
