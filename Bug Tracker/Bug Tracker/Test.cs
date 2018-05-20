using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btn_sbmit_Click(object sender, EventArgs e)
        {
            String test = DateTime.Now.ToString("dd/MM/yyy");
            if (Tester.count > 0)
            {
                Connection conn = new Connection();
                string upquery = "update tbl_tester set result = 'OK' where project_id = '" + Tester.project_Id + "'";
                conn.manipulate(upquery);
                MessageBox.Show("The project has been completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string ins = "insert into tbl_project_complete values('" + Tester.project_Id + "','" + Tester.project_name + "','" + Tester.project_date + "', '" + Tester.project_complete + "','" + test.ToString() + "','" + txt_desc.Text + "')";
                conn.manipulate(ins);

                string dlt = "delete from tbl_project where project_id = '" + Tester.project_Id + "'";
                conn.manipulate(dlt);
                string dlt_ = "delete from tbl_developer where project_id = '" + Tester.project_Id + "'";
                conn.manipulate(dlt_);
                string dltt = "delete from tbl_tester where project_id = '" + Tester.project_Id + "'";
                conn.manipulate(dltt);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to select a Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
