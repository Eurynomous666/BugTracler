namespace Bug_Tracker
{
    partial class DeveloperFrm
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
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btncheckcode = new System.Windows.Forms.Button();
            this.btnsendtest = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.devdgv = new System.Windows.Forms.DataGridView();
            this.lblUname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(521, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(32, 15);
            this.date.TabIndex = 29;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(667, 20);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 15);
            this.time.TabIndex = 30;
            this.time.Text = "Time";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(12, 76);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 16);
            this.Search.TabIndex = 31;
            this.Search.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(87, 76);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(193, 20);
            this.txtsearch.TabIndex = 32;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(338, 76);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 33;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btncheckcode
            // 
            this.btncheckcode.Location = new System.Drawing.Point(512, 76);
            this.btncheckcode.Name = "btncheckcode";
            this.btncheckcode.Size = new System.Drawing.Size(75, 23);
            this.btncheckcode.TabIndex = 34;
            this.btncheckcode.Text = "Check Code";
            this.btncheckcode.UseVisualStyleBackColor = true;
            this.btncheckcode.Click += new System.EventHandler(this.btncheckcode_Click);
            // 
            // btnsendtest
            // 
            this.btnsendtest.Location = new System.Drawing.Point(670, 76);
            this.btnsendtest.Name = "btnsendtest";
            this.btnsendtest.Size = new System.Drawing.Size(75, 23);
            this.btnsendtest.TabIndex = 35;
            this.btnsendtest.Text = "To tester";
            this.btnsendtest.UseVisualStyleBackColor = true;
            this.btnsendtest.Click += new System.EventHandler(this.btnsendtest_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(670, 47);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 36;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // devdgv
            // 
            this.devdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devdgv.Location = new System.Drawing.Point(15, 108);
            this.devdgv.Name = "devdgv";
            this.devdgv.Size = new System.Drawing.Size(755, 330);
            this.devdgv.TabIndex = 37;
            this.devdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devdgv_CellContentClick);
            this.devdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devdgv_CellDoubleClick);
            this.devdgv.DoubleClick += new System.EventHandler(this.devdgv_DoubleClick);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(15, 13);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 13);
            this.lblUname.TabIndex = 38;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeveloperFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.devdgv);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsendtest);
            this.Controls.Add(this.btncheckcode);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Name = "DeveloperFrm";
            this.Text = "DeveloperFrm";
            this.Load += new System.EventHandler(this.DeveloperFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btncheckcode;
        private System.Windows.Forms.Button btnsendtest;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView devdgv;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Timer timer1;
    }
}