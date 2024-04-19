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
    public partial class USERVIEWPRODUCT : Form
    {
        public USERVIEWPRODUCT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void USERVIEWPRODUCT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.VIEWPRODUCT();
            dataGridView1.DataSource = dt;
        }
    }
}
