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
    public partial class DAILYSALESREPORT : Form
    {
        public DAILYSALESREPORT()
        {
            InitializeComponent();
        }
        DBCon db = new DBCon();

        private void DAILYSALESREPORT_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.dailysalesreport();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
