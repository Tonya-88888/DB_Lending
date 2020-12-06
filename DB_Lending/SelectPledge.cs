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
    public partial class SelectPledge : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;
        String sqlExpression = "select * from [dbo].[vwPledge]";

        SqlDataAdapter PledgeAdapter;

        DataSet Pledgeds = new DataSet();
        string name;
        string cost;
        int id;

        public SelectPledge()
        {
            InitializeComponent();
        }

        private void SelectPledge_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                PledgeAdapter = new SqlDataAdapter(sqlExpression, connection);

                PledgeAdapter.Fill(Pledgeds);

                dataGridView1.DataSource = Pledgeds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            name = (string)Pledgeds.Tables[0].Rows[dataGridView1.CurrentRow.Index]["Название"];
               cost = Convert.ToString(Pledgeds.Tables[0].Rows[dataGridView1.CurrentRow.Index]["Стоимость"]);
              
            id = (int)Pledgeds.Tables[0].Rows[dataGridView1.CurrentRow.Index]["id"];

            this.Close();

        }
      
        public (string Name, int Id, string Cost) GetText()
        {
            return(name,id,cost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
