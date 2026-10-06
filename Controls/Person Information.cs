using clsBuisness;
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
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SellectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public  void _ResetPersonInfo()
        {
            _PersonID = -1;
            lbPersonID.Text = "????";
            lbName.Text = "????";
            lbNationalNO.Text = "????";
            lbGendor.Text = "????";
            lbEmail.Text = "????";
            lbAddres.Text = "????";
            lbDateOfBirth.Text = "????";
            lbPhone.Text = "????";
            lbCountry.Text = "????";
        }
        private void _LoadpersonImage()
        {
            if (_Person.Gendor == 0)
                pictureBox1.Image = Resources.Boy;
            else
                pictureBox1.Image = Resources.Girl;
            string ImagePerson = _Person.ImagePath;
            if (ImagePerson != "")
                if (File.Exists(ImagePerson))
                    pictureBox1.ImageLocation = ImagePerson;
               

        }

        private void _FillPersonInfo()
        {
            linkLabel1.Enabled = true;
            _PersonID= _Person.PersonID;
            lbPersonID.Text = _PersonID.ToString();
            lbName.Text = _Person.FirstName + _Person.FullName;
            lbNationalNO.Text = _Person.NationalNO;
            lbGendor.Text = (_Person.Gendor == 0) ? "Male" : "Female";
            lbEmail.Text = _Person.Email;
            lbPhone.Text = _Person.Phone;
            
            lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lbCountry.Text= clsCountry.clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lbAddres.Text = _Person.Address;
            _LoadpersonImage();
        }

        private void ctrlPersonCard_Load(object sender,EventArgs e)
        {
            



        }
        public void ctrlPersonCard_Load(int PersonID)
        {
            
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With This ID" + PersonID + ",Error");
                return;
            }
            _FillPersonInfo();



        }
        public void ctrlPersonCard_Load(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if(_Person==null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With This ID" + NationalNo + ",Error");
                return;

            }
            _FillPersonInfo();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
