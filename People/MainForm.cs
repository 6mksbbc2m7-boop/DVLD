using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;

namespace DVLD
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
           
        }

        private void drivingLicenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frm = new FrmManagePeople();
            frm.ShowDialog();
        
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
