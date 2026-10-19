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
    public partial class FrmDetaindLicense : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;
        public FrmDetaindLicense()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            lbLicenseID.Text = _SelectedLicenseID.ToString();
            if(_SelectedLicenseID==-1)
            {
                return;
            }

            if(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtFindeFees.Focus();
            btDetain.Enabled = true;
        }

        private void FrmDetaindLicense_Load(object sender, EventArgs e)
        {
            lbDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void FrmDetaindLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void btDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _DetainID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFindeFees.Text), clsGlobal.CurrentUser.UserID);
            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lbDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            txtFindeFees.Enabled = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
