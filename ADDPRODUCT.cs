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
    public partial class ADDPRODUCT : Form
    {
        public ADDPRODUCT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void button1_Click(object sender, EventArgs e)
        {
            int x = db.InsertProduct(int.Parse(textBox1.Text),textBox2.Text,textBox3.Text);
            MessageBox.Show(x+"product saved successfully");
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
