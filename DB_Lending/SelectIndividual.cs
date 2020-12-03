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
    public partial class SelectIndividual : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;
        SqlDataAdapter EntitylAdapter;
        SqlDataAdapter IndividualAdapter;
        DataSet Individualds = new DataSet();
        DataSet Entityds = new DataSet();
        String sqlExpression = "select * from [dbo].[vwIndividual]";
        String sqlExpression1 = "select * from [dbo].[vwEntity]";
        string fio;
        int id;
        public SelectIndividual()
        {
            InitializeComponent();
        }

        private void SelectIndividual_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IndividualAdapter = new SqlDataAdapter(sqlExpression, connection);

                Individualds = new DataSet();

                IndividualAdapter.Fill(Individualds);

                IdentityGridView.DataSource = Individualds.Tables[0];
                // BankLoanGrid.
                // currValue = Currensy.SelectedValue.ToString();
                // BankLoanGrid.Columns["id"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fio = (string)Individualds.Tables[0].Rows[IdentityGridView.CurrentRow.Index]["Фамилия"] +" "+
                (string)Individualds.Tables[0].Rows[IdentityGridView.CurrentRow.Index]["Имя"] + " "+
                (string)Individualds.Tables[0].Rows[IdentityGridView.CurrentRow.Index]["Отчество"];
            id = (int)Individualds.Tables[0].Rows[IdentityGridView.CurrentRow.Index]["id"];

            AddEntity aEnt = new AddEntity();
            aEnt.GetInd(id, fio);

            aEnt.Show();
            this.Hide();

        }
    }
}
