﻿namespace DB_Lending
{
    partial class BankLoanShowForEmp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BankLoanGrid = new System.Windows.Forms.DataGridView();
            this.Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RateGrid = new System.Windows.Forms.DataGridView();
            this.Currensy = new System.Windows.Forms.ComboBox();
            this.MaxSumBox = new System.Windows.Forms.ComboBox();
            this.MinSumBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankLoanGrid
            // 
            this.BankLoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankLoanGrid.Location = new System.Drawing.Point(3, 3);
            this.BankLoanGrid.Name = "BankLoanGrid";
            this.BankLoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BankLoanGrid.Size = new System.Drawing.Size(1013, 334);
            this.BankLoanGrid.TabIndex = 0;
            this.BankLoanGrid.SelectionChanged += new System.EventHandler(this.BankLoanGrid_SelectionChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.Location = new System.Drawing.Point(14, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(102, 29);
            this.Filter.TabIndex = 1;
            this.Filter.Text = "Фильтрация";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // RateGrid
            // 
            this.RateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RateGrid.Location = new System.Drawing.Point(269, 3);
            this.RateGrid.Name = "RateGrid";
            this.RateGrid.Size = new System.Drawing.Size(352, 93);
            this.RateGrid.TabIndex = 3;
            // 
            // Currensy
            // 
            this.Currensy.Dock = System.Windows.Forms.DockStyle.Left;
            this.Currensy.FormattingEnabled = true;
            this.Currensy.Location = new System.Drawing.Point(98, 3);
            this.Currensy.Name = "Currensy";
            this.Currensy.Size = new System.Drawing.Size(121, 27);
            this.Currensy.TabIndex = 4;
            this.Currensy.SelectionChangeCommitted += new System.EventHandler(this.Currensy_SelectionChangeCommitted);
            // 
            // MaxSumBox
            // 
            this.MaxSumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaxSumBox.FormattingEnabled = true;
            this.MaxSumBox.Location = new System.Drawing.Point(98, 69);
            this.MaxSumBox.Name = "MaxSumBox";
            this.MaxSumBox.Size = new System.Drawing.Size(121, 27);
            this.MaxSumBox.TabIndex = 8;
            // 
            // MinSumBox
            // 
            this.MinSumBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinSumBox.FormattingEnabled = true;
            this.MinSumBox.Location = new System.Drawing.Point(98, 36);
            this.MinSumBox.Name = "MinSumBox";
            this.MinSumBox.Size = new System.Drawing.Size(121, 27);
            this.MinSumBox.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.85017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.14983F));
            this.tableLayoutPanel1.Controls.Add(this.BankLoanGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.14428F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.85572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 478);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filter);
            this.panel1.Location = new System.Drawing.Point(1022, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 172);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.55274F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.44726F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RateGrid, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 107);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.Currensy, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.MinSumBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.MaxSumBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 101);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Валюта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Мин сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Макс сумма";
            // 
            // BankLoanShowForEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1188, 545);
            this.Name = "BankLoanShowForEmp";
            this.Text = "Кредиты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankLoanShowForEmp_FormClosing);
            this.Load += new System.EventHandler(this.BankLoanShowForEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BankLoanGrid;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RateGrid;
        private System.Windows.Forms.ComboBox Currensy;
        private System.Windows.Forms.ComboBox MaxSumBox;
        private System.Windows.Forms.ComboBox MinSumBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}