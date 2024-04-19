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
    public partial class EDITMODEL : Form
    {
        public EDITMODEL()
        {
            InitializeComponent();
        }
        DBCon dp = new DBCon();
        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = dp.VIEWMODEL();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EDITMODEL_Load(object sender, EventArgs e)
        {
            Loaddata();
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pid"].ToString();
                textBox2.Text = s["spec"].ToString();
                textBox3.Text = s["mname"].ToString();
                textBox4.Text = s["pname"].ToString();
                textBox5.Text = s["uprice"].ToString();
                textBox6.Text = s["soh"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dp.Editmodel(int.Parse(comboBox1.Text), textBox3.Text, int.Parse(textBox1.Text), textBox4.Text, textBox2.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(x + "MODEL updated sucessfully");
            
        }
    }
}
