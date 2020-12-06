using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DB_Lending
{

    public partial class AddBankLoan : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;


        SqlDataAdapter TypeAdapter;
        SqlDataAdapter CurrensyAdapter;
        SqlDataAdapter CurrensyBLAdapter;
        SqlDataAdapter RateAdapter;
        SqlDataAdapter BLAdapter;
        SqlDataAdapter CurrensyRateAdapter;

        DataSet AddBL;
        DataSet CurrBL = new DataSet();
        DataSet BankLoan = new DataSet();
        DataSet Rateds = new DataSet();
        int insertedID;

        List<string> currensy = new List<string>();
        List<string> tmpcurrensy = new List<string>();


        public AddBankLoan()
        {
            InitializeComponent();
        }

        private void AddBankLoan_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


            this.WindowState = FormWindowState.Maximized;

            using (connection = new SqlConnection(connectionString))
            {
                string sqlExpression2 = "select * from dbo.vwGetLoanType ";
                string sqlExpression3 = "select * from dbo.vwCurrensy";


                TypeAdapter = new SqlDataAdapter(sqlExpression2, connection);
                CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);

                AddBL = new DataSet();

                TypeAdapter.Fill(AddBL, "Type");
                CurrensyAdapter.Fill(AddBL, "LoanSum");

                TypeComboBox.DataSource = AddBL.Tables["Type"];
                TypeComboBox.DisplayMember = "Name";
                TypeComboBox.ValueMember = "id";

                CurrComboBox.DataSource = AddBL.Tables["LoanSum"];
                CurrComboBox.DisplayMember = "Name";
                CurrComboBox.ValueMember = "id";
            }
        }

        private void dg_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BankLoanName.TextLength == 0)
            {
                MessageBox.Show(
                  "Данные о названии кредита не введены",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
            }
            else if (TypeComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "Данные о типе кредита не введены",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else if (TermBefore.Value <= TermFor.Value)
            {
                MessageBox.Show(
                   "Минимальный срок кредитования не может быть больше или равным максимальному",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
            }
            else
            {

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int askjdnm = Int32.Parse(TypeComboBox.SelectedValue.ToString());
                    //int before = Int32.Parse(TypeComboBox.SelectedValue.ToString());
                    String str = BankLoanName.Text;
                    int isPledge = IsPledge.Checked ? 1 : 0;
                    int indv = IndRadioButton.Checked ? 0 : 1;
                    decimal pre = Decimal.Parse(PrePenalty.Value.ToString());
                    decimal delay = Decimal.Parse(DelayPenalty.Value.ToString());

                    String sqlExpression1 = String.Format("INSERT INTO BankLoan (LoanName,TermFrom,TermBefore,IndvOrEntity,GuarNumber,IsPledge,PrePenalty,DelayPenalty,RateType,FKType)  values('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9}) SET @INSERTED_ID=SCOPE_IDENTITY()",
                   str, Int32.Parse(TermFor.Value.ToString()), Int32.Parse(TermBefore.Value.ToString()), indv,
                    Int32.Parse(GuarNumber.Value.ToString()), isPledge, PrePenalty.Value, delay, ChanRate.Checked ? 1 : 0, askjdnm);

                    string sqlExpression4 = "select * from BankLoan";
                    BLAdapter = new SqlDataAdapter(sqlExpression4, connection);
                    BLAdapter.Fill(BankLoan);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression1;
                    command.Connection = connection;

                    var pID = new SqlParameter();
                    pID.ParameterName = "INSERTED_ID";
                    pID.Size = 6;
                    pID.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pID);

                    command.ExecuteNonQuery();

                    insertedID = Int32.Parse(pID.Value.ToString());
                    //id.Text = insertedID.ToString();

                    // int returnValue = (int)this.BLAdapter.InsertCommand.ExecuteScalar();
                }
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox4.Enabled = true;

            }

        }

        private void CurAdd_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String currValue = CurrComboBox.SelectedValue.ToString();
                if (!currensy.Contains(currValue))
                {

                    CurrBL.Clear();
                    currensy.Add(currValue);

                    if (MaxSum.Value <= MinSum.Value)
                    {
                        MessageBox.Show(
                       "Минимальная сумма кредита не может быть больше или равной максимальной",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                    }
                    else
                    {

                        String sqlExpression6 = String.Format("insert into LoanSum ( MinSum ,MaxSum,FKBankLoan,FKCurrensy) " +
                            "values({0},{1},{2},{3})", MinSum.Value, MaxSum.Value, insertedID, CurrComboBox.SelectedValue);

                        SqlCommand command = new SqlCommand();
                        command.CommandText = sqlExpression6;
                        command.Connection = connection;
                        command.ExecuteNonQuery();


                        String sqlExpression5 = String.Format("exec [dbo].[GetCurrensy] {0}", insertedID);

                        CurrensyBLAdapter = new SqlDataAdapter(sqlExpression5, connection);

                        CurrensyBLAdapter.Fill(CurrBL);
                        CurrBLGrid.DataSource = CurrBL.Tables[0];


                        CurrCurrensy.DataSource = CurrBL.Tables[0];
                        CurrCurrensy.DisplayMember = "Валюта";
                        CurrCurrensy.ValueMember = "id";
                    }
                }
                else
                {
                    MessageBox.Show(
                  "Невозможно добавить одну и туже валюту к одному кредиту.",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
                }

            }

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRateButton_Click(object sender, EventArgs e)
        {
            //insert into Rate(TermFrom, termBefore, RateValue, FKCurrensy, FKBankLoan) values()
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String currValue = CurrCurrensy.SelectedValue.ToString();
           
                    if (GapFrom.Value >= GapBefore.Value)
                    {
                        MessageBox.Show(
                       "Начало промежутка кредитования не может быть больше, чем его конец",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                    }
                    else
                    {

                        String sqlExpression8 = String.Format("insert into Rate (TermFrom, TermBefore, RateValue, FKCurrensy, FKBankLoan) " +
                                "values({0},{1},{2},{3},{4})", GapFrom.Value, GapBefore.Value, Rate.Value, CurrCurrensy.SelectedValue, insertedID);

                        SqlCommand command = new SqlCommand();
                        command.CommandText = sqlExpression8;
                        command.Connection = connection;
                        command.ExecuteNonQuery();

                        Rateds.Clear();
                        tmpcurrensy.Add(currValue);

                        String sqlExpression9 = String.Format("exec [dbo].[GetTermRate] {0}", insertedID);

                        RateAdapter = new SqlDataAdapter(sqlExpression9, connection);

                        RateAdapter.Fill(Rateds);
                        RateDataGridView.DataSource = Rateds.Tables[0];

                    }               
            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ShowBankLoan sbl = new ShowBankLoan();
            sbl.Show();

            //ShowBankLoan bl = new ShowBankLoan();
            this.Hide();
        }

        private void CurAdd_Click_1(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String currValue = CurrComboBox.SelectedValue.ToString();
                if (!currensy.Contains(currValue))
                {

                    CurrBL.Clear();
                    currensy.Add(currValue);

                    if (MaxSum.Value <= MinSum.Value)
                    {
                        MessageBox.Show(
                       "Минимальная сумма кредита не может быть больше или равной максимальной",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                    }
                    else
                    {

                        String sqlExpression6 = String.Format("insert into LoanSum ( MinSum ,MaxSum,FKBankLoan,FKCurrensy) " +
                            "values({0},{1},{2},{3})", MinSum.Value, MaxSum.Value, insertedID, CurrComboBox.SelectedValue);

                        SqlCommand command = new SqlCommand();
                        command.CommandText = sqlExpression6;
                        command.Connection = connection;
                        command.ExecuteNonQuery();


                        String sqlExpression5 = String.Format("exec [dbo].[GetCurrensy] {0}", insertedID);

                        CurrensyBLAdapter = new SqlDataAdapter(sqlExpression5, connection);

                        CurrensyBLAdapter.Fill(CurrBL);
                        CurrBLGrid.DataSource = CurrBL.Tables[0];


                        CurrCurrensy.DataSource = CurrBL.Tables[0];
                        CurrCurrensy.DisplayMember = "Валюта";
                        CurrCurrensy.ValueMember = "id";
                    }
                }
                else
                {
                    MessageBox.Show(
                  "Невозможно добавить одну и туже валюту к одному кредиту.",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
                }

            }

        }
    }
}

