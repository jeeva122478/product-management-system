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
    public partial class VIEWUSER : Form
    {
        public VIEWUSER()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void VIEWUSER_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.VIEWUSER();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.VIEWUSER();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.VIEWUSERBYUID(comboBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
