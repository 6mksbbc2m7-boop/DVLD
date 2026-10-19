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
    public partial class FrmRenewDriverLicenseInfo : Form
    {
        private int _NewLicenseID = -1;

        public FrmRenewDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

            lbAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbIssueDATE.Text = lbAppDate.Text;
            lbExpirationDate.Text = "????";
            lbAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;

        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLiceseID = obj;

            lbOldLicenseID.Text = SelectedLiceseID.ToString();
            LLShowLicenseHistory.Enabled = (SelectedLiceseID != -1);
            if(SelectedLiceseID ==-1)
            {
                return;
            }
            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            lbExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lbLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbAppFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btRenew.Enabled = false;
                return;
            }
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btRenew.Enabled = false;
                return;
            }

            btRenew.Enabled = true;





        }

        private void btRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text, clsGlobal.CurrentUser.UserID);
            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            LbRLAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lbRenewLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowNewLicenseInfo.Enabled = true;


        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
