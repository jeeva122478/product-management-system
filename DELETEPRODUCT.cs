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
    public partial class DELETEPRODUCT : Form
    {
        public DELETEPRODUCT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = db.VIEWPRODUCT();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.DeleteProduct(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "deleted sucessfully");
            LoadData();
        }
        

        private void DELETEPRODUCT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
