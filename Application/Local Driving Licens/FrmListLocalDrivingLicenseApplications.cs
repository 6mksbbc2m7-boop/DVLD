using Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmListLocalDrivingLicenseApplications : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;
        public FrmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void FrmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;
            lbRecord.Text = dgLocalDrivingLicenseApplications.Rows.Count.ToString();
            if(dgLocalDrivingLicenseApplications.Rows.Count>0)
            {
                dgLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L AppID";
                dgLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgLocalDrivingLicenseApplications.Columns[1].HeaderText= "Driving Class";
                dgLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgLocalDrivingLicenseApplications.Columns[2].HeaderText= "National No.";
                dgLocalDrivingLicenseApplications.Columns[2].Width = 150;

                dgLocalDrivingLicenseApplications.Columns[3].HeaderText= "Full Name";
                dgLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgLocalDrivingLicenseApplications.Columns[4].HeaderText= "Application Date";
                dgLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgLocalDrivingLicenseApplications.Columns[5].Width = 150;




            }
            cbFilterBy.SelectedIndex = 0;
            

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn= "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }

            if(FilterColumn=="" || FilterColumn=="None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lbRecord.Text = dgLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lbRecord.Text = dgLocalDrivingLicenseApplications.Rows.Count.ToString();




        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApplicationInfo frm = new FrmLocalDrivingLicenseApplicationInfo((int)dgLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            FrmListLocalDrivingLicenseApplications_Load(null, null);
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            FrmAddUpdateLocalDrivingLicenseApplications frm = new FrmAddUpdateLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();

            FrmListLocalDrivingLicenseApplications_Load(null, null);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this Application? ","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if(localDrivingLicenseApplication !=null)
            {
                if(localDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int LocalDrivingLicenseApplicationID = (int)dgLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if(localDrivingLicenseApplication!=null)
            {
                if(localDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void scedualTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilterBy.Text != "None");

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lbRecord.Text = dgLocalDrivingLicenseApplications.Rows.Count.ToString();
        }
    }
}
