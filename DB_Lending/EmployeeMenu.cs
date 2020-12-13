using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lending
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(User.State == 1) {
                ShowBankLoan showBankLoan = new ShowBankLoan();
                showBankLoan.Show();
                this.Hide();
            } else if(User.State == 0)
            {
                BankLoanShowForEmp bankLoanShowForEmp = new BankLoanShowForEmp();
                bankLoanShowForEmp.Show();
                this.Hide();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowClient showClient = new ShowClient();
            showClient.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClientLoan addClientLoan = new AddClientLoan();
            addClientLoan.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
