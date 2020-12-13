
namespace DB_Lending
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.report1 = new FastReport.Report();
            this.lendingDataSet1 = new DB_Lending.LendingDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.report2 = new FastReport.Report();
            this.report3 = new FastReport.Report();
            this.report4 = new FastReport.Report();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report4)).BeginInit();
            this.SuspendLayout();
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.lendingDataSet1, "lendingDataSet1");
            // 
            // lendingDataSet1
            // 
            this.lendingDataSet1.DataSetName = "LendingDataSet";
            this.lendingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Визитки кредитов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(23, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сводный отчет по валютам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // report2
            // 
            this.report2.NeedRefresh = false;
            this.report2.ReportResourceString = resources.GetString("report2.ReportResourceString");
            this.report2.Tag = null;
            this.report2.RegisterData(this.lendingDataSet1, "lendingDataSet1");
            // 
            // report3
            // 
            this.report3.NeedRefresh = false;
            this.report3.ReportResourceString = resources.GetString("report3.ReportResourceString");
            this.report3.Tag = null;
            this.report3.RegisterData(this.lendingDataSet1, "lendingDataSet1");
            // 
            // report4
            // 
            this.report4.NeedRefresh = false;
            this.report4.ReportResourceString = resources.GetString("report4.ReportResourceString");
            this.report4.Tag = null;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(23, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Востребованность кредитов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(23, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отчет по платежам";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 302);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(338, 341);
            this.MinimumSize = new System.Drawing.Size(338, 341);
            this.Name = "Reports";
            this.Text = "Создание отчетов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Report report1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LendingDataSet lendingDataSet1;
        private FastReport.Report report2;
        private FastReport.Report report3;
        private FastReport.Report report4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}