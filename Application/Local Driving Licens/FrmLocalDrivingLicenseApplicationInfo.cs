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
    public partial class FrmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _ApplicationID;
        public FrmLocalDrivingLicenseApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void FrmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_ApplicationID);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
