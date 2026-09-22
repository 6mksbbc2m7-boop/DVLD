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
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int perosnID)
        {
            InitializeComponent();
            ctrlPersonCard1.ctrlPersonCard_Load(perosnID);
        }
        public frmPersonDetails(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.ctrlPersonCard_Load(NationalNo);
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
