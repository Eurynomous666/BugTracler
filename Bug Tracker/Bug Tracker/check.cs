using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;

namespace Bug_Tracker
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void btn_upcode_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text))
            {
                MessageBox.Show("Please coding cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connection conn = new Connection();
                string query = "UPDATE tbl_developer SET code = '" + txtcode.Text + "' WHERE project_id = '" + DeveloperFrm.Id + "' ";
                conn.manipulate(query);
                MessageBox.Show("Code Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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

        private void check_Load(object sender, EventArgs e)
        {
            txtcode.Text = DeveloperFrm.Code;
        }
    }
}
