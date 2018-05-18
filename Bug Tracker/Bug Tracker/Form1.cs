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
    public partial class Form1 : Form
    {
        public static string user = "";
        Connection conn = new Connection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password, query;

            Username = txtUname.Text.Trim();
            Password = txtPwd.Text.Trim();
            if(string.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("UserName and Password cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUname.Focus();
            }
            else
            {
                query = "Select UserName from [USER DATA] where username ='" + Username + "'";
                DataTable dt = conn.retrieve(query);
                if (dt.Rows.Count > 0)
                {
                    query = "select UserType, UserName, Password from [USER DATA] where UserName='" + Username + "' and Password='" + Password + "'";
                    DataTable dts = conn.retrieve(query);
                    if (dt.Rows.Count > 0)
                    {
                        query = "select UserType from [USER DATA] where UserName = '" + Username + "'";
                        DataTable typ = conn.retrieve(query);

                        if (dts.Rows.Count > 0)
                        {
                            //retrive and store user type in string type
                            string type;
                            type = typ.Rows[0][0].ToString();
                            if (type == "Developer")
                            {
                                Username = txtUname.Text.Trim();
                                DeveloperFrm panel = new DeveloperFrm();
                                panel.Show();
                                this.Hide();
                            }
                            else if (type == "Tester")
                            {
                                Username = txtUname.Text.Trim();
                                TesterFrm panel = new TesterFrm();
                                panel.Show();
                                this.Hide();
                            }
                            else if (type == "Admin")
                            {
                                Username = txtUname.Text.Trim();
                                //Admin_Panel panel = new Admin_Panel();
                                //panel.Show();
                                AdminFrm panel = new AdminFrm();
                                panel.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            //system error no usertype error throw later
                            MessageBox.Show("Error from the system");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPwd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No such username exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUname.Clear();
                    txtPwd.Clear();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
        }




