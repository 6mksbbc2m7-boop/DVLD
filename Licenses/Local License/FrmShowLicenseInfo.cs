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
    public partial class FrmShowLicenseInfo : Form
    {
        private int _LicenseID = -1;
        public FrmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void FrmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);

        }
    }
}
