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
    public partial class AddClientLoan : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;

        SqlDataAdapter EntitylAdapter;
        SqlDataAdapter IndividualAdapter;
        SqlDataAdapter BankLoanAdapterInd;
        SqlDataAdapter BankLoanAdapterEnt;
        SqlDataAdapter CurrensyAdapter;
        SqlDataAdapter RateAdapter;

       // DataSet Individualds = new DataSet();
        DataSet Clientds = new DataSet();
        DataSet BankLoands = new DataSet();
        DataSet Currensyds = new DataSet();
        DataSet RateDS = new DataSet();

        String sqlExpression = "select * from [dbo].[vwIndividual]";
        String sqlExpression1 = "select * from [dbo].[vwEntity]";
        String sqlExpression2 = "select * from [dbo].[vwBankLoanForInd]";
        String sqlExpression3 = "select * from [dbo].[vwBankLoanForEnt]";

        String sqlExpression6;
        String sqlExpression5;
        String sqlExpression8;


        List<Tuple<string, int>> guarantor = new List<Tuple<string, int>>();

        int CurrentId;
        String currValue;
        int idPledge;
        int idGuarantor;

        ClientLoan tmp = new ClientLoan();

        public AddClientLoan()
        {
            InitializeComponent();
        }

        private void AddClientLoan_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                EntitylAdapter = new SqlDataAdapter(sqlExpression1, connection);
               
                EntitylAdapter.Fill(Clientds, "Ent");

                IndividualAdapter = new SqlDataAdapter(sqlExpression, connection);
                
                IndividualAdapter.Fill(Clientds, "Ind");
                //
                BankLoanAdapterInd = new SqlDataAdapter(sqlExpression2, connection);
                BankLoands = new DataSet();
                BankLoanAdapterInd.Fill(BankLoands, "Ind");

                BankLoanAdapterEnt = new SqlDataAdapter(sqlExpression3, connection);
                
                BankLoanAdapterEnt.Fill(BankLoands, "Ent");

                ClientDataGrit.DataSource = Clientds.Tables["Ind"];
                BankLoanGrid.DataSource = BankLoands.Tables["Ind"];




            }
        }


        private void Ind_CheckedChanged(object sender, EventArgs e)
        {
            if (Ind.Checked)
            {
                BankLoanGrid.ClearSelection();
                ClientDataGrit.ClearSelection();

                ClientDataGrit.DataSource = Clientds.Tables["Ind"];

                ClientDataGrit.Columns["Фамилия"].DisplayIndex = 1;
                ClientDataGrit.Columns["Имя"].DisplayIndex = 2;
                ClientDataGrit.Columns["Отчество"].DisplayIndex = 3;
                ClientDataGrit.Columns["Номер паспорта"].DisplayIndex = 4;
                ClientDataGrit.Columns["Идентификационный номер"].DisplayIndex = 5;
                ClientDataGrit.Columns["Адрес"].DisplayIndex = 6;
                ClientDataGrit.Columns["Номер телефона"].DisplayIndex = 7;

                BankLoanGrid.DataSource = BankLoands.Tables["Ind"];
                BankLoanGrid.Columns[3].Width = 20;

            }
        }

        private void Ent_CheckedChanged(object sender, EventArgs e)
        {
            if (Ent.Checked)
            {
                BankLoanGrid.ClearSelection();
                ClientDataGrit.ClearSelection();

                ClientDataGrit.DataSource = Clientds.Tables["Ent"];
                BankLoanGrid.DataSource = BankLoands.Tables["Ent"];

            }
        }

        private void BankLoanGrid_SelectionChanged(object sender, EventArgs e)
        {
            Currensyds.Clear();
            RateDS.Clear();

            if (Ind.Checked && BankLoanGrid.CurrentRow != null) {
                CurrentId = (int)BankLoands.Tables["Ind"].Rows[BankLoanGrid.CurrentRow.Index]["id"];
            } else if (Ent.Checked && BankLoanGrid.CurrentRow != null)
            {
                CurrentId = (int)BankLoands.Tables["Ent"].Rows[BankLoanGrid.CurrentRow.Index]["id"];
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlExpression6 = String.Format("exec [dbo].[GetCurrensy] '{0}'", CurrentId);

                CurrensyAdapter = new SqlDataAdapter(sqlExpression6, connection);
                CurrensyAdapter.Fill(Currensyds, "Currensy");

                Currensy.DataSource = Currensyds.Tables["Currensy"];
                Currensy.DisplayMember = "Валюта";
                Currensy.ValueMember = "id";

                if (Currensy.SelectedValue != null)
                {


                    MinSum.DataSource = Currensyds.Tables["Currensy"];
                    MinSum.DisplayMember = "Мин сумм";
                    MinSum.ValueMember = "id";

                    MaxSum.DataSource = Currensyds.Tables["Currensy"];
                    MaxSum.DisplayMember = "Макс сумм";
                    MaxSum.ValueMember = "id";

                    currValue = Currensy.SelectedValue.ToString();

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

        private void Currensy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentId != 0)
            {
                MinSum.SelectedValue = CurrentId.ToString();
                MaxSum.SelectedValue = CurrentId.ToString();
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

        private void Pledge_Click(object sender, EventArgs e)
        {
            SelectPledge sInd = new SelectPledge();

            sInd.FormClosing += new FormClosingEventHandler(SelectPledge_FormClosing);
            sInd.ShowDialog();
        }
        void SelectPledge_FormClosing(object sender, FormClosingEventArgs e)
        {
            PledgeL.Text = (sender as SelectPledge).GetText().Name;
            PledgeCost.Text = (sender as SelectPledge).GetText().Cost;
            idPledge = (sender as SelectPledge).GetText().Id;
        }

        private void Guarantor_Click(object sender, EventArgs e)
        {

            SelectIndividual sInd = new SelectIndividual();

            sInd.FormClosing += new FormClosingEventHandler(SelectIndividual_FormClosing);
            sInd.ShowDialog();
        }

        void SelectIndividual_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fio = (sender as SelectIndividual).GetText().fio;
            idGuarantor = (sender as SelectIndividual).GetText().id;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = fio;

            listBox1.Items.Insert(0, fio);


            guarantor.Add(Tuple.Create(fio, idGuarantor));
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (ClientDataGrit.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                "Не выбран получатель кредита",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            } else if (BankLoanGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show(
               "Не выбран кредит",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);

            }
            else 
            {

                tmp.IdBankLoan = Convert.ToInt32(BankLoanGrid.CurrentRow.Cells["id"].FormattedValue);
                tmp.IdClient = Convert.ToInt32(ClientDataGrit.CurrentRow.Cells["id"].FormattedValue);
                tmp.TermsLoan = Convert.ToInt32(Terms.Value);
                tmp.SumLoan = Sum.Value; 
                tmp.PrePenalty = Convert.ToDecimal(ClientDataGrit.CurrentRow.Cells["% за досрочное погашение"].FormattedValue);
                tmp.DelayPenalty = Convert.ToDecimal(ClientDataGrit.CurrentRow.Cells["% за просроченный платеж"].FormattedValue);
                tmp.RateType = ClientDataGrit.CurrentRow.Cells["Тип ставки"].FormattedValue.ToString() == "фикс" ? 0 : 1;
                tmp.Rate = Convert.ToDecimal(RateGrid.CurrentRow.Cells["Ставка"].FormattedValue);
                tmp.TermsFrom = Convert.ToInt32(RateGrid.CurrentRow.Cells["Срок от"].FormattedValue);
                tmp.TermsBefore = Convert.ToInt32(RateGrid.CurrentRow.Cells["Срок до"].FormattedValue);
            }
            //% за просроченный платеж
            // тип ставки
            //Кол-во поручителей
            //Наличие залога
            //Тип ставки фикс плав
            //fk ind fk ent

          /*      if (Decimal.Parse(MaxSum.Text) <= Sum.Value || Sum.Value <= Decimal.Parse(MinSum.Text))
            {
                MessageBox.Show(
               "Сумма выданного кредита должна входить в промежуток от минимальной до максимальной суммы",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            } 
  */
        }
    }
}
