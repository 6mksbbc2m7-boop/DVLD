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
    public partial class ctrlUserControl : UserControl
    {
        private clsUsers _User;
        private int _UserId = -1;
        public int UserID
        {
            get { return _UserId; }
        }

        public ctrlUserControl()
        {
            InitializeComponent();
        }

        private void ctrlUserControl_Load(object sender, EventArgs e)
        {
            

        }
        public void LoadUserInfo(int UserID)
        {
            _User = clsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                _RessetUserInfo();
                MessageBox.Show("No User With UserID " + UserID.ToString() + " ! ");
                return;
            }
            _FillUserInfo();
        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.ctrlPersonCard_Load(_User.PersonID);
            lbUserID.Text = _User.UserID.ToString();
            lbUserName.Text = _User.UserName.ToString();
            if (_User.IsActive)
                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";
        }
        private void _RessetUserInfo()
        {
            ctrlPersonCard1._ResetPersonInfo();
            lbUserID.Text = "????";
            lbUserName.Text = "????";
            lbIsActive.Text = "????";

            
        }
    }
}
