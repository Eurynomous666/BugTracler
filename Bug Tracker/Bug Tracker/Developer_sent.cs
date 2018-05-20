using ICSharpCode.TextEditor.Document;
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

namespace Bug_Tracker
{
    public partial class Developer_sent : Form
    {
        public Developer_sent()
        {
            InitializeComponent();
        }

        private void btn_todvlpr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text) || String.IsNullOrEmpty(txt_lnno.Text))
            {
                MessageBox.Show("Any of the field cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connection conn = new Connection();
                string query = "select project_id from tbl_developer where project_id='" + Tester.project_Id + "'";
                DataTable dt = conn.retrieve(query);
                //checking wether rows/data are selected or not
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Project has already been sent to Developer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string insquery = "insert into tbl_developer values('" + Tester.project_Id + "','" + Tester.project_name + "','" + Tester.project_date + "','" + Tester.project_complete + "','" + txtcode.Text + "','" + txt_lnno.Text + "','" + txt_status1.Text + "')";
                    conn.manipulate(insquery);
                    MessageBox.Show("Successfully sent to Developer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string upquery = "update tbl_project set status = 'Send to Developer' where project_id = '" + Tester.project_Id + "'";
                    conn.manipulate(upquery);
                    this.Close();
                }
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

        private void Developer_sent_Load(object sender, EventArgs e)
        {
            txtcode.Text = Tester.code;
        }
    }
}

