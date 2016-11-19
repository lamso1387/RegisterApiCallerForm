namespace RegisterApiCallerForm
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbMaxTime = new System.Windows.Forms.TextBox();
            this.chbMaxTime = new System.Windows.Forms.CheckBox();
            this.btnKeyTitles = new System.Windows.Forms.Button();
            this.lblKeyTitle = new System.Windows.Forms.Label();
            this.cbErrorSMS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.tbRequestUri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBaseAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miSingleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendDB = new System.Windows.Forms.ToolStripMenuItem();
            this.miMgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.miReport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.miErrorMgtm = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbMaxTime);
            this.panel3.Controls.Add(this.chbMaxTime);
            this.panel3.Controls.Add(this.btnKeyTitles);
            this.panel3.Controls.Add(this.lblKeyTitle);
            this.panel3.Controls.Add(this.cbErrorSMS);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.key);
            this.panel3.Controls.Add(this.tbApiKey);
            this.panel3.Controls.Add(this.tbRequestUri);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbBaseAddress);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 113);
            this.panel3.TabIndex = 6;
            // 
            // tbMaxTime
            // 
            this.tbMaxTime.Enabled = false;
            this.tbMaxTime.Location = new System.Drawing.Point(10, 48);
            this.tbMaxTime.Name = "tbMaxTime";
            this.tbMaxTime.Size = new System.Drawing.Size(54, 20);
            this.tbMaxTime.TabIndex = 27;
            this.tbMaxTime.Text = "15";
            this.tbMaxTime.TextChanged += new System.EventHandler(this.tbMaxTime_TextChanged);
            // 
            // chbMaxTime
            // 
            this.chbMaxTime.AutoSize = true;
            this.chbMaxTime.Location = new System.Drawing.Point(70, 50);
            this.chbMaxTime.Name = "chbMaxTime";
            this.chbMaxTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbMaxTime.Size = new System.Drawing.Size(138, 17);
            this.chbMaxTime.TabIndex = 26;
            this.chbMaxTime.Text = "حداکثر زمان داشته باشد:";
            this.chbMaxTime.UseVisualStyleBackColor = true;
            this.chbMaxTime.CheckedChanged += new System.EventHandler(this.chbMaxTime_CheckedChanged);
            // 
            // btnKeyTitles
            // 
            this.btnKeyTitles.Location = new System.Drawing.Point(943, 56);
            this.btnKeyTitles.Name = "btnKeyTitles";
            this.btnKeyTitles.Size = new System.Drawing.Size(20, 23);
            this.btnKeyTitles.TabIndex = 25;
            this.btnKeyTitles.Text = "...";
            this.btnKeyTitles.UseVisualStyleBackColor = true;
            this.btnKeyTitles.Click += new System.EventHandler(this.btnKeyTitles_Click);
            // 
            // lblKeyTitle
            // 
            this.lblKeyTitle.AutoSize = true;
            this.lblKeyTitle.Location = new System.Drawing.Point(941, 84);
            this.lblKeyTitle.Name = "lblKeyTitle";
            this.lblKeyTitle.Size = new System.Drawing.Size(78, 13);
            this.lblKeyTitle.TabIndex = 24;
            this.lblKeyTitle.Text = "کاربر: نامشخص";
            // 
            // cbErrorSMS
            // 
            this.cbErrorSMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbErrorSMS.FormattingEnabled = true;
            this.cbErrorSMS.Items.AddRange(new object[] {
            "",
            "true",
            "false"});
            this.cbErrorSMS.Location = new System.Drawing.Point(10, 11);
            this.cbErrorSMS.Name = "cbErrorSMS";
            this.cbErrorSMS.Size = new System.Drawing.Size(67, 21);
            this.cbErrorSMS.TabIndex = 23;
            this.cbErrorSMS.SelectedIndexChanged += new System.EventHandler(this.cbErrorSMS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ارسال پیامک در صورت نقص";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(1072, 60);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(24, 13);
            this.key.TabIndex = 5;
            this.key.Text = "key";
            // 
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(966, 57);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(95, 20);
            this.tbApiKey.TabIndex = 4;
            this.tbApiKey.TextChanged += new System.EventHandler(this.tbApiKey_TextChanged);
            this.tbApiKey.Leave += new System.EventHandler(this.tbApiKey_Leave);
            // 
            // tbRequestUri
            // 
            this.tbRequestUri.Location = new System.Drawing.Point(943, 31);
            this.tbRequestUri.Name = "tbRequestUri";
            this.tbRequestUri.Size = new System.Drawing.Size(117, 20);
            this.tbRequestUri.TabIndex = 3;
            this.tbRequestUri.TextChanged += new System.EventHandler(this.tbRequestUri_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1063, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "method";
            // 
            // tbBaseAddress
            // 
            this.tbBaseAddress.Enabled = false;
            this.tbBaseAddress.Location = new System.Drawing.Point(943, 5);
            this.tbBaseAddress.Name = "tbBaseAddress";
            this.tbBaseAddress.Size = new System.Drawing.Size(118, 20);
            this.tbBaseAddress.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1065, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "api";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSingleTest,
            this.miSendDB,
            this.miMgmt,
            this.miReport,
            this.miErrorMgtm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miSingleTest
            // 
            this.miSingleTest.Name = "miSingleTest";
            this.miSingleTest.Size = new System.Drawing.Size(67, 20);
            this.miSingleTest.Text = "تست نمونه";
            this.miSingleTest.Click += new System.EventHandler(this.miSingleTest_Click);
            // 
            // miSendDB
            // 
            this.miSendDB.Name = "miSendDB";
            this.miSendDB.Size = new System.Drawing.Size(111, 20);
            this.miSendDB.Text = "ارسال از پایگاه داده";
            this.miSendDB.Click += new System.EventHandler(this.miSendDB_Click);
            // 
            // miMgmt
            // 
            this.miMgmt.Name = "miMgmt";
            this.miMgmt.Size = new System.Drawing.Size(90, 20);
            this.miMgmt.Text = "مدیریت اطلاعات";
            this.miMgmt.Click += new System.EventHandler(this.miMgmt_Click);
            // 
            // miReport
            // 
            this.miReport.Name = "miReport";
            this.miReport.Size = new System.Drawing.Size(49, 20);
            this.miReport.Text = "گزارش";
            this.miReport.Click += new System.EventHandler(this.miReport_Click);
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Location = new System.Drawing.Point(79, 169);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1000, 500);
            this.pnlmain.TabIndex = 15;
            // 
            // miErrorMgtm
            // 
            this.miErrorMgtm.Name = "miErrorMgtm";
            this.miErrorMgtm.Size = new System.Drawing.Size(105, 20);
            this.miErrorMgtm.Text = "مرتب سازی خطاها";
            this.miErrorMgtm.Click += new System.EventHandler(this.miErrorMgtm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 696);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox tbRequestUri;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbBaseAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miSendDB;
        private System.Windows.Forms.Label key;
        public System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.ToolStripMenuItem miMgmt;
        private System.Windows.Forms.ToolStripMenuItem miSingleTest;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.ComboBox cbErrorSMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKeyTitle;
        private System.Windows.Forms.Button btnKeyTitles;
        private System.Windows.Forms.TextBox tbMaxTime;
        private System.Windows.Forms.CheckBox chbMaxTime;
        private System.Windows.Forms.ToolStripMenuItem miReport;
        private System.Windows.Forms.ToolStripMenuItem miErrorMgtm;
    }
}

