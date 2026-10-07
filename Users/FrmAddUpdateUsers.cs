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
    public partial class FrmAddUpdateUsers : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUsers _User;
        
        public FrmAddUpdateUsers()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            

        }
        public FrmAddUpdateUsers(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
        }
        
        private void _LoadData()
        {
            _User = clsUsers.FindByUserID(_UserID);
            crtPersonCard1.FilterEnabled = false;
            if(_User==null)
            {
                MessageBox.Show("No User With This ID " + _User + "check another User,");
                this.Close();
                return;
            }
            lbUserID.Text = _User.UserID.ToString();
            txUserName.Text = _User.UserName;
            txPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            rdtIsActive.Checked = _User.IsActive;
            crtPersonCard1.LoadPersonInfo(_User.PersonID);




        }
        private void _RefreshDefualtValue()
        {
            if(_Mode==enMode.AddNew)
            {
                lbTitle.Text = "Add New User ";
                this.Text = "Add New User ";
                _User = new clsUsers();
                tbLoginInfo.Enabled = false;
                crtPersonCard1.FilterFocus();

            }
            else
            {
                lbTitle.Text = "Update User ";
                this.Text = "Update User ";
                tbLoginInfo.Enabled = true;
                btSave.Enabled = true;
            }
            txUserName.Text = "";
            txPassword.Text = "";
            txtConfirmPassword.Text = "";
            rdtIsActive.Checked = true;
            

        }
        

        private void FrmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _RefreshDefualtValue();
            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.Update)
            {
                btSave.Enabled = true;
                tbLoginInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tbLoginInfo"];
                return;
            }
            if (crtPersonCard1.PersonID != -1)
            {
                if(clsUsers.IsUserExistForPersonID(crtPersonCard1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    crtPersonCard1.FilterFocus();
                }
                else
                {
                    btSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tbLoginInfo"];
                }
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.PersonID = crtPersonCard1.PersonID;
            _User.UserName = txUserName.Text.Trim();
            _User.Password = txPassword.Text.Trim();
            _User.IsActive = rdtIsActive.Checked;
            if(_User.Save())
            {
                lbUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lbTitle.Text = "Update User ";
                this.Text = "Update User ";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
            ;
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txPassword, null);
            }
        }

        private void txUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txUserName, "User Name Cannot be blank ");
            }
            else
                errorProvider1.SetError(txUserName, null);
            if (_Mode == enMode.AddNew)
            {

                if (clsUsers.IsUserExist(txUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txUserName, null);
                }
                ;
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txUserName.Text.Trim())
                {
                    if (clsUsers.IsUserExist(txUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txUserName, null);
                    }
                    ;
                }
            }
        }

        private void FrmAddUpdateUsers_Activated(object sender, EventArgs e)
        {
            crtPersonCard1.Focus();
        }

        private void crtPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
