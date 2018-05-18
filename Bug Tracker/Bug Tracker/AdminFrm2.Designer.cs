namespace Bug_Tracker
{
    partial class AdminFrm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_assign_to = new System.Windows.Forms.TextBox();
            this.txt_assign_by = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign To";
            // 
            // txt_assign_to
            // 
            this.txt_assign_to.Location = new System.Drawing.Point(128, 20);
            this.txt_assign_to.Name = "txt_assign_to";
            this.txt_assign_to.Size = new System.Drawing.Size(153, 20);
            this.txt_assign_to.TabIndex = 1;
            // 
            // txt_assign_by
            // 
            this.txt_assign_by.Location = new System.Drawing.Point(128, 64);
            this.txt_assign_by.Name = "txt_assign_by";
            this.txt_assign_by.Size = new System.Drawing.Size(153, 20);
            this.txt_assign_by.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assigned By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Date";
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(128, 142);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(153, 20);
            this.dtp_start.TabIndex = 5;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(128, 178);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(153, 20);
            this.dtp_end.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Completed Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code";
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(128, 216);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(231, 128);
            this.txtcode.TabIndex = 19;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Project Name";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(128, 105);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(153, 20);
            this.txtpname.TabIndex = 24;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(128, 387);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(231, 85);
            this.txt_Desc.TabIndex = 25;
            // 
            // AdminFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 545);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_assign_by);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_assign_to);
            this.Controls.Add(this.label1);
            this.Name = "AdminFrm2";
            this.Text = "AdminFrm2cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_assign_to;
        private System.Windows.Forms.TextBox txt_assign_by;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txt_Desc;
    }
}