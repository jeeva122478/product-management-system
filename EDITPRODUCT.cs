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
    public partial class EDITPRODUCT : Form
    {
        public EDITPRODUCT()
        {
            InitializeComponent();
        }
        DBCon dp = new DBCon();
        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = dp.VIEWPRODUCT();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }

        private void EDITPRODUCT_Load(object sender, EventArgs e)
        {
            Loaddata();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pname"].ToString();
                textBox2.Text = s["pdesc"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error..." + ex.ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dp.Editproduct(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(x + "product updated sucessfully");
            clear();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
