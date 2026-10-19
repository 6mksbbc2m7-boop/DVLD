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
    public partial class FrmLicenseHistory : Form
    {
        private int _PersonID;
        private clsDrivers _Drivers;
        public FrmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        

        private void FrmLicenseHistory_Load(object sender, EventArgs e)
        {

        }
        public  void FrmLicenseHistory_Load(int PersonID)
        {
            if (_PersonID != -1)
            {
                crtPersonCard1.LoadPersonInfo(_PersonID);
                crtPersonCard1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                crtPersonCard1.FilterEnabled = true;
                crtPersonCard1.FilterFocus();
            }



        }

        private void crtPersonCard1_OnPersonSelected(int obj)
        {
            _PersonID= obj;

            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
            {
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
