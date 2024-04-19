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
    public partial class USERVIEWMODEL : Form
    {
        public USERVIEWMODEL()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.VIEWMODEL();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mid";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pid"].ToString();
                textBox2.Text = s["spec"].ToString();
               
                textBox4.Text = s["pname"].ToString();
                textBox5.Text = s["mname"].ToString();
                textBox6.Text = s["uprice"].ToString();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());

            }

        }

        private void USERVIEWMODEL_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.Text = (int.Parse(textBox3.Text) * int.Parse(textBox6.Text)).ToString();
           //textBox7.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.INSERTUSERVIEWMODEL(int.Parse(textBox1.Text), textBox4.Text, int.Parse(comboBox1.Text), textBox5.Text, textBox2.Text, int.Parse(textBox6.Text), int.Parse(textBox3.Text), int.Parse(textBox7.Text));
            MessageBox.Show(x + "product buying successfully");
        }
    }
}
