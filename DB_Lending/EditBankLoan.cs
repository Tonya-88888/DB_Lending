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
    public partial class EditBankLoan : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;
        String sqlExpression5;

        BankLoanData BLdata;

        SqlDataAdapter TypeAdapter;
        SqlDataAdapter CurrensyAdapter;
        SqlDataAdapter AllCurrensyAdapter;
        SqlDataAdapter RateAdapter;

        DataSet EditBL = new DataSet();
        DataSet Currds = new DataSet();
        DataSet Rateds = new DataSet();
        int currValue;
        List<String> currensy = new List<string>();
        public EditBankLoan()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (BankLoanName.TextLength == 0)
            {
                MessageBox.Show(
                  "Данные о названии кредита не введены",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (TypeComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "Данные о типе кредита не введены",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
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
                    int idType = Int32.Parse(TypeComboBox.SelectedValue.ToString());
                    //int before = Int32.Parse(TypeComboBox.SelectedValue.ToString());
                    String bankLoanName = BankLoanName.Text;
                    int termFor = Int32.Parse(TermFor.Value.ToString());
                    int termBefore = Int32.Parse(TermBefore.Value.ToString());
                    int guarNumber = Int32.Parse(GuarNumber.Value.ToString());
                    decimal pre = Decimal.Parse(PrePenalty.Value.ToString());
                    int isPledge = IsPledge.Checked ? 1 : 0;
                    int indv = IndRadioButton.Checked ? 0 : 1;
                    decimal delay = DelayPenalty.Value;
                    decimal preRenalty = PrePenalty.Value;
                    int reteType = ChanRate.Checked ? 1 : 0;

                    String sqlExpression1 = String.Format("[dbo].[UpdatetBankLoan] {0},'{1}',{2},{3},{4},{5},{6},{7},{8},{9},{10}"
                        , BLdata.CurrentId, bankLoanName, termFor, termBefore, indv, guarNumber, isPledge, preRenalty, delay, reteType, idType);


                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression1;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }

            }
        }
        public void PassValue(BankLoanData value)
        {
            BLdata = value;
        }

        private void EditBankLoan_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                string sqlExpression2 = "select * from dbo.vwGetLoanType ";
                string sqlExpression4 = "select * from dbo.vwCurrensy";


                TypeAdapter = new SqlDataAdapter(sqlExpression2, connection);
                // CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);

                TypeAdapter.Fill(EditBL, "Type");
                // CurrensyAdapter.Fill(EditBL, "LoanSum");

                TypeComboBox.DataSource = EditBL.Tables["Type"];
                TypeComboBox.DisplayMember = "Name";
                TypeComboBox.ValueMember = "id";

                int index = TypeComboBox.FindString(BLdata.Type);
                TypeComboBox.SelectedIndex = index;

                BankLoanName.Text = BLdata.Name;
                if (String.Compare(BLdata.Affiliation, "Для физ лиц") == 0)
                {
                    IndRadioButton.Checked = true;
                }
                else EntRadioButton.Checked = true;

                if (String.Compare(BLdata.RateType, "фикс") == 0)
                {
                    FixRate.Checked = true;
                }
                else ChanRate.Checked = true;

                PrePenalty.Value = BLdata.PrePenalty;
                DelayPenalty.Value = BLdata.DelayPenalty;

                TermBefore.Value = BLdata.TermsBefore;
                TermFor.Value = BLdata.TermsFrom;

                if (String.Compare(BLdata.IsPledge, "Да") == 0)
                {
                    IsPledge.Checked = true;
                }
                else IsPledge.Checked = false;

                GuarNumber.Value = BLdata.GuarNumber;
                //---------------------------------------------------------------------------------------------------

                string sqlExpression3 = String.Format("exec [dbo].[GetCurrensy] '{0}'", BLdata.CurrentId);

                CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);
                CurrensyAdapter.Fill(Currds);

                CurrBLGrid.DataSource = Currds.Tables[0];

                foreach (DataRow dr in Currds.Tables[0].Rows)
                {

                    currensy.Add(dr["id"].ToString());

                }

                CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);
                AllCurrensyAdapter = new SqlDataAdapter(sqlExpression4, connection);

                AllCurrensyAdapter.Fill(EditBL, "AllCurrensy");

                CurrComboBox.DataSource = EditBL.Tables["AllCurrensy"];
                CurrComboBox.DisplayMember = "Name";
                CurrComboBox.ValueMember = "id";

                String sqlExpression9 = String.Format("exec [dbo].[GetTermRate] {0}", BLdata.CurrentId);

                RateAdapter = new SqlDataAdapter(sqlExpression9, connection);

                RateAdapter.Fill(Rateds);
                RateDataGridView.DataSource = Rateds.Tables[0];

                CurrCurrensy.DataSource = EditBL.Tables["AllCurrensy"];
                CurrCurrensy.DisplayMember = "Name";
                CurrCurrensy.ValueMember = "id";
            }

        }

        private void CurrBLGrid_SelectionChanged(object sender, EventArgs e)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            if (CurrComboBox.SelectedValue != null && CurrBLGrid.CurrentRow != null)
            {
                MinSum.Value = (decimal)(Currds.Tables[0].Rows[CurrBLGrid.CurrentRow.Index]["Мин сумм"]);
                MaxSum.Value = (decimal)(Currds.Tables[0].Rows[CurrBLGrid.CurrentRow.Index]["Макс сумм"]);

                // int index = CurrComboBox.FindString((int)EditBL.Tables["Currensy"].Rows[CurrBLGrid.CurrentRow.Index]["id"]);
                CurrComboBox.SelectedValue = (int)Currds.Tables[0].Rows[CurrBLGrid.CurrentRow.Index]["id"];

            }

        }

        private void RateDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RateDataGridView.CurrentRow != null)
            {
                GapFrom.Value = (byte)(Rateds.Tables[0].Rows[RateDataGridView.CurrentRow.Index]["От"]);
                GapBefore.Value = (byte)(Rateds.Tables[0].Rows[RateDataGridView.CurrentRow.Index]["До"]);

                Rate.Value = (decimal)(Rateds.Tables[0].Rows[RateDataGridView.CurrentRow.Index]["Ставка"]);

                CurrCurrensy.SelectedValue = (int)Rateds.Tables[0].Rows[RateDataGridView.CurrentRow.Index]["id"];
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ShowBankLoan sbl = new ShowBankLoan();
            sbl.Show();

            this.Hide();
        }

        private void CurEdit_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int currId = Int32.Parse(CurrComboBox.SelectedValue.ToString());

                String sqlExpression5 = String.Format("[dbo].[UpdateLoanSum] {0},{1},{2},{3}",
                    MinSum.Value, MaxSum.Value, BLdata.CurrentId, currId);


                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression5;
                command.Connection = connection;
                command.ExecuteNonQuery();

                Currds.Clear();

                string sqlExpression3 = String.Format("exec [dbo].[GetCurrensy] '{0}'", BLdata.CurrentId);

                CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);
                CurrensyAdapter.Fill(Currds);

                CurrBLGrid.DataSource = Currds.Tables[0];

            }
        }

        private void EditRate_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int currId = Int32.Parse(CurrCurrensy.SelectedValue.ToString());

                String sqlExpression5 = String.Format("[dbo].[UpdateRate] {0},{1},{2},{3},{4}",
                    GapFrom.Value, GapBefore.Value, Rate.Value, BLdata.CurrentId, currId);


                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression5;
                command.Connection = connection;
                command.ExecuteNonQuery();

                Rateds.Clear();
                String sqlExpression9 = String.Format("exec [dbo].[GetTermRate] {0}", BLdata.CurrentId);

                RateAdapter = new SqlDataAdapter(sqlExpression9, connection);

                RateAdapter.Fill(Rateds);
                RateDataGridView.DataSource = Rateds.Tables[0];

            }
        }

        private void GapFrom_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String currValue = CurrComboBox.SelectedValue.ToString();
                if (!currensy.Contains(currValue))
                {

                    Currds.Clear();
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
                            "values({0},{1},{2},{3})", MinSum.Value, MaxSum.Value, BLdata.CurrentId, CurrComboBox.SelectedValue);

                        SqlCommand command = new SqlCommand();
                        command.CommandText = sqlExpression6;
                        command.Connection = connection;
                        command.ExecuteNonQuery();


                        String sqlExpression5 = String.Format("exec [dbo].[GetCurrensy] {0}", BLdata.CurrentId);

                        CurrensyAdapter = new SqlDataAdapter(sqlExpression5, connection);

                        CurrensyAdapter.Fill(Currds);

                        CurrBLGrid.DataSource = Currds.Tables[0];

                        CurrCurrensy.DataSource = Currds.Tables[0];
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

        private void DeleteCurr_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int currId = Int32.Parse(CurrComboBox.SelectedValue.ToString());

                String sqlExpression5 = String.Format("[dbo].[DeleteLoanSum] {0},{1}",
                    BLdata.CurrentId, currId);

                currensy.Remove(currId.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression5;
                command.Connection = connection;
                command.ExecuteNonQuery();

                Currds.Clear();

                string sqlExpression3 = String.Format("exec [dbo].[GetCurrensy] '{0}'", BLdata.CurrentId);

                CurrensyAdapter = new SqlDataAdapter(sqlExpression3, connection);
                CurrensyAdapter.Fill(Currds);

                CurrBLGrid.DataSource = Currds.Tables[0];

                foreach (DataGridViewRow row in CurrBLGrid.SelectedRows)
                {
                    CurrBLGrid.Rows.Remove(row);
                }
            }
        }

        private void AddRate_Click(object sender, EventArgs e)
        {
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
                            "values({0},{1},{2},{3},{4})", GapFrom.Value, GapBefore.Value, Rate.Value, CurrCurrensy.SelectedValue, BLdata.CurrentId);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression8;
                    command.Connection = connection;
                    command.ExecuteNonQuery();

                    Rateds.Clear();
                  

                    String sqlExpression9 = String.Format("exec [dbo].[GetTermRate] {0}", BLdata.CurrentId);

                    RateAdapter = new SqlDataAdapter(sqlExpression9, connection);

                    RateAdapter.Fill(Rateds);
                    RateDataGridView.DataSource = Rateds.Tables[0];

                }
            }
        }

        private void DeleteRate_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int currId = Int32.Parse(CurrCurrensy.SelectedValue.ToString());

                int rateId = (int)Rateds.Tables[0].Rows[RateDataGridView.CurrentRow.Index]["id"];

                String sqlExpression5 = String.Format("[dbo].[DeleteRate] {0}", rateId);

                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression5;
                command.Connection = connection;
                command.ExecuteNonQuery();

                Rateds.Clear();

                string sqlExpression3 = String.Format("exec [dbo].[GetTermRate] '{0}'", BLdata.CurrentId);

                RateAdapter = new SqlDataAdapter(sqlExpression3, connection);
                RateAdapter.Fill(Rateds);

                RateDataGridView.DataSource = Rateds.Tables[0];

                foreach (DataGridViewRow row in CurrBLGrid.SelectedRows)
                {
                    RateDataGridView.Rows.Remove(row);
                }
            }
        }
    }
}
