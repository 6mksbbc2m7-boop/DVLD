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
    public partial class FrmIssueDriverLicenseForFirstTime : Form
    {
        private int _LocalDrivingLicenseID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicense;
        public FrmIssueDriverLicenseForFirstTime(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
        }

        private void FrmIssueDriverLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseID);
            if (_LocalDrivingLicense == null)
            {

                MessageBox.Show("No Applicaiton with ID=" + _LocalDrivingLicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (!_LocalDrivingLicense.PassedAllTests())
            {

                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            int LicenseID = _LocalDrivingLicense.GetActiveLicenseID();
            if (LicenseID != -1)
            {

                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            ctrlLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(LicenseID);


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDrivingLicense.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);
            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
