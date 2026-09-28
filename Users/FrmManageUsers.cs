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
    public partial class FrmManageUsers : Form
    {
        static DataTable _dtAllUsers;
        public FrmManageUsers()
        {
            InitializeComponent();
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUsers frm = new FrmAddUpdateUsers();
            frm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo frm = new FrmUserInfo((int)dtListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUsers frm = new FrmAddUpdateUsers();
            frm.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson Frm = new FrmAddUpdatePerson((int)dtListUsers.CurrentRow.Cells[0].Value);
            Frm.ShowDialog();
            FrmManageUsers_Load(null, null);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)(dtListUsers.CurrentRow.Cells[0].Value);
            frmChangePassword frm = new frmChangePassword(UserID);
        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUsers.GetAllUsers();
            dtListUsers.DataSource = _dtAllUsers;
            lbRecords.Text = dtListUsers.Rows.Count.ToString();
            cbFilterBY.SelectedIndex = 0;
            if (dtListUsers.Rows.Count > 0)
            {
                dtListUsers.Columns[0].HeaderText = "User ID";
                dtListUsers.Columns[0].Width = 110;

                dtListUsers.Columns[1].HeaderText = "Person ID";
                dtListUsers.Columns[1].Width = 120;

                dtListUsers.Columns[2].HeaderText = "Full Name";
                dtListUsers.Columns[2].Width = 350;

                dtListUsers.Columns[3].HeaderText = "User Name";
                dtListUsers.Columns[3].Width = 120;

                dtListUsers.Columns[4].HeaderText = "Is Active";
                dtListUsers.Columns[4].Width = 120;

            }


        }

        private void cbFilterBY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBY.Text.Trim() == "Is Active")
            {
                txtFilterBy.Visible = false;
                cpIsActive.Visible = true;
                cpIsActive.Focus();
                cpIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = (cbFilterBY.Text != "None");
                cpIsActive.Visible = false;
                txtFilterBy.Text = "";
                txtFilterBy.Focus();

            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBY.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lbRecords.Text = dtListUsers.Rows.Count.ToString();
                return;
            }
            if (FilterColumn != "UserName" && FilterColumn != "FullName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lbRecords.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void cpIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cpIsActive.Text;

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, FilterValue);
            lbRecords.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)(dtListUsers.CurrentRow.Cells[0].Value);
            if(clsUsers.DeleteUserByUserID(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmManageUsers_Load(null, null);
            }

            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBY.Text == "Person ID" || cbFilterBY.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
