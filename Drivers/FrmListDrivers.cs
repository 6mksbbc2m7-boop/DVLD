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
    public partial class FrmListDrivers : Form
    {

        private DataTable _dtAllDrivers;
        public FrmListDrivers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmListDrivers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDrivers.GetAllDrivers();
            dgListDrivers.DataSource = _dtAllDrivers;
            if (dgListDrivers.Rows.Count > 0)
            {
                dgListDrivers.Columns[0].HeaderText = "Driver ID";
                dgListDrivers.Columns[0].Width = 120;

                dgListDrivers.Columns[1].HeaderText = "Person ID";
                dgListDrivers.Columns[1].Width = 120;

                dgListDrivers.Columns[2].HeaderText = "National No.";
                dgListDrivers.Columns[2].Width = 140;

                dgListDrivers.Columns[3].HeaderText = "Full Name";
                dgListDrivers.Columns[3].Width = 320;

                dgListDrivers.Columns[4].HeaderText = "Date";
                dgListDrivers.Columns[4].Width = 170;

                dgListDrivers.Columns[5].HeaderText = "Active Licenses";
                dgListDrivers.Columns[5].Width = 150;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFilter.Visible = (cbFilterBy.Text != "None");
            if (cbFilterBy.Text == "None")
                TxtFilter.Enabled = false;
            else
                TxtFilter.Enabled = true;

            TxtFilter.Text = "";
            TxtFilter.Focus();

        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            string Filtercolumn = "";
            switch(cbFilterBy.Text)
            {
                case "Driver ID":
                    Filtercolumn = "DriverID";
                    break;
                case "Person ID":
                    Filtercolumn = "PersonID";
                    break;
                case "National No":
                    Filtercolumn = "NationalNo";
                    break;
                case "Full Name":
                    Filtercolumn = "FullName";
                    break;
                default:
                    Filtercolumn = "None";
                    break;
            }

            if (Filtercolumn == "" && cbFilterBy.Text.Trim() == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                return;
            }

            if (Filtercolumn != "FullName" && Filtercolumn == "NationalNo")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Filtercolumn, TxtFilter.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Filtercolumn, TxtFilter.Text.Trim());



        }

        private void TxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgListDrivers.CurrentRow.Cells[1].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();

            FrmListDrivers_Load(null, null);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID =(int) dgListDrivers.CurrentRow.Cells[0].Value;
            FrmLicenseHistory frm = new FrmLicenseHistory(PersonID);
            frm.ShowDialog();

        }
    }
}
