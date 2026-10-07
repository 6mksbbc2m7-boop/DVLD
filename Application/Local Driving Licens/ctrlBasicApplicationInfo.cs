using Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlBasicApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicense;

        private int _AppID = -1;
        private int _LocalDrivingLicenseID;
        public int LocalID
        {
            get { return _LocalDrivingLicenseID; }
        }
        public ctrlBasicApplicationInfo()
        {
            InitializeComponent();
            

        }
        public ctrlBasicApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
            _AppID = ApplicationID;

        }
        public  void ctrlBasicApplicationInfo_Load(int ApplicationID)
        {
            

            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);
            
                 lbID.Text = _LocalDrivingLicense.ApplicationID.ToString();
                lbStatus.Text = _LocalDrivingLicense.ApplicationStatus.ToString();
                lbFees.Text = _LocalDrivingLicense.PaidFees.ToString();
                lbType.Text = _LocalDrivingLicense.ApplicationTypeID.ToString();
                lbApplicant.Text = _LocalDrivingLicense.ApplicantPersonID.ToString();
                lbDate.Text = _LocalDrivingLicense.ApplicationDate.ToString();
                lbStatusDate.Text = _LocalDrivingLicense.LastStatusDate.ToString();
                lbCreatedBy.Text = _LocalDrivingLicense.CreatedByUserID.ToString();

            
           

        }

        private void gbApplicationBasicIfo_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlBasicApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
