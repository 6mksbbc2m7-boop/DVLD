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
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDrivers _Drivers;
        private DataTable _dtDriverLocalLicensesHistory;
        //private DataTable _dtDriversInternationalLicenseHistory;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {
            _dtDriverLocalLicensesHistory = clsDrivers.GetLicenses(_DriverID);
            dgLicenses.DataSource = _dtDriverLocalLicensesHistory;
            if(dgLicenses.Rows.Count>0)
            {
                dgLicenses.Columns[0].HeaderText = "Lic.ID";
                dgLicenses.Columns[0].Width = 110;

                dgLicenses.Columns[1].HeaderText = "App.ID";
                dgLicenses.Columns[1].Width = 110;

                dgLicenses.Columns[2].HeaderText = "Class Name";
                dgLicenses.Columns[2].Width = 270;

                dgLicenses.Columns[3].HeaderText = "Issue Date";
                dgLicenses.Columns[3].Width = 170;

                dgLicenses.Columns[4].HeaderText = "Expiration Date";
                dgLicenses.Columns[4].Width = 170;

                dgLicenses.Columns[5].HeaderText = "Is Active";
                dgLicenses.Columns[5].Width = 110;

            }
        }
        //private void _LoadInternationalLicenseInfo()
        //{

        //    _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);


        //    dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
        //    lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

        //    if (dgvInternationalLicensesHistory.Rows.Count > 0)
        //    {
        //        dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
        //        dgvInternationalLicensesHistory.Columns[0].Width = 160;

        //        dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
        //        dgvInternationalLicensesHistory.Columns[1].Width = 130;

        //        dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
        //        dgvInternationalLicensesHistory.Columns[2].Width = 130;

        //        dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
        //        dgvInternationalLicensesHistory.Columns[3].Width = 180;

        //        dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
        //        dgvInternationalLicensesHistory.Columns[4].Width = 180;

        //        dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
        //        dgvInternationalLicensesHistory.Columns[5].Width = 120;

        //    }
        //}

        private void gbDriverLicenses_Enter(object sender, EventArgs e)
        {

        }
        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Drivers = clsDrivers.FindDriverByDriverID(_DriverID);

            
            _LoadLocalLicenseInfo();
            //_LoadInternationalLicenseInfo();
        }
        public void LoadInfoByPersonID(int PersonID)
        {
            _Drivers = clsDrivers.FindDriverInfoByPersonID(PersonID);

            _DriverID = _Drivers.DriverID;
            _LoadLocalLicenseInfo();
            //_LoadInternationalLicenseInfo();

        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgLicenses.CurrentRow.Cells[0].Value;
            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
    }
}
