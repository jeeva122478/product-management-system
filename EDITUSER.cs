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
    public partial class EDITUSER : Form
    {
        public EDITUSER()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();
        public void Loaddata()
        {
            DataTable dt = new DataTable();
            dt = db.VIEWUSER();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "uid";
        }


        private void EDITUSER_Load(object sender, EventArgs e)
        {
            Loaddata();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as ComboBox);
                var s = (cb.SelectedItem as DataRowView);
                textBox1.Text = s["pwd"].ToString();
                textBox2.Text = s["utype"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.EDITUSER(comboBox1.Text, textBox1.Text, textBox2.Text);
            MessageBox.Show(x + "user edited succesfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
