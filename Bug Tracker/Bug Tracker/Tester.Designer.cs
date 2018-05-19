namespace Bug_Tracker
{
    partial class Tester
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
            this.components = new System.ComponentModel.Container();
            this.date2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.lbl_search1 = new System.Windows.Forms.Label();
            this.txt_search1 = new System.Windows.Forms.TextBox();
            this.devdgv = new System.Windows.Forms.DataGridView();
            this.btn_refresh2 = new System.Windows.Forms.Button();
            this.btn_todeveloper = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_developer = new System.Windows.Forms.Button();
            this.btn_testok = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Location = new System.Drawing.Point(329, 9);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(30, 13);
            this.date2.TabIndex = 13;
            this.date2.Text = "Date";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(453, 9);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(30, 13);
            this.time1.TabIndex = 14;
            this.time1.Text = "Time";
            // 
            // lbl_search1
            // 
            this.lbl_search1.AutoSize = true;
            this.lbl_search1.Location = new System.Drawing.Point(12, 62);
            this.lbl_search1.Name = "lbl_search1";
            this.lbl_search1.Size = new System.Drawing.Size(41, 13);
            this.lbl_search1.TabIndex = 15;
            this.lbl_search1.Text = "Search";
            // 
            // txt_search1
            // 
            this.txt_search1.Location = new System.Drawing.Point(59, 61);
            this.txt_search1.Name = "txt_search1";
            this.txt_search1.Size = new System.Drawing.Size(156, 20);
            this.txt_search1.TabIndex = 16;
            this.txt_search1.TextChanged += new System.EventHandler(this.txt_search1_TextChanged);
            // 
            // devdgv
            // 
            this.devdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devdgv.Location = new System.Drawing.Point(12, 87);
            this.devdgv.Name = "devdgv";
            this.devdgv.Size = new System.Drawing.Size(673, 155);
            this.devdgv.TabIndex = 17;
            this.devdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devdgv_CellContentClick);
            // 
            // btn_refresh2
            // 
            this.btn_refresh2.Location = new System.Drawing.Point(373, 61);
            this.btn_refresh2.Name = "btn_refresh2";
            this.btn_refresh2.Size = new System.Drawing.Size(81, 20);
            this.btn_refresh2.TabIndex = 18;
            this.btn_refresh2.Text = "Refresh";
            this.btn_refresh2.UseVisualStyleBackColor = true;
            // 
            // btn_todeveloper
            // 
            this.btn_todeveloper.Location = new System.Drawing.Point(477, 62);
            this.btn_todeveloper.Name = "btn_todeveloper";
            this.btn_todeveloper.Size = new System.Drawing.Size(98, 19);
            this.btn_todeveloper.TabIndex = 19;
            this.btn_todeveloper.Text = "To Developer";
            this.btn_todeveloper.UseVisualStyleBackColor = true;
            this.btn_todeveloper.Click += new System.EventHandler(this.btn_todeveloper_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(12, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(97, 20);
            this.btn_logout.TabIndex = 20;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search";
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(59, 262);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(156, 20);
            this.txt_search2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 155);
            this.dataGridView1.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 20);
            this.button3.TabIndex = 24;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_developer
            // 
            this.btn_developer.Location = new System.Drawing.Point(477, 263);
            this.btn_developer.Name = "btn_developer";
            this.btn_developer.Size = new System.Drawing.Size(98, 19);
            this.btn_developer.TabIndex = 25;
            this.btn_developer.Text = "To Developer";
            this.btn_developer.UseVisualStyleBackColor = true;
            this.btn_developer.Click += new System.EventHandler(this.btn_developer_Click);
            // 
            // btn_testok
            // 
            this.btn_testok.Location = new System.Drawing.Point(588, 265);
            this.btn_testok.Name = "btn_testok";
            this.btn_testok.Size = new System.Drawing.Size(97, 20);
            this.btn_testok.TabIndex = 26;
            this.btn_testok.Text = "Test Ok";
            this.btn_testok.UseVisualStyleBackColor = true;
            this.btn_testok.Click += new System.EventHandler(this.btn_testok_Click);
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 462);
            this.Controls.Add(this.btn_testok);
            this.Controls.Add(this.btn_developer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_todeveloper);
            this.Controls.Add(this.btn_refresh2);
            this.Controls.Add(this.devdgv);
            this.Controls.Add(this.txt_search1);
            this.Controls.Add(this.lbl_search1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date2);
            this.Name = "Tester";
            this.Text = "Tester";
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label lbl_search1;
        private System.Windows.Forms.TextBox txt_search1;
        private System.Windows.Forms.DataGridView devdgv;
        private System.Windows.Forms.Button btn_refresh2;
        private System.Windows.Forms.Button btn_todeveloper;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_developer;
        private System.Windows.Forms.Button btn_testok;
        private System.Windows.Forms.Timer timer1;
    }
}