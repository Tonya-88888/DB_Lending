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

    public partial class BankLoanShowForEmp : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;

        string sqlExpression = "SELECT * FROM vwBankLoan";

        SqlDataAdapter BankLoanViewAdapter;
        SqlDataAdapter BankLoanFilterAdapter;

        SqlDataAdapter CurrensyAdapter;
        SqlDataAdapter RateAdapter;


        public BindingSource BankLoanbs;
        public BindingSource Currensybs;
        public BindingSource Ratebs;
        public BindingSource BLCurrensybs;

        DataSet Currensyds = new DataSet();

        DataSet BankLoan = new DataSet();
        DataSet RateDS = new DataSet();

        string sqlExpression3;
        string sqlExpression5;
        string currValue;
        int CurrentId = 0;

        public BankLoanShowForEmp()
        {
            InitializeComponent();
        }

        private void BankLoanShowForEmp_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();


                BankLoanViewAdapter = new SqlDataAdapter(sqlExpression, connection);

                BankLoan = new DataSet();

                BankLoanViewAdapter.Fill(BankLoan, "view");

                BankLoanGrid.DataSource = BankLoan.Tables["view"];

                currValue = Currensy.SelectedValue.ToString();
                BankLoanGrid.Columns["id"].Visible = false;
            }
        }

        private void BankLoanShowForEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            FilterForBankLoan filterForBankLoan = new FilterForBankLoan();

            filterForBankLoan.FormClosing += new FormClosingEventHandler(FilterForBankLoan_FormClosing);
            filterForBankLoan.ShowDialog();
        }


        void FilterForBankLoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int curr = (sender as FilterForBankLoan).GetText().curr;
                int type = (sender as FilterForBankLoan).GetText().type;
                int termsfrom = (sender as FilterForBankLoan).GetText().termsFrom;
                int termsBefore = (sender as FilterForBankLoan).GetText().termsBefore;
                int sumFrom = (sender as FilterForBankLoan).GetText().sumFrom;
                int sumBefore = (sender as FilterForBankLoan).GetText().sumBefore;

                if ((sender as FilterForBankLoan).GetText().isFilter == 0)
                {
                    BankLoanViewAdapter = new SqlDataAdapter(sqlExpression, connection);

                    BankLoan = new DataSet();

                    BankLoanViewAdapter.Fill(BankLoan, "view");

                    BankLoanGrid.DataSource = BankLoan.Tables["view"];
                }
                else if ((sender as FilterForBankLoan).GetText().isFilter == 1)
                {
                    string sql = String.Format("exec [dbo].[FilterBankLoan] {0}, {1}, {2} , {3} , {4} , {5}",
                    curr, type, termsfrom, termsBefore, sumFrom, sumBefore);

                    BankLoanFilterAdapter = new SqlDataAdapter(sql, connection);
                    BankLoanFilterAdapter.Fill(BankLoan, "filter");

                    BankLoanGrid.ClearSelection();

                    BankLoanGrid.DataSource = BankLoan.Tables["filter"];
                }




            }

        }

        private void Currensy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentId != 0)
            {
                MinSumBox.SelectedValue = CurrentId.ToString();
                MaxSumBox.SelectedValue = CurrentId.ToString();
            }
        }

        private void BankLoanGrid_SelectionChanged(object sender, EventArgs e)
        {
            Currensyds.Clear();
            RateDS.Clear();
            if (BankLoanGrid.CurrentRow != null)
            {
                CurrentId = (int)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["id"];

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    sqlExpression3 = String.Format("exec [dbo].[GetCurrensy] '{0}'", CurrentId);

                    CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);
                    CurrensyAdapter.Fill(Currensyds, "Currensy");

                    Currensy.DataSource = Currensyds.Tables["Currensy"];
                    Currensy.DisplayMember = "Валюта";
                    Currensy.ValueMember = "id";



                    if (Currensy.SelectedValue != null)
                    {


                        MinSumBox.DataSource = Currensyds.Tables["Currensy"];
                        MinSumBox.DisplayMember = "Мин сумм";
                        MinSumBox.ValueMember = "id";

                        MaxSumBox.DataSource = Currensyds.Tables["Currensy"];
                        MaxSumBox.DisplayMember = "Макс сумм";
                        MaxSumBox.ValueMember = "id";

                        currValue = Currensy.SelectedValue.ToString();

                        sqlExpression5 = String.Format("exec [dbo].[GetRate] {0} , {1}", currValue, CurrentId);

                        RateAdapter = new SqlDataAdapter(sqlExpression5, connection);
                        RateAdapter.Fill(RateDS);

                        RateGrid.DataSource = RateDS.Tables[0];

                        RateGrid.Columns["id"].Visible = false;
                    }
                }
            }
        }

        private void Currensy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currValue = Currensy.SelectedValue.ToString();
            // label1.Text = currValue;
            if (currValue != null)
            {
                RateDS.Clear();
                //currValue = Currensy.SelectedValue.ToString();
                sqlExpression5 = String.Format("exec [dbo].[GetRate] {0} , {1}", currValue, CurrentId);

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    RateAdapter = new SqlDataAdapter(sqlExpression5, connection);
                    RateAdapter.Fill(RateDS);

                    RateGrid.DataSource = RateDS.Tables[0];
                }

            }
        }
    }
}

