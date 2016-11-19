namespace RegisterApiCallerForm
{
    partial class Report
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTagGroup = new System.Windows.Forms.Button();
            this.btnRegisteredPerProvince = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerCityBtPrivince = new System.Windows.Forms.Button();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(34, 89);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(921, 385);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnTagGroup
            // 
            this.btnTagGroup.Location = new System.Drawing.Point(851, 11);
            this.btnTagGroup.Name = "btnTagGroup";
            this.btnTagGroup.Size = new System.Drawing.Size(104, 48);
            this.btnTagGroup.TabIndex = 2;
            this.btnTagGroup.Text = "تعداد کل بر اساس دستگاه";
            this.btnTagGroup.UseVisualStyleBackColor = true;
            this.btnTagGroup.Click += new System.EventHandler(this.btnTagGroup_Click);
            // 
            // btnRegisteredPerProvince
            // 
            this.btnRegisteredPerProvince.Location = new System.Drawing.Point(717, 11);
            this.btnRegisteredPerProvince.Name = "btnRegisteredPerProvince";
            this.btnRegisteredPerProvince.Size = new System.Drawing.Size(115, 48);
            this.btnRegisteredPerProvince.TabIndex = 3;
            this.btnRegisteredPerProvince.Text = "تعداد ثبت نام شده بر اساس استان";
            this.btnRegisteredPerProvince.UseVisualStyleBackColor = true;
            this.btnRegisteredPerProvince.Click += new System.EventHandler(this.btnRegisteredPerProvince_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbProvince);
            this.panel1.Controls.Add(this.btnPerCityBtPrivince);
            this.panel1.Location = new System.Drawing.Point(454, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 65);
            this.panel1.TabIndex = 4;
            // 
            // btnPerCityBtPrivince
            // 
            this.btnPerCityBtPrivince.Location = new System.Drawing.Point(124, 7);
            this.btnPerCityBtPrivince.Name = "btnPerCityBtPrivince";
            this.btnPerCityBtPrivince.Size = new System.Drawing.Size(118, 48);
            this.btnPerCityBtPrivince.TabIndex = 0;
            this.btnPerCityBtPrivince.Text = "تعداد بر حسب شهرستان در استان:";
            this.btnPerCityBtPrivince.UseVisualStyleBackColor = true;
            this.btnPerCityBtPrivince.Click += new System.EventHandler(this.btnPerCityBtPrivince_Click);
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "تبریز",
            "آذربایجان غربی",
            "اردبیل",
            "اصفهان",
            "البرز",
            "ایلام",
            "بوشهر",
            "تهران",
            "چهارمحال و بختیاری",
            "خراسان جنوبی",
            "خراسان رضوی",
            "خراسان شمالی",
            "خوزستان",
            "زنجان",
            "سمنان",
            "سیستان و بلوچستان",
            "فارس",
            "قزوین",
            "قم",
            "کردستان",
            "کرمان",
            "کرمانشاه",
            "کهگیلویه و بویراحمد",
            "گلستان",
            "گیلان",
            "لرستان",
            "مازندران",
            "مرکزی",
            "هرمزگان",
            "همدان",
            "یزد"});
            this.cbProvince.Location = new System.Drawing.Point(3, 22);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(115, 21);
            this.cbProvince.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegisteredPerProvince);
            this.Controls.Add(this.btnTagGroup);
            this.Controls.Add(this.chart);
            this.Name = "Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnTagGroup;
        private System.Windows.Forms.Button btnRegisteredPerProvince;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Button btnPerCityBtPrivince;

    }
}
