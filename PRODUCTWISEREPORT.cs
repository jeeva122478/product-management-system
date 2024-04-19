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
    public partial class PRODUCTWISEREPORT : Form
    {
        public PRODUCTWISEREPORT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void PRODUCTWISEREPORT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.Loadsales();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.productwisereport(int.Parse(comboBox1.Text));
            dataGridView1.DataSource = dt;
        }
    }
}
