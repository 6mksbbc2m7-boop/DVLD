using Buisness;
using DVLD.Properties;
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
    public partial class FrmListTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public FrmListTestAppointments(int LocalDrivingLicenseApplicationID,clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch(_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        lbTitle.Text="Vision Test Appointments";
                        this.Text = lbTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    }
                case clsTestType.enTestType.WritenTest:
                    {
                        lbTitle.Text = "Written Test Appointments";
                        this.Text = lbTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lbTitle.Text = "Street Test Appointments";
                        this.Text = lbTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;



                    }
            }
        }

        private void FrmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            ctrlLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID,_TestType);

            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }

        }

        private void btAddNewTest_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);


            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTests LastTest = localDrivingLicenseApplication.GetLastTestByPerTestType(_TestType);

            if (LastTest == null)
            {
               FrmScheduleTest frm1 = new FrmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                FrmListTestAppointments_Load(null, null);
                return;
            }


            if (LastTest.TestResult == true && LastTest==null)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmScheduleTest frm2 = new FrmScheduleTest
            (LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            FrmListTestAppointments_Load(null, null);
           

        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointment = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            FrmScheduleTest frm = new FrmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointment);
            frm.ShowDialog();
            FrmListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLicenseTestAppointments.CurrentRow.Cells[0].Value == null||dgvLicenseTestAppointments.CurrentRow==null)
            {  
                MessageBox.Show("please select a valid test frist!");
                return;
            }
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            FrmTakeTest frm = new FrmTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();

            FrmListTestAppointments_Load(null, null);


        }

        private void ctrlLocalDrivingLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
