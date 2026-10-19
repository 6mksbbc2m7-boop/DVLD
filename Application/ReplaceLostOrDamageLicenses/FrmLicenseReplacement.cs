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
using static Buisness.clsLicense;

namespace DVLD
{
    public partial class FrmLicenseReplacement : Form
    {
        private int _NewLicenseID = -1;
        public FrmLicenseReplacement()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            if (rdDamageLicense.Checked)
                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }
        private void FrmLicenseReplacement_Load(object sender, EventArgs e)
        {
            lbApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            rdDamageLicense.Checked = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdDamageLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement For Damage License";
            this.Text = lbTitle.Text;
            lbApplicationFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString();

        }

        private void rdLoseLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement For Lost License";
            this.Text = lbTitle.Text;
            lbApplicationFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString();


        }
        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rdDamageLicense.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lbOldLicense.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);
            if (SelectedLicenseID == -1)
            {
                return;
            }
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btIssueReplacement.Enabled = false;
                return;
            }

            btIssueReplacement.Enabled = true;

        }

        private void btIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(),
                clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lbLicenseApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            btIssueReplacement.Enabled = false;
            gbReplacementfor.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicense.Enabled = false;


        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
