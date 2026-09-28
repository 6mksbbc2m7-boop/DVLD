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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindByUserNameAndPassword(txtUserName.Text.Trim(), txtPassowrd.Text.Trim());
            if(User!=null)
            {
                if(chRemeberme.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassowrd.Text.Trim());

                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if(!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your Account Not Active ,Please Contact Your Admin");
                    return;
                }

                clsGlobal.CurrentUser = User;
                this.Hide();
                frmMainForm frm = new frmMainForm(this);
                frm.ShowDialog();

            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";
            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassowrd.Text = Password;
                chRemeberme.Checked = true;
            }
            else
                chRemeberme.Checked = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
