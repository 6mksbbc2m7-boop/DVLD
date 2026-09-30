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
    public partial class FrmUpdateTestType : Form
    {
        private int _ID = 0;
        public FrmUpdateTestType(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void FrmUpdateTestType_Load(object sender, EventArgs e)
        {

        }
    }
}
