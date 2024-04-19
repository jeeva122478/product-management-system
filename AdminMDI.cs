using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOproj1
{
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDPRODUCT a = new ADDPRODUCT();
            a.Show();
        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITPRODUCT ee = new EDITPRODUCT();
            ee.Show();
        }

        private void dELPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEPRODUCT d = new DELETEPRODUCT();
            d.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWPRODUCT v = new VIEWPRODUCT();
            v.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDMODEL a = new ADDMODEL();
            a.Show();
        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITMODEL ee = new EDITMODEL();
            ee.Show();
        }

        private void dELMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEMODEL d = new DELETEMODEL();
            d.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWMODEL v = new VIEWMODEL();
            v.Show();
        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUSER A = new ADDUSER();
            A.Show();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITUSER ee = new EDITUSER();
            ee.Show();
        }

        private void dELUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEUSER dl = new DELETEUSER();
            dl.Show();
        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEWUSER v = new VIEWUSER();
            v.Show();
        }

        private void dAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAILYSALESREPORT DS = new DAILYSALESREPORT();
            DS.Show();
        }

        private void dateBetween2DatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATEBETWEENTWODAYScs v = new DATEBETWEENTWODAYScs();
            v.Show();

        }

        private void productWiseRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTWISEREPORT PWR = new PRODUCTWISEREPORT();
            PWR.Show();
        }

        private void moselWiseRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODELWISEREPORT mwr = new MODELWISEREPORT();
            mwr.Show();
        }
    }
}
