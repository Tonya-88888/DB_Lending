
namespace DB_Lending
{
    partial class AddClientLoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.RateGrid = new System.Windows.Forms.DataGridView();
            this.Currensy = new System.Windows.Forms.ComboBox();
            this.MaxSum = new System.Windows.Forms.ComboBox();
            this.MinSum = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Terms = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Guarantor = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.GuarantorList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Pledge = new System.Windows.Forms.Button();
            this.PledgeL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PledgeCost = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ent = new System.Windows.Forms.RadioButton();
            this.Ind = new System.Windows.Forms.RadioButton();
            this.ClientDataGrit = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terms)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankLoanGrid
            // 
            this.BankLoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankLoanGrid.Location = new System.Drawing.Point(564, 49);
            this.BankLoanGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BankLoanGrid.Name = "BankLoanGrid";
            this.BankLoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BankLoanGrid.Size = new System.Drawing.Size(775, 304);
            this.BankLoanGrid.TabIndex = 0;
            this.BankLoanGrid.SelectionChanged += new System.EventHandler(this.BankLoanGrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // RateGrid
            // 
            this.RateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RateGrid.Location = new System.Drawing.Point(254, 6);
            this.RateGrid.Margin = new System.Windows.Forms.Padding(4);
            this.RateGrid.Name = "RateGrid";
            this.RateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RateGrid.Size = new System.Drawing.Size(405, 168);
            this.RateGrid.TabIndex = 3;
            // 
            // Currensy
            // 
            this.Currensy.FormattingEnabled = true;
            this.Currensy.Location = new System.Drawing.Point(4, 36);
            this.Currensy.Margin = new System.Windows.Forms.Padding(4);
            this.Currensy.Name = "Currensy";
            this.Currensy.Size = new System.Drawing.Size(103, 27);
            this.Currensy.TabIndex = 4;
            this.Currensy.SelectedIndexChanged += new System.EventHandler(this.Currensy_SelectedIndexChanged);
            this.Currensy.SelectionChangeCommitted += new System.EventHandler(this.Currensy_SelectionChangeCommitted);
            // 
            // MaxSum
            // 
            this.MaxSum.FormattingEnabled = true;
            this.MaxSum.Location = new System.Drawing.Point(4, 36);
            this.MaxSum.Margin = new System.Windows.Forms.Padding(4);
            this.MaxSum.Name = "MaxSum";
            this.MaxSum.Size = new System.Drawing.Size(103, 27);
            this.MaxSum.TabIndex = 8;
            // 
            // MinSum
            // 
            this.MinSum.FormattingEnabled = true;
            this.MinSum.Location = new System.Drawing.Point(4, 36);
            this.MinSum.Margin = new System.Windows.Forms.Padding(4);
            this.MinSum.Name = "MinSum";
            this.MinSum.Size = new System.Drawing.Size(103, 27);
            this.MinSum.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BankLoanGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClientDataGrit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1518, 723);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7037F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2963F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Sum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Terms, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 361);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 265);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Срок кредитования";
            // 
            // Sum
            // 
            this.Sum.DecimalPlaces = 3;
            this.Sum.Location = new System.Drawing.Point(163, 5);
            this.Sum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(139, 26);
            this.Sum.TabIndex = 2;
            this.Sum.ThousandsSeparator = true;
            // 
            // Terms
            // 
            this.Terms.Location = new System.Drawing.Point(163, 39);
            this.Terms.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.Terms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(139, 26);
            this.Terms.TabIndex = 3;
            this.Terms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Поручитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Залог";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.90722F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.09278F));
            this.tableLayoutPanel8.Controls.Add(this.Guarantor, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(163, 73);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(382, 104);
            this.tableLayoutPanel8.TabIndex = 8;
            // 
            // Guarantor
            // 
            this.Guarantor.AutoSize = true;
            this.Guarantor.Location = new System.Drawing.Point(3, 3);
            this.Guarantor.Name = "Guarantor";
            this.Guarantor.Size = new System.Drawing.Size(77, 29);
            this.Guarantor.TabIndex = 7;
            this.Guarantor.Text = "Выбрать";
            this.Guarantor.UseVisualStyleBackColor = true;
            this.Guarantor.Click += new System.EventHandler(this.Guarantor_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.GuarantorList, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(86, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.20879F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(292, 98);
            this.tableLayoutPanel11.TabIndex = 8;
            // 
            // GuarantorList
            // 
            this.GuarantorList.FormattingEnabled = true;
            this.GuarantorList.ItemHeight = 19;
            this.GuarantorList.Location = new System.Drawing.Point(3, 3);
            this.GuarantorList.Name = "GuarantorList";
            this.GuarantorList.Size = new System.Drawing.Size(286, 80);
            this.GuarantorList.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.Pledge, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.PledgeL, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.PledgeCost, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(163, 194);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(98, 54);
            this.tableLayoutPanel9.TabIndex = 9;
            // 
            // Pledge
            // 
            this.Pledge.AutoSize = true;
            this.Pledge.Location = new System.Drawing.Point(3, 3);
            this.Pledge.Name = "Pledge";
            this.Pledge.Size = new System.Drawing.Size(77, 29);
            this.Pledge.TabIndex = 6;
            this.Pledge.Text = "Выбрать";
            this.Pledge.UseVisualStyleBackColor = true;
            this.Pledge.Click += new System.EventHandler(this.Pledge_Click);
            // 
            // PledgeL
            // 
            this.PledgeL.AutoSize = true;
            this.PledgeL.Location = new System.Drawing.Point(95, 0);
            this.PledgeL.Name = "PledgeL";
            this.PledgeL.Size = new System.Drawing.Size(0, 19);
            this.PledgeL.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Стоимость:";
            // 
            // PledgeCost
            // 
            this.PledgeCost.AutoSize = true;
            this.PledgeCost.Location = new System.Drawing.Point(95, 35);
            this.PledgeCost.Name = "PledgeCost";
            this.PledgeCost.Size = new System.Drawing.Size(0, 19);
            this.PledgeCost.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.43781F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.56219F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RateGrid, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(564, 361);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(665, 193);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(238, 146);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Currensy, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(111, 64);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Валюта";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.MinSum, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 77);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(111, 64);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Мин сумма";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.MaxSum, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(123, 77);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(111, 64);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Макс сумма";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ent);
            this.panel1.Controls.Add(this.Ind);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 39);
            this.panel1.TabIndex = 2;
            // 
            // Ent
            // 
            this.Ent.AutoSize = true;
            this.Ent.Location = new System.Drawing.Point(127, 3);
            this.Ent.Name = "Ent";
            this.Ent.Size = new System.Drawing.Size(104, 23);
            this.Ent.TabIndex = 1;
            this.Ent.TabStop = true;
            this.Ent.Text = "для юр лиц";
            this.Ent.UseVisualStyleBackColor = true;
            this.Ent.CheckedChanged += new System.EventHandler(this.Ent_CheckedChanged);
            // 
            // Ind
            // 
            this.Ind.AutoSize = true;
            this.Ind.Checked = true;
            this.Ind.Location = new System.Drawing.Point(15, 3);
            this.Ind.Name = "Ind";
            this.Ind.Size = new System.Drawing.Size(108, 23);
            this.Ind.TabIndex = 0;
            this.Ind.TabStop = true;
            this.Ind.Text = "для физ лиц";
            this.Ind.UseVisualStyleBackColor = true;
            this.Ind.CheckedChanged += new System.EventHandler(this.Ind_CheckedChanged);
            // 
            // ClientDataGrit
            // 
            this.ClientDataGrit.AllowUserToAddRows = false;
            this.ClientDataGrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGrit.Location = new System.Drawing.Point(3, 48);
            this.ClientDataGrit.Name = "ClientDataGrit";
            this.ClientDataGrit.ReadOnly = true;
            this.ClientDataGrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGrit.Size = new System.Drawing.Size(553, 306);
            this.ClientDataGrit.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(563, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 100);
            this.panel2.TabIndex = 4;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(650, 19);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 29);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(560, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 29);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddClientLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClientLoan";
            this.Text = "AddClientLoan";
            this.Load += new System.EventHandler(this.AddClientLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankLoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terms)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BankLoanGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RateGrid;
        private System.Windows.Forms.ComboBox Currensy;
        private System.Windows.Forms.ComboBox MaxSum;
        private System.Windows.Forms.ComboBox MinSum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Ent;
        private System.Windows.Forms.RadioButton Ind;
        private System.Windows.Forms.DataGridView ClientDataGrit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Terms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button Guarantor;
       
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button Pledge;
        private System.Windows.Forms.Label PledgeL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PledgeCost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.ListBox GuarantorList;
        private System.Windows.Forms.Panel panel2;
    }
}

