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
    public partial class Deleteproject : Form
    {
        public Deleteproject()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string query = "delete from tbl_project where project_id = '" + AdminFrm2.id + "'";
            Connection conn = new Connection();
            conn.manipulate(query);
            MessageBox.Show("Project " + AdminFrm2.name + " has been successfully deleted");
            this.Hide();
        }
    }
}
