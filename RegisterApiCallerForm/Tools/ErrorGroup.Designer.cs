namespace RegisterApiCallerForm
{
    partial class ErrorGroup
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tnPerbOrgb = new System.Windows.Forms.Button();
            this.chbContainErrors = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(44, 481);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(108, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "خروجی اکسل";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(835, 448);
            this.dgv.TabIndex = 4;
            // 
            // tnPerbOrgb
            // 
            this.tnPerbOrgb.Location = new System.Drawing.Point(717, 466);
            this.tnPerbOrgb.Name = "tnPerbOrgb";
            this.tnPerbOrgb.Size = new System.Drawing.Size(130, 23);
            this.tnPerbOrgb.TabIndex = 5;
            this.tnPerbOrgb.Text = "خطا به تفکیک سازمان";
            this.tnPerbOrgb.UseVisualStyleBackColor = true;
            this.tnPerbOrgb.Click += new System.EventHandler(this.tnPerbOrgb_Click);
            // 
            // chbContainErrors
            // 
            this.chbContainErrors.AutoSize = true;
            this.chbContainErrors.Location = new System.Drawing.Point(683, 495);
            this.chbContainErrors.Name = "chbContainErrors";
            this.chbContainErrors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbContainErrors.Size = new System.Drawing.Size(164, 17);
            this.chbContainErrors.TabIndex = 6;
            this.chbContainErrors.Text = "خطای سیستمی هم شامل شود";
            this.chbContainErrors.UseVisualStyleBackColor = true;
            // 
            // ErrorGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 523);
            this.Controls.Add(this.chbContainErrors);
            this.Controls.Add(this.tnPerbOrgb);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnExcel);
            this.Name = "ErrorGroup";
            this.Text = "ErrorGroup";
            this.Load += new System.EventHandler(this.ErrorGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button tnPerbOrgb;
        private System.Windows.Forms.CheckBox chbContainErrors;

    }
}