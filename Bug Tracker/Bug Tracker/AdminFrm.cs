using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bug_Tracker
{
    public partial class btnAssign : Form
    {
        public static string id, name;
        public btnAssign()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFrm2 panel = new AdminFrm2();
            panel.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Admin_main(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();

        }

        private void btnAssignProj_Click(object sender, EventArgs e)
        {
            new AdminFrm2().Show();
            this.Hide();
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            string pendings = "select * from tbl_project";
            Connection conn = new Connection();
            DataTable test = conn.retrieve(pendings);

            pending.DataSource = test;
        }

        private void btnAssign_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            string query = "select * from tbl_project_complete";
            Connection conn = new Connection();
            DataTable bugDt = conn.retrieve(query);

            completed.DataSource = bugDt;

            string pendings = "select * from tbl_project";
            DataTable test = conn.retrieve(pendings);

            pending.DataSource = test;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "select * from tbl_project_complete";
            Connection conn = new Connection();
            DataTable bugDt = conn.retrieve(query);

            completed.DataSource = bugDt;
        }

        private void Completed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Completed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (pending.SelectedRows.Count > 0)
            {
                id = pending.SelectedRows[0].Cells[0].Value + string.Empty;
                name = pending.SelectedRows[0].Cells[1].Value + string.Empty;
                Deleteproject dlt = new Deleteproject();
                dlt.Show();
            }
            else
            {
                MessageBox.Show("No Project has been selected");
            }
        }
    }
}


