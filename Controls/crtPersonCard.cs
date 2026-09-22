using clsBuisness;
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
    public partial class crtPersonCard : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;
            if(Handler!=null)
            {
                Handler(PersonID);
            }
        }
        private bool _ShowAddPerson=true;
        public bool ShowAddPerson
        {
            get{
                return _ShowAddPerson;
               }
            set
            {
                _ShowAddPerson = value;
                btAddPerson.Visible = _ShowAddPerson;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Visible = _FilterEnabled;
            }
        }
        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SellectedPersonInfo; }
        }
        public crtPersonCard()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int PersonID)
        {
            cbFiterBox.SelectedIndex = 1;
            txtFiterValue.Text = PersonID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            switch(cbFiterBox.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.ctrlPersonCard_Load(int.Parse(txtFiterValue.Text));


                 
                    break;
                case "National No":
                    ctrlPersonCard1.ctrlPersonCard_Load(txtFiterValue.Text);
                    break;


                default:
                    break;
     

                    
            }
            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonCard1.PersonID);
                
        }

        private void crtPersonCard_Load(object sender, EventArgs e)
        {
            cbFiterBox.SelectedIndex = 0;
            txtFiterValue.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbFiterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiterValue.Text = "";
            txtFiterValue.Focus();
        }

        private void btSersh_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds Are Not Valid!");
                return;
                
            }
            FindNow();
        }

        private void txtFiterValue_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFiterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFiterValue, "this filed is required!");
            }
            else
            {
                errorProvider1.SetError(txtFiterValue, null);
            }
        }
        private void btAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm1 = new FrmAddUpdatePerson();
            frm1.DataBack += DataBackEvent;
            frm1.ShowDialog();
        }

        private void DataBackEvent(object sender,int PersonID)
        {
            cbFiterBox.SelectedIndex = 1;
            txtFiterValue.Text = PersonID.ToString();
            ctrlPersonCard1.ctrlPersonCard_Load(PersonID);
        }
        public void FilterFocus()
        {
            txtFiterValue.Focus();
        }

        private void txtFiterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btSersh.PerformClick();
            }
            if (cbFiterBox.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
