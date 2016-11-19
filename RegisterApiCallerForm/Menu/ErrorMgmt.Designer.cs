namespace RegisterApiCallerForm
{
    partial class ErrorMgmt
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
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.tbNewFarsi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dgvErrors.Location = new System.Drawing.Point(3, 26);
            this.dgvErrors.MultiSelect = false;
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrors.Size = new System.Drawing.Size(974, 301);
            this.dgvErrors.TabIndex = 0;
            this.dgvErrors.SelectionChanged += new System.EventHandler(this.dgvErrors_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbNewFarsi);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Location = new System.Drawing.Point(97, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 103);
            this.panel1.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(116, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "label1";
            // 
            // tbNewFarsi
            // 
            this.tbNewFarsi.Location = new System.Drawing.Point(116, 38);
            this.tbNewFarsi.Name = "tbNewFarsi";
            this.tbNewFarsi.Size = new System.Drawing.Size(707, 20);
            this.tbNewFarsi.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "error";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 500;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "current";
            this.Column3.Name = "Column3";
            this.Column3.Width = 400;
            // 
            // ErrorMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvErrors);
            this.Name = "ErrorMgmt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.ErrorMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNewFarsi;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
