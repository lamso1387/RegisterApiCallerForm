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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbParallel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSee = new System.Windows.Forms.Button();
            this.dgvSeeTimes = new System.Windows.Forms.DataGridView();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(452, 15);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(100, 20);
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
            this.btnSend.Location = new System.Drawing.Point(24, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbRound);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbParallel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(360, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 38);
            this.panel1.TabIndex = 3;
            // 
            // tbRound
            // 
            this.tbRound.Location = new System.Drawing.Point(117, 10);
            this.tbRound.Name = "tbRound";
            this.tbRound.Size = new System.Drawing.Size(27, 20);
            this.tbRound.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "به تعداد";
            // 
            // tbParallel
            // 
            this.tbParallel.Location = new System.Drawing.Point(198, 10);
            this.tbParallel.Name = "tbParallel";
            this.tbParallel.Size = new System.Drawing.Size(35, 20);
            this.tbParallel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ارسال موازی";
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(452, 137);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(113, 23);
            this.btnSee.TabIndex = 4;
            this.btnSee.Text = "مشاهده نتایج";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // dgvSeeTimes
            // 
            this.dgvSeeTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeeTimes.Location = new System.Drawing.Point(228, 176);
            this.dgvSeeTimes.Name = "dgvSeeTimes";
            this.dgvSeeTimes.Size = new System.Drawing.Size(502, 303);
            this.dgvSeeTimes.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(128, 466);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "میانگین زمان";
            // 
            // EstelamTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dgvSeeTimes);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPostalCode);
            this.Name = "EstelamTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbParallel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.DataGridView dgvSeeTimes;
        private System.Windows.Forms.Label lblTime;
    }
}
