namespace Bug_Tracker
{
    partial class Test
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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_sbmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(2, 41);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(230, 189);
            this.txt_desc.TabIndex = 1;
            // 
            // btn_sbmit
            // 
            this.btn_sbmit.Location = new System.Drawing.Point(2, 250);
            this.btn_sbmit.Name = "btn_sbmit";
            this.btn_sbmit.Size = new System.Drawing.Size(89, 68);
            this.btn_sbmit.TabIndex = 2;
            this.btn_sbmit.Text = "Submit";
            this.btn_sbmit.UseVisualStyleBackColor = true;
            this.btn_sbmit.Click += new System.EventHandler(this.btn_sbmit_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 334);
            this.Controls.Add(this.btn_sbmit);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "testok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_sbmit;
    }
}