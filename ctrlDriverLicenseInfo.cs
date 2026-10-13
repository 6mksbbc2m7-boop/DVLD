using Buisness;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicense _License;
        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbImage.Image = Resources.Boy;
            else
                pbImage.Image = Resources.Girl;
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);
            if(_License==null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }
            lbClass.Text = _License.LicenseClassIfo.ClassName;
            lbFullName.Text = _License.DriverInfo.PersonInfo.FullName;
            lbLicenseID.Text = _License.DriverID.ToString();
            lbNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNO;
            lbGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lbIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lbIssueReason.Text = _License.IssueReasonText==""?"No Reason":_License.IssueReasonText;
            lbNotes.Text = _License.Notes;
            lbIsActive.Text = _License.IsActive ? "Yes" : "No";
            lbDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            lbDriverID.Text = _License.DriverID.ToString();
            lbExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            //lbIsDeatind.Text = _License.IsDetaind;
            _LoadImage();


        }
        private void ctrlDriverLicenseInfo_Load(object sender, EventArgs e)
        {


        }
    }
}
