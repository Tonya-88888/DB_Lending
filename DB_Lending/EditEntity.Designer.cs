
namespace DB_Lending
{
    partial class EditEntity
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddInd = new System.Windows.Forms.Button();
            this.EditInd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.PhoneNumberEn = new System.Windows.Forms.MaskedTextBox();
            this.AddresEn = new System.Windows.Forms.TextBox();
            this.FIOInd = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EntityName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberEn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddresEn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FIOInd, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 231);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 45);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер телефона";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddInd);
            this.panel2.Controls.Add(this.EditInd);
            this.panel2.Location = new System.Drawing.Point(183, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 35);
            this.panel2.TabIndex = 13;
            // 
            // AddInd
            // 
            this.AddInd.Location = new System.Drawing.Point(137, 3);
            this.AddInd.Name = "AddInd";
            this.AddInd.Size = new System.Drawing.Size(84, 29);
            this.AddInd.TabIndex = 1;
            this.AddInd.Text = "Добавить";
            this.AddInd.UseVisualStyleBackColor = true;
            this.AddInd.Click += new System.EventHandler(this.AddInd_Click);
            // 
            // EditInd
            // 
            this.EditInd.Location = new System.Drawing.Point(3, 3);
            this.EditInd.Name = "EditInd";
            this.EditInd.Size = new System.Drawing.Size(84, 29);
            this.EditInd.TabIndex = 0;
            this.EditInd.Text = "Выбрать";
            this.EditInd.UseVisualStyleBackColor = true;
            this.EditInd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Представитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "ФИО";
            // 
            // EntityName
            // 
            this.EntityName.Location = new System.Drawing.Point(183, 5);
            this.EntityName.MaxLength = 30;
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(250, 26);
            this.EntityName.TabIndex = 17;
            // 
            // PhoneNumberEn
            // 
            this.PhoneNumberEn.Location = new System.Drawing.Point(183, 99);
            this.PhoneNumberEn.Mask = "(375)00-000-00-00";
            this.PhoneNumberEn.Name = "PhoneNumberEn";
            this.PhoneNumberEn.Size = new System.Drawing.Size(250, 26);
            this.PhoneNumberEn.TabIndex = 18;
            // 
            // AddresEn
            // 
            this.AddresEn.Location = new System.Drawing.Point(183, 52);
            this.AddresEn.MaxLength = 100;
            this.AddresEn.Name = "AddresEn";
            this.AddresEn.Size = new System.Drawing.Size(250, 26);
            this.AddresEn.TabIndex = 19;
            // 
            // FIOInd
            // 
            this.FIOInd.AutoSize = true;
            this.FIOInd.Location = new System.Drawing.Point(183, 186);
            this.FIOInd.Name = "FIOInd";
            this.FIOInd.Size = new System.Drawing.Size(0, 19);
            this.FIOInd.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.79311F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 387);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cancel);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(249, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 46);
            this.panel3.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(99, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 29);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.Location = new System.Drawing.Point(9, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(85, 29);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Изменить";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EditEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 416);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "EditEntity";
            this.Text = "EditEntity";
            this.Load += new System.EventHandler(this.EditEntity_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddInd;
        private System.Windows.Forms.Button EditInd;
        private System.Windows.Forms.TextBox EntityName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox PhoneNumberEn;
        private System.Windows.Forms.TextBox AddresEn;
        private System.Windows.Forms.Label FIOInd;
    }
}