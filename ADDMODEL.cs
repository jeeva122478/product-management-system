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
    public partial class ADDMODEL : Form
    {
        public ADDMODEL()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.VIEWPRODUCT();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pid";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADDMODEL_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox3.Text = s["pname"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..." + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.Insertmodel(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(x + "model added sucesfully");
            clear();
        }
        public void clear()
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();

        }
    }
}
