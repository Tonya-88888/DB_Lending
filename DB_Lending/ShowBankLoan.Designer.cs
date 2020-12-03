
namespace DB_Lending
{
    partial class ShowBankLoan
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RateGrid = new System.Windows.Forms.DataGridView();
            this.Currensy = new System.Windows.Forms.ComboBox();
            this.MaxSumBox = new System.Windows.Forms.ComboBox();
            this.MinSumBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DaleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BankLoanGrid
            // 
            this.BankLoanGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BankLoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankLoanGrid.Location = new System.Drawing.Point(12, 12);
            this.BankLoanGrid.Name = "BankLoanGrid";
            this.BankLoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BankLoanGrid.Size = new System.Drawing.Size(1011, 349);
            this.BankLoanGrid.TabIndex = 0;
            this.BankLoanGrid.SelectionChanged += new System.EventHandler(this.BankLoanGrid_SelectionChanged);
            this.BankLoanGrid.Layout += new System.Windows.Forms.LayoutEventHandler(this.BankLoanGrid_Layout);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.RateGrid.Location = new System.Drawing.Point(281, 367);
            this.RateGrid.Name = "RateGrid";
            this.RateGrid.Size = new System.Drawing.Size(518, 132);
            this.RateGrid.TabIndex = 3;
            // 
            // Currensy
            // 
            this.Currensy.FormattingEnabled = true;
            this.Currensy.Location = new System.Drawing.Point(13, 370);
            this.Currensy.Name = "Currensy";
            this.Currensy.Size = new System.Drawing.Size(121, 21);
            this.Currensy.TabIndex = 4;
            this.Currensy.SelectedIndexChanged += new System.EventHandler(this.Currensy_SelectedIndexChanged);
            this.Currensy.SelectionChangeCommitted += new System.EventHandler(this.Currensy_SelectionChangeCommitted);
            // 
            // MaxSumBox
            // 
            this.MaxSumBox.FormattingEnabled = true;
            this.MaxSumBox.Location = new System.Drawing.Point(140, 412);
            this.MaxSumBox.Name = "MaxSumBox";
            this.MaxSumBox.Size = new System.Drawing.Size(121, 21);
            this.MaxSumBox.TabIndex = 8;
            // 
            // MinSumBox
            // 
            this.MinSumBox.FormattingEnabled = true;
            this.MinSumBox.Location = new System.Drawing.Point(13, 412);
            this.MinSumBox.Name = "MinSumBox";
            this.MinSumBox.Size = new System.Drawing.Size(121, 21);
            this.MinSumBox.TabIndex = 9;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1029, 42);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1030, 72);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DaleteButton
            // 
            this.DaleteButton.Location = new System.Drawing.Point(1030, 102);
            this.DaleteButton.Name = "DaleteButton";
            this.DaleteButton.Size = new System.Drawing.Size(75, 23);
            this.DaleteButton.TabIndex = 12;
            this.DaleteButton.Text = "Удалить";
            this.DaleteButton.UseVisualStyleBackColor = true;
            this.DaleteButton.Click += new System.EventHandler(this.DaleteButton_Click);
            // 
            // ShowBankLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 532);
            this.Controls.Add(this.DaleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MinSumBox);
            this.Controls.Add(this.MaxSumBox);
            this.Controls.Add(this.Currensy);
            this.Controls.Add(this.RateGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BankLoanGrid);
            this.Name = "ShowBankLoan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShowBankLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BankLoanGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RateGrid;
        private System.Windows.Forms.ComboBox Currensy;
        private System.Windows.Forms.ComboBox MaxSumBox;
        private System.Windows.Forms.ComboBox MinSumBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DaleteButton;
    }
}

