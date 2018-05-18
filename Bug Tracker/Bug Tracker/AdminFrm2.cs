using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

namespace Bug_Tracker
{
    public partial class AdminFrm2 : Form
    {
        Connection connection = new Connection();
        string query;
        public AdminFrm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a_to = txt_assign_to.Text;
            string pname = txtpname.Text;
            string a_by = txt_assign_by.Text;
            string desc = txt_Desc.Text;
            string srt_date = dtp_start.Value.ToShortDateString();
            string end_date = dtp_end.Value.ToShortDateString();
            string code = txtcode.Text;

            if (String.IsNullOrEmpty(a_to) || String.IsNullOrEmpty(a_by) || String.IsNullOrEmpty(desc) || String.IsNullOrEmpty(pname) || String.IsNullOrEmpty(code))
            {
                MessageBox.Show("Any of the field cannot be empty");
            }
            else
            {
                query = "insert into tbl_project(assigned_to,project_name,assigned_date,completion_date,assigned_by,description, code) values('" + a_to + "','" + pname + "','" + srt_date + "','" + end_date + "','" + a_by + "','" + desc + "','" + code + "')";
                connection.manipulate(query);
                MessageBox.Show("Registration Successfull!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void txtcode_Load(object sender, EventArgs e)
        {
            string dirc = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dirc))
            {

                fsmp = new FileSyntaxModeProvider(dirc);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtcode.SetHighlighting("C#");

            }
        }
    }
}
