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
    public partial class FrmListDetaindLicenses : Form
    {
        private DataTable _dtDetainLicense= clsDetainedLicense.GetAllDetainedLicenses();
        public FrmListDetaindLicenses()
        {
            InitializeComponent();
        }

        private void FrmListDetaindLicenses_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            //_dtDetainLicense = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtDetainLicense;
            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 160;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 110;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 160;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 330;

                dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainedLicenses.Columns[8].Width = 150;

            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text== "Is Released")
            {
                txtFilterBy.Visible = false;
                cbIsRelease.Visible = true;
                cbIsRelease.Focus();
                cbIsRelease.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = (cbFilterBy.Text != "None");
                cbIsRelease.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterBy.Enabled = false;
                    

                }
                else
                    txtFilterBy.Enabled = true;

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }



        }

        private void cbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cbFilterBy.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    return;
                case "Is Released":
                    FilterColumn = "IsReleased";
                    return;
                case "National No":
                    FilterColumn = "NationalNo";
                    return;
                case "Full Name":
                    FilterColumn = "FullName";
                    return;
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    return;

                default:
                    FilterColumn = "None";
                    break;






            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetainLicense.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] = [1]", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] LIKE [1]", FilterColumn, txtFilterBy.Text.Trim());



        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDetainedLicenses.CurrentRow.Cells[0].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDetainedLicenses.CurrentRow.Cells[0].Value;

            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(PersonID);
            frm.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDetainedLicenses.CurrentRow.Cells[0].Value;
            FrmLicenseHistory frm = new FrmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void releasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDetainedLicenses.CurrentRow.Cells[0].Value;
            FrmReleaseDetainedLicense frm = new FrmReleaseDetainedLicense(PersonID);
            frm.ShowDialog();

            FrmListDetaindLicenses_Load(null, null);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIsRelease_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbIsRelease.Text;

            switch(FilterValue)
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
                _dtDetainLicense.DefaultView.RowFilter = "";
            else
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);



        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void releasseToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseMinue.Enabled = !(bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
        }
    }
}
