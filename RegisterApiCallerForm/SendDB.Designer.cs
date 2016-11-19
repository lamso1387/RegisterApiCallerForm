namespace RegisterApiCallerForm
{
    partial class SendDB
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
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnSeeData = new System.Windows.Forms.Button();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.btnSendDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(491, 35);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 16;
            this.tbTo.Text = "1";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(714, 38);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 15;
            this.tbFrom.Text = "1";
            // 
            // btnSeeData
            // 
            this.btnSeeData.Location = new System.Drawing.Point(491, 58);
            this.btnSeeData.Name = "btnSeeData";
            this.btnSeeData.Size = new System.Drawing.Size(100, 23);
            this.btnSeeData.TabIndex = 14;
            this.btnSeeData.Text = "مشاهده اطلاعات";
            this.btnSeeData.UseVisualStyleBackColor = true;
            this.btnSeeData.Click += new System.EventHandler(this.btnSeeData_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Location = new System.Drawing.Point(25, 87);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(938, 379);
            this.dgvInput.TabIndex = 13;
            // 
            // btnSendDB
            // 
            this.btnSendDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSendDB.Location = new System.Drawing.Point(144, 21);
            this.btnSendDB.Name = "btnSendDB";
            this.btnSendDB.Size = new System.Drawing.Size(200, 53);
            this.btnSendDB.TabIndex = 12;
            this.btnSendDB.Text = "ارسال از پایگاه داده";
            this.btnSendDB.UseVisualStyleBackColor = true;
            this.btnSendDB.Click += new System.EventHandler(this.btnSendDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "تعداد رکورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "شروع از ردیف:";
            // 
            // btnGetRows
            // 
            this.btnGetRows.Location = new System.Drawing.Point(694, 36);
            this.btnGetRows.Name = "btnGetRows";
            this.btnGetRows.Size = new System.Drawing.Size(14, 23);
            this.btnGetRows.TabIndex = 17;
            this.btnGetRows.Text = "...";
            this.btnGetRows.UseVisualStyleBackColor = true;
            this.btnGetRows.Click += new System.EventHandler(this.btnGetRows_Click);
            // 
            // SendDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetRows);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.btnSeeData);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.btnSendDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendDB";
            this.Size = new System.Drawing.Size(1000, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnSeeData;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.Button btnSendDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetRows;
    }
}
