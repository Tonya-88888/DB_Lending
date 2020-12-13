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
    public partial class FilterForBankLoan : Form
    {
        SqlDataAdapter CurrensyA;
        SqlDataAdapter TypeA;
        DataSet Filterds = new DataSet();
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;
        int IsFilter;

        public FilterForBankLoan()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
             IsFilter = 0;
            this.Close();

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            IsFilter = 0;
            this.Close();

        }

        public (int curr, int type,int termsFrom, int termsBefore, int sumFrom, int sumBefore, int isFilter) GetText()
        {

            return 
                (Convert.ToInt32(Currensy.SelectedValue),
                Convert.ToInt32(Type.SelectedValue),
                Convert.ToInt32(TermsFrom.Value),
                Convert.ToInt32(TermsBefore.Value),
                 Convert.ToInt32(SumFrom.Value),
                 Convert.ToInt32(SumBefore.Value),
                 IsFilter

                );
        }

        private void FilterForBankLoan_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql1 = "select * from dbo.vwCurrensy";
                string sql2 = "select * from dbo.vwGetLoanType";

                CurrensyA = new SqlDataAdapter(sql1, connection);
                CurrensyA.Fill(Filterds, "Currensy");

                Currensy.DataSource = Filterds.Tables["Currensy"];
                Currensy.DisplayMember = "Name";
                Currensy.ValueMember = "id";

                TypeA = new SqlDataAdapter(sql2, connection);
                TypeA.Fill(Filterds, "Type");

                Type.DataSource = Filterds.Tables["Type"];
                Type.DisplayMember = "Name";
                Type.ValueMember = "id";
            }
        }

    }
}
