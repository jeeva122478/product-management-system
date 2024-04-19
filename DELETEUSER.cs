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
    public partial class DELETEUSER : Form
    {
        public DELETEUSER()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.VIEWUSER();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember ="uid";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DELETEUSER(comboBox1.Text);
            MessageBox.Show(x + "deleted sucessfully");
            LoadData();
        }

        private void DELETEUSER_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
