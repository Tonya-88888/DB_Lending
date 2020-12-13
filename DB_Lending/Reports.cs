using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Lending
{
    public partial class Reports : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;

        SqlDataAdapter BankLoanViewAdapter;
        DataSet BankLoan;

        string sqlExpression = "SELECT * FROM vwBankLoan";

        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1.Show();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                BankLoanViewAdapter = new SqlDataAdapter(sqlExpression, connection);

                BankLoan = new DataSet();

               


               // dataSet1.Ta = BankLoan.Tables[0];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            report2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report3.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
        }
    }
}
