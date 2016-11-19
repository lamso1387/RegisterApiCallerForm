namespace RegisterApiCallerForm
{
    partial class Loading
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSrart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDgvBind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(139, 9);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoading.Size = new System.Drawing.Size(78, 13);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "در حال ارسال...";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(135, 74);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(231, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 79);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "متوسط زمان سرویس";
            // 
            // lblSrart
            // 
            this.lblSrart.AutoSize = true;
            this.lblSrart.Location = new System.Drawing.Point(361, 84);
            this.lblSrart.Name = "lblSrart";
            this.lblSrart.Size = new System.Drawing.Size(34, 13);
            this.lblSrart.TabIndex = 5;
            this.lblSrart.Text = "شروع";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(361, 104);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "پایان";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(171, 266);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnDgvBind
            // 
            this.btnDgvBind.Location = new System.Drawing.Point(135, 398);
            this.btnDgvBind.Name = "btnDgvBind";
            this.btnDgvBind.Size = new System.Drawing.Size(171, 23);
            this.btnDgvBind.TabIndex = 8;
            this.btnDgvBind.Text = "بروزرسانی";
            this.btnDgvBind.UseVisualStyleBackColor = true;
            this.btnDgvBind.Click += new System.EventHandler(this.btnDgvBind_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.btnDgvBind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblSrart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLoading);
            this.Name = "Loading";
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLoading;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblSrart;
        public System.Windows.Forms.Label lblEnd;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnDgvBind;
    }
}