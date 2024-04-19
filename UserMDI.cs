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
    public partial class UserMDI : Form
    {
        public UserMDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vIEWPEODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERVIEWPRODUCT UV = new USERVIEWPRODUCT();
            UV.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERVIEWMODEL UVM = new USERVIEWMODEL();
            UVM.Show();
        }
    }
}
