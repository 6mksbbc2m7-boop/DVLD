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
    public partial class ctrlLocalDrivingLicenseInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseID = -1;
        private int _LicenseID = -1;
        public int LocalDrivingLicenseID
        {
            get { return _LocalDrivingLicenseID; }
        }

        public ctrlLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            //_LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();
            lbDLApplicationID.Text= _LocalDrivingLicenseApplication.LocalDrivingLicenseID.ToString();
            lbAppliedForLicense.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            //lbPassodTest.Text=_LocalDrivingLicenseApplication.
            ctrlBasicApplicationInfo1.ctrlBasicApplicationInfo_Load(_LocalDrivingLicenseApplication.ApplicationID);
        }
        private void lbStatusDate_Click(object sender, EventArgs e)
        {

        }

        private void ctrlLocalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {

        }
        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseID);
            if(_LocalDrivingLicenseApplication ==null)
            {
                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();
        }
        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();
        }
    }
}
