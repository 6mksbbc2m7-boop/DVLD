using clsBuisness;
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
    public partial class FrmManagePeople : Form
    {
        
        private   DataTable _dtAllPeople = clsPerson.GetAllPeople();
        private DataTable _dtPeople;
                               
        private void _RefreshPopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople=_dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName",
                                                  "SecondName", "ThirdName", "LastName", "GendorCaption", "DateOfBirth", "CountryName", "Phone", "Email");
            dgPeople.DataSource = _dtPeople;
            lbCount.Text = dgPeople.Rows.Count.ToString();
        }
        public FrmManagePeople()
        {
            InitializeComponent();
            _RefreshPopleList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgPeople.CurrentRow.Cells["PersonID"].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
                
        }

        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            dgPeople.DataSource = _dtPeople;
            cpFilterBox.SelectedIndex = 0;
            lbCount.Text = dgPeople.Rows.Count.ToString();
            if(dgPeople.Rows.Count>0)
            {
                dgPeople.Columns[0].HeaderText = "Person ID";
                dgPeople.Columns[0].Width = 110;

                dgPeople.Columns[1].HeaderText = "National No";
                dgPeople.Columns[1].Width = 120;

                dgPeople.Columns[2].HeaderText = "First Name";
                dgPeople.Columns[2].Width = 120;

                dgPeople.Columns[3].HeaderText = "Second Name";
                dgPeople.Columns[3].Width = 120;

                dgPeople.Columns[4].HeaderText = "Third Name";
                dgPeople.Columns[4].Width = 120;

                dgPeople.Columns[5].HeaderText = "Last Name";
                dgPeople.Columns[5].Width = 120;

                dgPeople.Columns[6].HeaderText = "Gendor";
                dgPeople.Columns[6].Width = 120;

                dgPeople.Columns[7].HeaderText = "Date Of Birth ";
                dgPeople.Columns[7].Width = 140;

                dgPeople.Columns[8].HeaderText = "Nationality";
                dgPeople.Columns[8].Width = 120;

                dgPeople.Columns[9].HeaderText = "Phone";
                dgPeople.Columns[9].Width = 120;

                dgPeople.Columns[10].HeaderText = "Email";
                dgPeople.Columns[10].Width = 170;




            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPopleList();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson((int)dgPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshPopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete Person [ " + dgPeople.CurrentRow.Cells[0].Value +"] ? ","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)

            {
                if (clsPerson.DeletePerson((int)dgPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Succesfully");

                    _RefreshPopleList();

                }
                else
                    MessageBox.Show("Person not deleted because linked with other data");



            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cpFilterBox.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Second Name":
                    FilterColumn = "SecondName";
                    break;
                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Nationality":
                    FilterColumn = "CountryName";
                    break;
                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            if(txtFilter.Text.Trim()==""||FilterColumn=="None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbCount.Text = dgPeople.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lbCount.Text = dgPeople.Rows.Count.ToString();


                
        }

        private void cpFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cpFilterBox.Text != "None");
            if(txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cpFilterBox.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
