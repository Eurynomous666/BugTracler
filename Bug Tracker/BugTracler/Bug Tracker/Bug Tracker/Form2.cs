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
    public partial class Form2 : Form
    {
        string connectionstring = (@"Data source = LENOVO-PC; initial catalog = BUG; Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Fname.Text == "" || txt_pwd.Text == "" || txt_Uname.Text == "")
                MessageBox.Show(" Fill all the mandatory fields");
            else if (txt_pwd.Text != txt_cpwd.Text)
                MessageBox.Show("Passwords dont match");
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    SqlCommand SqlComd = new SqlCommand("UserAdd", sqlCon);
                    SqlComd.CommandType = CommandType.StoredProcedure;
                    SqlComd.Parameters.AddWithValue("@FullName", txt_Fname.Text.Trim());
                    SqlComd.Parameters.AddWithValue("@UserName", txt_Uname.Text.Trim());
                    SqlComd.Parameters.AddWithValue("@Password", txt_pwd.Text.Trim());

                    SqlComd.Parameters.AddWithValue("@EmailID", txt_Eid.Text.Trim());
                    SqlComd.Parameters.AddWithValue("@UserType", ComboUser.Text.Trim());
                    SqlComd.ExecuteNonQuery();

                    MessageBox.Show("Signup is completed");
                    Clear();

                }
            }
            void Clear()
            {
                txt_Fname.Text = txt_Eid.Text = txt_pwd.Text = txt_Uname.Text = ComboUser.Text = txt_cpwd.Text = "";
            }
        }
    }
}
