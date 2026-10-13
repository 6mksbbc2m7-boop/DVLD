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
    public partial class FrmTakeTest : Form
    {
        private int _TestAppointmentID = -1;
        private clsTestType.enTestType _TestTypeID;
        private int _TestID = -1;
        private clsTests _Test;
        public FrmTakeTest(int TestAppointmentID,clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestType;
        }

        private void ctrlScheduledTest1_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeID = _TestTypeID;
            ctrlScheduledTest1.LoadInfo(_TestAppointmentID);
            if (ctrlScheduledTest1.TestAppointmentID == -1)
                btSave.Enabled = false;
            else
                btSave.Enabled = true;
            _TestID = ctrlScheduledTest1.TestID;
            if(_TestID!=-1)
            {
                _Test = clsTests.Find(_TestID);
                if (_Test.TestResult)
                    rpPass.Checked = true;
                else
                    rpFail.Checked = true;

                txtNotice.Text = _Test.Notes;
                rpPass.Checked = false;
                rpFail.Checked = false;
                        
            }
            _Test = new clsTests();
            


        }

        private void FrmTakeTest_Load(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
            )
            {
                return;
            }

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = rpPass.Checked;
            _Test.Notes = txtNotice.Text;
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
