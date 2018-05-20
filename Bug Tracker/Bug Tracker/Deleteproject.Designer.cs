namespace Bug_Tracker
{
    partial class Deleteproject
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
            this.lbluname = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to Delete Project?";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(173, 29);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(0, 13);
            this.lbluname.TabIndex = 1;
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(15, 72);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(67, 50);
            this.btn_yes.TabIndex = 2;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(96, 72);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(71, 50);
            this.btn_no.TabIndex = 3;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // Deleteproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 171);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.label1);
            this.Name = "Deleteproject";
            this.Text = "Deleteproject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
    }
}