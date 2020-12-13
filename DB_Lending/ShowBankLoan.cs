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
    public partial class ShowBankLoan : Form
    {
        string connectionString = @"Server=desktop-tqmvuki;Database=Lending;User ID=Admin; password=111134";
        SqlConnection connection;

        string sqlExpression = "SELECT * FROM vwBankLoan";


        SqlDataAdapter BankLoanViewAdapter;

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
        public ShowBankLoan()
        {
            InitializeComponent();



        }

        private void BankLoanGrid_Layout(object sender, LayoutEventArgs e)
        {

        }
        private void ShowBankLoan_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                BankLoanViewAdapter = new SqlDataAdapter(sqlExpression, connection);

                BankLoan = new DataSet();

                BankLoanViewAdapter.Fill(BankLoan);


                //  BankLoanbs = new BindingSource(BankLoan.Tables[0], "");
                BankLoanGrid.DataSource = BankLoan.Tables[0];
               // BankLoanGrid.
                currValue = Currensy.SelectedValue.ToString();
                BankLoanGrid.Columns["id"].Visible = false;
            }

            }
            public void button1_Click(object sender, EventArgs e)
        {




        }

        public void Currensy_SelectedIndexChanged(object sender, EventArgs e)
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

                        using (connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            RateAdapter = new SqlDataAdapter(sqlExpression5, connection);
                            RateAdapter.Fill(RateDS);

                            RateGrid.DataSource = RateDS.Tables[0];
                        }
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


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBankLoan abl = new AddBankLoan();
            abl.Show();            
            this.Hide();
        }

        private void DaleteButton_Click(object sender, EventArgs e)
        {
         
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DialogResult result = MessageBox.Show(
                      "Вы уверенны, что хотите удалить выбранный кредит?",
                      "Сообщение",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                   
                    String sqlExpression10 = String.Format("exec [dbo].[DeleteBankLoan] {0}", CurrentId);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression10;
                    command.Connection = connection;
                    command.ExecuteNonQuery();


                    foreach (DataGridViewRow row in BankLoanGrid.SelectedRows)
                    {
                        BankLoanGrid.Rows.Remove(row);
                    }                
                  
                }
            }
        }

        
        public void EditButton_Click(object sender, EventArgs e)
        {
            EditBankLoan eBL = new EditBankLoan();
            BankLoanData bld = new BankLoanData();
            bld.CurrentId = CurrentId;
            bld.Type = (string)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Тип"];
            bld.Name = (string)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Название"];
            bld.Affiliation = (string)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Принадлежность"];
            bld.RateType = (string)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Тип ставки"]; ;
            bld.PrePenalty = (decimal)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["% за досрочное погашение"];
            bld.DelayPenalty = (decimal)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["% за просроченный платеж"];
            bld.TermsBefore = (int)(BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Срок до"]);
            bld.TermsFrom = (int)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Срок от"];
            bld.IsPledge = (string)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Наличие залога"];
            bld.GuarNumber = (int)BankLoan.Tables[0].Rows[BankLoanGrid.CurrentRow.Index]["Кол-во поручителей"];

            eBL.PassValue(bld);

            eBL.Show();
            this.Hide();           
        }
    }
}

