using clsBuisness;
using clsCountry;
using clsValidattion;
using DVLD.Classes;
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
    public partial class FrmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew=0,Update=1 };
        public enum enGendor { Male=0,Female=1};
        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public FrmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FrmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
             _PersonID= PersonID;

        }
        private void _FillCountriesInCompoBox()
        {
            DataTable dtCountries = clsCountry.clsCountry.GetAllCountries();
            foreach (DataRow Row in dtCountries.Rows)
            {
                cpCountry.Items.Add(Row["CountryName"]);
            }

        }
        private void ResteDefualtValues()
        {
            _FillCountriesInCompoBox();
            if(_Mode==enMode.AddNew)
            {
                lbTitle.Text = "Add New Person ";
                _Person = new clsPerson();

            }
            else
            {
                lbTitle.Text = "Update Person ";
            }
            if (rdMale.Checked)
                pbPersonImage.Image = Resources.Boy;
            else
                pbPersonImage.Image = Resources.Girl;
            linRemove.Visible = (pbPersonImage.ImageLocation != null);
            
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            cpCountry.SelectedIndex = cpCountry.FindString("Jordan");

            texFirstName.Text = "";
            textSecond.Text = "";
            textThirdName.Text = "";
            textLastName.Text = "";
            textNationalNUmber.Text = "";
            rdMale.Checked = true;
            textPhone.Text = "";
            textEmail.Text = "";
            textAddress.Text = "";
        }
        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            if(_Person ==null)
            {
                MessageBox.Show("this Person ID = " + _PersonID + "Not Found");
                this.Close();
                return;
            }
            textPrsonID.Text = _PersonID.ToString();
            texFirstName.Text = _Person.FirstName;
            textSecond.Text = _Person.SecondName;
            textThirdName.Text = _Person.ThirdName;
            textNationalNUmber.Text = _Person.NationalNO;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            if (_Person.Gendor == 0)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            
            textAddress.Text = _Person.Address;
            textPhone.Text = _Person.Phone;
            textEmail.Text = _Person.Email;
            cpCountry.SelectedIndex = cpCountry.FindString(_Person.CountryInfo.CountryName);
            if(_Person.ImagePath !="")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
            linRemove.Visible=(_Person.ImagePath != "");
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

            ResteDefualtValues();
            if (_Mode ==enMode.Update)
                _LoadData();


        }
        private bool _HandelImagePerson()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);

                    }
                    catch(IOException)
                    {

                    }
               }

            }
            if (pbPersonImage.ImageLocation != null)
            {
                //then we copy the new image to the image folder after we rename it
                string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    pbPersonImage.ImageLocation = SourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void ValidateEmptyTextBox(object sender,CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if(string.IsNullOrWhiteSpace(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required ");

            }
            else
            {
                errorProvider1.SetError(Temp, null);

            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Boy;
        }

        private void textPrsonID_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void texFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

        }

        private void textNationalNUmber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textNationalNUmber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNationalNUmber, "this field is Requir");
                return;
            }
            else
            {
                errorProvider1.SetError(textNationalNUmber, null);
            }
            if(textNationalNUmber.Text.Trim()!=_Person.NationalNO && clsPerson.IsPersonExist(textNationalNUmber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNationalNUmber, "National Number is used for Another Person!");


            }
            else
            {
                errorProvider1.SetError(textNationalNUmber, null);

            }
        }

        private void rdMale_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textAddress_Validating(object sender, CancelEventArgs e)
        {

            ValidateEmptyTextBox(sender, e);
        }

        private void pbPersonImage_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void textSecond_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void textThirdName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void cpCountry_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are not valide");
                return;
            }
            int NationalityCountryID = clsCountry.clsCountry.Find(cpCountry.Text).ID;
            _Person.FirstName = texFirstName.Text.Trim();
            _Person.SecondName = textSecond.Text.Trim();
            _Person.ThirdName = textThirdName.Text.Trim();
            _Person.LastName = textLastName.Text.Trim();
            _Person.NationalNO = textNationalNUmber.Text.Trim();
            _Person.Email = textEmail.Text.Trim();
            _Person.Phone = textPhone.Text.Trim();
            _Person.Address = textAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rdMale.Checked)
                _Person.Gendor = (short)enGendor.Male;
            else
                _Person.Gendor = (short)enGendor.Female;
            _Person.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if(_Person.Save())
            {
                textPrsonID.Text = _Person.PersonID.ToString();

                _Mode = enMode.Update;
                lbTitle.Text = "Update Person ";

                MessageBox.Show("Data Saved Successfully ");


                DataBack.Invoke(this, _Person.PersonID);
                

            }
            else
            {
                MessageBox.Show("Error, Data not saved ");
            }

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textEmail_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textEmail.Text.Trim() == "")
                return;
            if (!clsValidattion.clsValidation.ValidateEmail(textEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(textEmail, null);
            }
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Girl;
        }

        private void linSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.gif;*.jfif;*.bmp;*.gif|All Files|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string selectFilPath = openFileDialog.FileName;
                pbPersonImage.Load(selectFilPath);
                linRemove.Visible = true;
            }
        }

        private void linRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            if (rdMale.Checked)
                pbPersonImage.Image = Resources.Boy;
            else
                pbPersonImage.Image = Resources.Girl;
        }
    }
}
