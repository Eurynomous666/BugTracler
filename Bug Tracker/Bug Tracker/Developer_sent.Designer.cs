namespace Bug_Tracker
{
    partial class Developer_sent
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
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lnno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_status1 = new System.Windows.Forms.TextBox();
            this.btn_todvlpr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(12, 3);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(776, 260);
            this.txtcode.TabIndex = 21;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Line Number";
            // 
            // txt_lnno
            // 
            this.txt_lnno.Location = new System.Drawing.Point(92, 294);
            this.txt_lnno.Name = "txt_lnno";
            this.txt_lnno.Size = new System.Drawing.Size(83, 20);
            this.txt_lnno.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status";
            // 
            // txt_status1
            // 
            this.txt_status1.Location = new System.Drawing.Point(273, 294);
            this.txt_status1.Name = "txt_status1";
            this.txt_status1.Size = new System.Drawing.Size(90, 20);
            this.txt_status1.TabIndex = 25;
            // 
            // btn_todvlpr
            // 
            this.btn_todvlpr.Location = new System.Drawing.Point(469, 292);
            this.btn_todvlpr.Name = "btn_todvlpr";
            this.btn_todvlpr.Size = new System.Drawing.Size(156, 35);
            this.btn_todvlpr.TabIndex = 26;
            this.btn_todvlpr.Text = "Send To Developer";
            this.btn_todvlpr.UseVisualStyleBackColor = true;
            this.btn_todvlpr.Click += new System.EventHandler(this.btn_todvlpr_Click);
            // 
            // Developer_sent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_todvlpr);
            this.Controls.Add(this.txt_status1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lnno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.Name = "Developer_sent";
            this.Text = "Developer_sent";
            this.Load += new System.EventHandler(this.Developer_sent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lnno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status1;
        private System.Windows.Forms.Button btn_todvlpr;
    }
}