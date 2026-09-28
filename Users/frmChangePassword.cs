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
    public partial class frmChangePassword : Form
    {
        
        private int _UserID;
        private clsUsers _User;



        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void  _ResetDefualtValues()
        {
            txtCurrentPasssword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPasssword.Focus();

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _User = clsUsers.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("this Person With UserID " + _UserID + "Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            ctrlUserControl1.LoadUserInfo(_UserID);
               
           
            
        }

        private void txtCurrentPasssword_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtCurrentPasssword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPasssword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPasssword, "Current Password Requier ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPasssword, null);
            }
            if(_User.Password !=txtCurrentPasssword.Text.Trim())
            {
                errorProvider1.SetError(txtCurrentPasssword, "Current Password Is Wrong");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPasssword, "");
            }

        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password Is Requier ");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim()!=txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Conformation Does Not Match New Password");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Filde Not Valid ", "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = txtNewPassword.Text;
            if(_User.Save())
            {
                MessageBox.Show("Password Changed Successfully,", "Saved", MessageBoxButtons.OK);
                _ResetDefualtValues();

            }
            else
            {
                MessageBox.Show("Error ", "Passsword Not Save ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
