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
    public partial class FrmAddUpdateLocalDrivingLicenseApplications : Form
    {
        public enum enMode { AddNew = 0, UpdateMode = 1 };
        private enMode _Mode;
        private int _LocalDrivingLicenseID = -1;
        private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public FrmAddUpdateLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FrmAddUpdateLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _LocalDrivingLicenseID = LocalDrivingLicenseApplicationID;


        }
        private void _FillLicenseClassCompoBox()
        {
            DataTable dt = new DataTable();
            dt = clsLicenseClass.GetAllLicenseClasses();
            foreach(DataRow row in dt.Rows)
            {
                cpLicenseClass.Items.Add(row["ClassName"]);
            }
        }
        private void _RessetDefualtValues()
        {
            _FillLicenseClassCompoBox();
            if(_Mode==enMode.AddNew)
            {
                lbTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                cpLicenseClass.SelectedIndex = 2;
                crtPersonCard1.FilterFocus();
                tcApplicationInfo.Enabled = true;
                lbFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicationType.NewDrivingLicense).Fees.ToString();
                lbApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lbTitle.Text = "Update Local Driving License Application";
                this.Text= "Update Local Driving License Application";
                
                tcApplicationInfo.Enabled = true;
                btSave.Enabled = true;

            }
        }
        private void _LoadData()
        {
            crtPersonCard1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(_LocalDrivingLicenseID);
            if(_LocalDrivingLicenseApplication==null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            crtPersonCard1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lbID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseID.ToString();
            lbApplicationDate.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
            lbFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lbCreatedBy.Text = clsUsers.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;

        }

        private void FrmAddUpdateLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _RessetDefualtValues();
            if(_Mode==enMode.UpdateMode)
            {
                _LoadData();
            }


        }
        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received
            _SelectedPersonID = PersonID;
            crtPersonCard1.LoadPersonInfo(_SelectedPersonID);


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClass.Find(cpLicenseClass.Text).LicenseClassID;
            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if(ActiveApplicationID !=-1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cpLicenseClass.Focus();
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = crtPersonCard1.PersonID;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;

            _LocalDrivingLicenseApplication.PaidFees =Convert.ToSingle(lbFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            if(_LocalDrivingLicenseApplication.Save())
            {
                lbID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseID.ToString();
                _Mode = enMode.UpdateMode;

                lbTitle.Text= "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void crtPersonCard1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void FrmAddUpdateLocalDrivingLicenseApplications_Activated(object sender, EventArgs e)
        {
            crtPersonCard1.FilterFocus();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.UpdateMode)
            {
                btSave.Enabled = true;
                tcApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tbApplicationInfo"];
            }
            if (crtPersonCard1.PersonID != -1)
            {

                btSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];

            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                crtPersonCard1.FilterFocus();
            }

        }
    }
}
