namespace RegisterApiCallerForm
{
    partial class EstelamTest
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
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSeeTimes = new System.Windows.Forms.DataGridView();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCount = new System.Windows.Forms.ComboBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUri = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(421, 15);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(131, 20);
            this.tbPostalCode.TabIndex = 0;
            this.tbPostalCode.TextChanged += new System.EventHandler(this.tbPostalCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "کدپستی";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(424, 129);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "count";
            // 
            // dgvSeeTimes
            // 
            this.dgvSeeTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeeTimes.Location = new System.Drawing.Point(83, 190);
            this.dgvSeeTimes.Name = "dgvSeeTimes";
            this.dgvSeeTimes.Size = new System.Drawing.Size(819, 265);
            this.dgvSeeTimes.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(83, 483);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "میانگین زمان";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "sample code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCount
            // 
            this.cbCount.FormattingEnabled = true;
            this.cbCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "10"});
            this.cbCount.Location = new System.Drawing.Point(424, 102);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(134, 21);
            this.cbCount.TabIndex = 7;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(424, 161);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(131, 23);
            this.btnSee.TabIndex = 4;
            this.btnSee.Text = "مشاهده نتایج";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(777, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "پاکسازی جدول زمان";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "نوع";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(351, 75);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(250, 20);
            this.tbType.TabIndex = 10;
            this.tbType.Text = "نامشخص";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "api";
            // 
            // cbUri
            // 
            this.cbUri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUri.FormattingEnabled = true;
            this.cbUri.Items.AddRange(new object[] {
            "get  complex_by_post_code/",
            "post admin/ext-service/postal_code"});
            this.cbUri.Location = new System.Drawing.Point(351, 48);
            this.cbUri.Name = "cbUri";
            this.cbUri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUri.Size = new System.Drawing.Size(253, 21);
            this.cbUri.TabIndex = 36;
            this.cbUri.SelectedIndexChanged += new System.EventHandler(this.cbUri_SelectedIndexChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(638, 470);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(121, 23);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "خروجی اکسل";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(553, 470);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 38;
            this.btnReport.Text = "گزارش نتایج";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // EstelamTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbUri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dgvSeeTimes);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPostalCode);
            this.Name = "EstelamTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSeeTimes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCount;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUri;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnReport;
    }
}
