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
    public partial class ctrlSchedulTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enCreationMode { FirstTimeSchedule =0, RetakeTestSchedule =1};
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment _TestAppointment;
        private int _TestAppointmentID = -1;

        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                switch(_TestTypeID)
                {
                    case clsTestType.enTestType.VisionTest:
                        {
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }
                    case clsTestType.enTestType.WritenTest:
                        {
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;
                        }
                }
            }
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btSave.Enabled = false;
                return false;
            }

            lbFees.Text = _TestAppointment.PaidFees.ToString();

            
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtTIme.MinDate = DateTime.Now;
            else
                dtTIme.MinDate = _TestAppointment.AppointmentDate;

            dtTIme.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lbRAppFees.Text = "0";
                lbRTestAppID.Text = "N/A";
            }
            else
            {
                lbRAppFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
              
                lbDescription.Text = "Schedule Retake Test";
                lbRTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }
        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
           
            if (AppointmentID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btSave.Enabled = false;
                return;
            }

           
            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))

                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;


            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lbFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).Fees.ToString();

                lbDescription.Text = "Schedule Retake Test";
                lbRAppFees.Text = "0";
            }
            else
            {

                lbDescription.Text = "Schedule Test";
                lbFees.Text = "0";
                lbRAppFees.Text = "N/A";
            }

            lbDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseID.ToString();
            lbDClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lbName.Text = _LocalDrivingLicenseApplication.PersonFullName;

            
            lbTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();


            if (Mode == enMode.AddNew)
            {
                lbFees.Text = clsTestType.Find(_TestTypeID).Fees.ToString();
                dtTIme.MinDate = DateTime.Now;
                lbRTestAppID.Text = "N/A";

                _TestAppointment = new clsTestAppointment();
            }

            else
            {

                if (!_LoadTestAppointmentData())
                    return;
            }
            lbTotalFees.Text = (Convert.ToSingle(lbFees.Text) + Convert.ToSingle(lbRAppFees.Text)).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                lbDescription.Text = "Person Already have an active appointment for this test";
                btSave.Enabled = false;
                dtTIme.Enabled = false;
                return false;
            }

            return true;
        }
         private bool _HandleAppointmentLockedConstraint()
        {
           
            if (_TestAppointment.IsLocked)
            {
                lbDescription.Visible = true;
                lbDescription.Text = "Person already sat for the test, appointment loacked.";
                dtTIme.Enabled = false;
                btSave.Enabled = false;
                return false;

            }
            else
                lbDescription.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
           

            switch (TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                   
                    lbDescription.Visible = false;

                    return true;

                case clsTestType.enTestType.WritenTest:
                    
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest))
                    {
                        lbDescription.Text = "Cannot Sechule, Vision Test should be passed first";
                        lbDescription.Visible = true;
                        btSave.Enabled = false;
                        dtTIme.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbDescription.Visible = false;
                        btSave.Enabled = true;
                        dtTIme.Enabled = true;
                    }


                    return true;

                case clsTestType.enTestType.StreetTest:

                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WritenTest))
                    {
                        lbDescription.Text = "Cannot Sechule, Written Test should be passed first";
                        lbDescription.Visible = true;
                        btSave.Enabled = false;
                        dtTIme.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbDescription.Visible = false;
                        btSave.Enabled = true;
                        dtTIme.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        private bool _HandleRetakeApplication()
        {
            
            if (Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                
                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }

        public ctrlSchedulTest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbFees_Click(object sender, EventArgs e)
        {

        }

        private void lbTestAppID_Click(object sender, EventArgs e)
        {

        }

        private void ctrlSchedulTest_Load(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseID;
            _TestAppointment.AppointmentDate = dtTIme.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lbFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_TestAppointment.Save())
            {
                Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    }

