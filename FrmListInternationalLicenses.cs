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
    public partial class FrmListInternationalLicenses : Form
    {
        private DataTable _dtInternationalLicenseApplications;
        public FrmListInternationalLicenses()
        {
            InitializeComponent();
        }

        private void FrmListInternationalLicenses_Load(object sender, EventArgs e)
        {
            _dtInternationalLicenseApplications = clsInterNationalLicenses.GetAllInternationalLicenses();
            cbFilterBy.SelectedIndex = 0;

            dgvListInternationalLicense.DataSource = _dtInternationalLicenseApplications;


            if (dgvListInternationalLicense.Rows.Count > 0)
            {
                dgvListInternationalLicense.Columns[0].HeaderText = "Int.License ID";
                dgvListInternationalLicense.Columns[0].Width = 160;

                dgvListInternationalLicense.Columns[1].HeaderText = "Application ID";
                dgvListInternationalLicense.Columns[1].Width = 150;

                dgvListInternationalLicense.Columns[2].HeaderText = "Driver ID";
                dgvListInternationalLicense.Columns[2].Width = 130;

                dgvListInternationalLicense.Columns[3].HeaderText = "L.License ID";
                dgvListInternationalLicense.Columns[3].Width = 130;

                dgvListInternationalLicense.Columns[4].HeaderText = "Issue Date";
                dgvListInternationalLicense.Columns[4].Width = 180;

                dgvListInternationalLicense.Columns[5].HeaderText = "Expiration Date";
                dgvListInternationalLicense.Columns[5].Width = 180;

                dgvListInternationalLicense.Columns[6].HeaderText = "Is Active";
                dgvListInternationalLicense.Columns[6].Width = 120;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                TxtFilterValue.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.Focus();
                cbIsReleased.SelectedIndex = 0;
            }

            else

            {

                TxtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsReleased.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    TxtFilterValue.Enabled = false;


                }
                else
                    TxtFilterValue.Enabled = true;

                TxtFilterValue.Text = "";
                TxtFilterValue.Focus();
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
            else
               
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    }
                    ;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            if (TxtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TxtFilterValue.Text.Trim());

        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
