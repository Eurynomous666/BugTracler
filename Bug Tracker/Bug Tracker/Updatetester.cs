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
    public partial class Updatetester : Form
    {
        public Updatetester()
        {
            InitializeComponent();
        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_upstatus.Text))
            {
                MessageBox.Show("Please write something", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connection conn = new Connection();
                string query = "UPDATE tbl_project SET status = '" + txt_upstatus.Text + "' WHERE project_id = '" + Tester.val + "' ";
                conn.manipulate(query);
                MessageBox.Show("Status Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void txt_upstatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
