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
    public partial class FrmTestList : Form
    {
        private DataTable _dtAllTests;

        public FrmTestList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTestList_Load(object sender, EventArgs e)
        {
            _dtAllTests = clsTestType.GetAllTestTypes();
            dtMangeTestType.DataSource = _dtAllTests;
            lbRecord.Text = _dtAllTests.Rows.Count.ToString();
            if(dtMangeTestType.Rows.Count>0)
            {
                dtMangeTestType.Columns[0].HeaderText = "ID";
                dtMangeTestType.Columns[0].Width = 100;

                dtMangeTestType.Columns[1].HeaderText = "Title";
                dtMangeTestType.Columns[1].Width = 200;

                dtMangeTestType.Columns[2].HeaderText = "Description";
                dtMangeTestType.Columns[2].Width = 400;

                dtMangeTestType.Columns[3].HeaderText = "Fees";
                dtMangeTestType.Columns[3].Width = 120;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editeTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateTestType frm = new FrmUpdateTestType((clsTestType.enTestType)dtMangeTestType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FrmTestList_Load(null, null);
        }
    }
}
