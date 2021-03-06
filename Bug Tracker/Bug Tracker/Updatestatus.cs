﻿using System;
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
    public partial class Updatestatus : Form
    {
        public Updatestatus()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_upstat.Text))
            {
                MessageBox.Show("Please write something on update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_line1.Text != "")
            {
                Connection conn = new Connection();
                string query = "UPDATE tbl_developer SET status = '" + txt_upstat.Text + "', error_line = '" + txt_line1.Text + "' WHERE project_id = '" + DeveloperFrm.val + "' ";
                conn.manipulate(query);
                MessageBox.Show("Status Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                Connection conn = new Connection();
                string query = "UPDATE tbl_developer SET status = '" + txt_upstat.Text + "' WHERE project_id = '" + DeveloperFrm.val + "' ";
                conn.manipulate(query);
                MessageBox.Show("Status Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
