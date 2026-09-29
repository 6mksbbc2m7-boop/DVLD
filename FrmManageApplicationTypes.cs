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
using Buisness;

namespace DVLD
{
    public partial class FrmManageApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;
        
        public FrmManageApplicationTypes()
        {
            InitializeComponent();
            


        }

        private void dtManageApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void editeApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditeApplicationType frm = new FrmEditeApplicationType((int)dtManageApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FrmManageApplicationTypes_Load(null, null);
            
        }

        private void FrmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypes.GetAllApplication();
            dtManageApp.DataSource = _dtAllApplicationTypes;
            lbRecord.Text = _dtAllApplicationTypes.Rows.Count.ToString();
            if (dtManageApp.DataSource != null)
            {
                dtManageApp.Columns[0].HeaderText = "ID";
                dtManageApp.Columns[0].Width = 120;

                dtManageApp.Columns[1].HeaderText = "Title";
                dtManageApp.Columns[1].Width = 350;

                dtManageApp.Columns[2].HeaderText = "Fees";
                dtManageApp.Columns[2].Width = 120;
            }
        }
    }
}
