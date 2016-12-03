namespace RegisterApiCallerForm
{
    partial class DataMgmt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cberrorType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRegisterStatus = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblExplain = new System.Windows.Forms.Label();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.btnErrorCount = new System.Windows.Forms.Button();
            this.btnTagIndex = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSendStatus = new System.Windows.Forms.ComboBox();
            this.btnGetRow = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbParalel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbErrorNull = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 117);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(900, 344);
            this.dgv.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(4, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 67);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(803, 94);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 20;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(803, 72);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "تعداد رکورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 74);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "شروع از ردیف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "نوع خطا";
            // 
            // cberrorType
            // 
            this.cberrorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cberrorType.FormattingEnabled = true;
            this.cberrorType.Location = new System.Drawing.Point(65, 6);
            this.cberrorType.Name = "cberrorType";
            this.cberrorType.Size = new System.Drawing.Size(646, 21);
            this.cberrorType.TabIndex = 22;
            this.cberrorType.SelectedIndexChanged += new System.EventHandler(this.cberrorType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(909, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "وضعیت ثبت نام";
            // 
            // cbRegisterStatus
            // 
            this.cbRegisterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegisterStatus.FormattingEnabled = true;
            this.cbRegisterStatus.Items.AddRange(new object[] {
            "همه",
            "ثبت نام شده",
            "ثبت نام نشده"});
            this.cbRegisterStatus.Location = new System.Drawing.Point(798, 8);
            this.cbRegisterStatus.Name = "cbRegisterStatus";
            this.cbRegisterStatus.Size = new System.Drawing.Size(105, 21);
            this.cbRegisterStatus.TabIndex = 23;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 24);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(887, 470);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(16, 23);
            this.btnCount.TabIndex = 25;
            this.btnCount.Text = "...";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(844, 478);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(30, 13);
            this.lblCount.TabIndex = 26;
            this.lblCount.Text = "تعداد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "تگ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 471);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "پاکسازی";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(529, 97);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(0, 13);
            this.lblExplain.TabIndex = 30;
            // 
            // cbTag
            // 
            this.cbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(633, 68);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(78, 21);
            this.cbTag.TabIndex = 32;
            this.cbTag.SelectedIndexChanged += new System.EventHandler(this.cbTag_SelectedIndexChanged);
            this.cbTag.MouseHover += new System.EventHandler(this.cbTag_MouseHover);
            // 
            // btnErrorCount
            // 
            this.btnErrorCount.Location = new System.Drawing.Point(4, 6);
            this.btnErrorCount.Name = "btnErrorCount";
            this.btnErrorCount.Size = new System.Drawing.Size(56, 23);
            this.btnErrorCount.TabIndex = 34;
            this.btnErrorCount.Text = "تعداد";
            this.btnErrorCount.UseVisualStyleBackColor = true;
            this.btnErrorCount.Click += new System.EventHandler(this.btnErrorCount_Click);
            // 
            // btnTagIndex
            // 
            this.btnTagIndex.Location = new System.Drawing.Point(909, 142);
            this.btnTagIndex.Name = "btnTagIndex";
            this.btnTagIndex.Size = new System.Drawing.Size(84, 38);
            this.btnTagIndex.TabIndex = 35;
            this.btnTagIndex.Text = "گزارش اطلاعات سازمانها";
            this.btnTagIndex.UseVisualStyleBackColor = true;
            this.btnTagIndex.Click += new System.EventHandler(this.btnTagIndex_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(912, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "وضعیت ارسال";
            // 
            // cbSendStatus
            // 
            this.cbSendStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendStatus.FormattingEnabled = true;
            this.cbSendStatus.Items.AddRange(new object[] {
            "همه",
            "ارسال شده",
            "ارسال نشده"});
            this.cbSendStatus.Location = new System.Drawing.Point(798, 41);
            this.cbSendStatus.Name = "cbSendStatus";
            this.cbSendStatus.Size = new System.Drawing.Size(105, 21);
            this.cbSendStatus.TabIndex = 37;
            // 
            // btnGetRow
            // 
            this.btnGetRow.Location = new System.Drawing.Point(783, 75);
            this.btnGetRow.Name = "btnGetRow";
            this.btnGetRow.Size = new System.Drawing.Size(16, 40);
            this.btnGetRow.TabIndex = 38;
            this.btnGetRow.Text = "...";
            this.btnGetRow.UseVisualStyleBackColor = true;
            this.btnGetRow.Click += new System.EventHandler(this.btnGetRow_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.CustomFormat = "ss:mm:hh   MM/dd/yyyy  tt";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(184, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Size = new System.Drawing.Size(192, 20);
            this.dtpFrom.TabIndex = 39;
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.CustomFormat = "ss:mm:hh   MM/dd/yyyy  tt";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(184, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Size = new System.Drawing.Size(192, 20);
            this.dtpTo.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "ارسال بزرگتر مساوی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "ارسال کوچکتر مساوی";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(909, 186);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(84, 37);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "خروجی اکسل";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "ارسال موازی به تعداد:";
            // 
            // tbParalel
            // 
            this.tbParalel.Location = new System.Drawing.Point(92, 4);
            this.tbParalel.Name = "tbParalel";
            this.tbParalel.Size = new System.Drawing.Size(29, 20);
            this.tbParalel.TabIndex = 45;
            this.tbParalel.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbParalel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(470, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 30);
            this.panel1.TabIndex = 46;
            // 
            // chbErrorNull
            // 
            this.chbErrorNull.AutoSize = true;
            this.chbErrorNull.Location = new System.Drawing.Point(604, 40);
            this.chbErrorNull.Name = "chbErrorNull";
            this.chbErrorNull.Size = new System.Drawing.Size(128, 17);
            this.chbErrorNull.TabIndex = 47;
            this.chbErrorNull.Text = "ستون error خالی باشد";
            this.chbErrorNull.UseVisualStyleBackColor = true;
            this.chbErrorNull.Visible = false;
            // 
            // DataMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbErrorNull);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnGetRow);
            this.Controls.Add(this.cbSendStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTagIndex);
            this.Controls.Add(this.btnErrorCount);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.cbRegisterStatus);
            this.Controls.Add(this.cberrorType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgv);
            this.Name = "DataMgmt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.DataMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cberrorType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRegisterStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Button btnErrorCount;
        private System.Windows.Forms.Button btnTagIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSendStatus;
        private System.Windows.Forms.Button btnGetRow;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbParalel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbErrorNull;
    }
}
