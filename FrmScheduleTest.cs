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
    public partial class FrmScheduleTest : Form
    {
        private int _LocalDrivingLicenseID = -1;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private int _AppointmentID = -1;
        public FrmScheduleTest(int LocalDrivingLicenseID,clsTestType.enTestType testTypeID,int AppointmentID=-1)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _TestTypeID = testTypeID;
            _AppointmentID = AppointmentID;

        }

        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlSchedulTest1.TestTypeID = _TestTypeID;
            ctrlSchedulTest1.LoadInfo(_LocalDrivingLicenseID,_AppointmentID);

        }
    }
}
