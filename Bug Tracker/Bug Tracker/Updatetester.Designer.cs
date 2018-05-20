namespace Bug_Tracker
{
    partial class Updatetester
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
            this.lbltesterup = new System.Windows.Forms.Label();
            this.txt_upstatus = new System.Windows.Forms.TextBox();
            this.btn_updt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltesterup
            // 
            this.lbltesterup.AutoSize = true;
            this.lbltesterup.Location = new System.Drawing.Point(3, 9);
            this.lbltesterup.Name = "lbltesterup";
            this.lbltesterup.Size = new System.Drawing.Size(124, 13);
            this.lbltesterup.TabIndex = 0;
            this.lbltesterup.Text = "Update status for Project";
            // 
            // txt_upstatus
            // 
            this.txt_upstatus.Location = new System.Drawing.Point(171, 2);
            this.txt_upstatus.Name = "txt_upstatus";
            this.txt_upstatus.Size = new System.Drawing.Size(252, 20);
            this.txt_upstatus.TabIndex = 1;
            this.txt_upstatus.TextChanged += new System.EventHandler(this.txt_upstatus_TextChanged);
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(101, 64);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(115, 37);
            this.btn_updt.TabIndex = 2;
            this.btn_updt.Text = "Update";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // Updatetester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 154);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.txt_upstatus);
            this.Controls.Add(this.lbltesterup);
            this.Name = "Updatetester";
            this.Text = "Updatetester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltesterup;
        private System.Windows.Forms.TextBox txt_upstatus;
        private System.Windows.Forms.Button btn_updt;
    }
}