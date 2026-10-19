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
    public partial class FrmReleaseDetainedLicense : Form
    {
        private int _SelectedLiceneID;
        public FrmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public FrmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLiceneID = LicenseID;
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(LicenseID);

            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLiceneID = obj;

            lbLicenseID.Text = _SelectedLiceneID.ToString();

            if(_SelectedLiceneID==-1)
            {
                return;
            }

            if(!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License  is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            lbFApplicationFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lbDetainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.LicenseID.ToString();
            lbCreatedBy.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            lbDetainDate.Text = clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate);
            lbFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbFApplicationFees.Text) + Convert.ToSingle(lbFineFees.Text)).ToString();


            btRelease.Enabled = false;
        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            bool IsReleased = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID);

            lbApplicationID.Text = ApplicationID.ToString();
            if(!IsReleased)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
