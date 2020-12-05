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
    public partial class ShowClient : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        SqlConnection connection;

        SqlDataAdapter EntitylAdapter;
        SqlDataAdapter IndividualAdapter;
        DataSet Individualds = new DataSet();
        DataSet Entityds = new DataSet();

        String sqlExpression = "select * from [dbo].[vwIndividual]";
        String sqlExpression1 = "select * from [dbo].[vwEntity]";
        public ShowClient()
        {
            InitializeComponent();
        }

        public void ShowClient_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IndividualAdapter = new SqlDataAdapter(sqlExpression, connection);

                Individualds = new DataSet();

                IndividualAdapter.Fill(Individualds);

                IndividualGridView.DataSource = Individualds.Tables[0];


                EntitylAdapter = new SqlDataAdapter(sqlExpression1, connection);

                Entityds = new DataSet();

                EntitylAdapter.Fill(Entityds);


                EntityGridView.DataSource = Entityds.Tables[0];

            }

        }

      

        private void ClienrControl_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void EntityPage_Enter(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                EntitylAdapter = new SqlDataAdapter(sqlExpression1, connection);

                Entityds = new DataSet();

                EntitylAdapter.Fill(Entityds);


                EntityGridView.DataSource = Entityds.Tables[0];
              
            }
        }

        private void IndividualPage_Enter(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IndividualAdapter = new SqlDataAdapter(sqlExpression, connection);

                Individualds = new DataSet();

                IndividualAdapter.Fill(Individualds);

                IndividualGridView.DataSource = Individualds.Tables[0];
               
                // BankLoanGrid.Columns["id"].Visible = false;
            }
        }

        private void AddIndividual_Click(object sender, EventArgs e)
        {
            AddIndividual addInd = new AddIndividual();
            addInd.Show();
            this.Hide();
        }


        private void DeleteIndividual_Click(object sender, EventArgs e)
        {
            int currId = (int)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["id"];
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String sqlExpression = String.Format("exec DeleteIndividual {0}", currId);

                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression;
                command.Connection = connection;
                command.ExecuteNonQuery();

                foreach (DataGridViewRow row in IndividualGridView.SelectedRows)
                {
                    IndividualGridView.Rows.Remove(row);
                }

                ShowClient_Load(this, null);
            }
        }

        private void EditIndividual_Click(object sender, EventArgs e)
        {
            EditIndividual eInd = new EditIndividual();

            Individual ind = new Individual();
            ind.Id = (int)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["id"];
            ind.Secondname = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Фамилия"];
            ind.Firstname = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Имя"];
            ind.Patronymic = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Отчество"];
            ind.PassSeries = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Номер паспорта"];
            ind.PassID = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Идентификационный номер"];
            ind.Addres = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Адрес"];
            ind.PhoneNumber = (string)Individualds.Tables[0].Rows[IndividualGridView.CurrentRow.Index]["Номер телефона"];

            eInd.SetInd(ind);
            this.Hide();
            
            eInd.Show();
        }

        private void AddEntity_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddEntity aEnt = new AddEntity();
            aEnt.Show();
        }

        private void EditEntity_Click(object sender, EventArgs e)
        {
            /*
             *@PKEntity int ,
	@Name nvarchar(30),
	@Adress nvarchar(100),
	@PhoneNumber nvarchar(15),
	@FKIndividual int*/
            EditEntity eEnt = new EditEntity();


            Entity ent = new Entity();
            ent.Id = (int)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["id"];
            ent.Name = (string)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["Название"];
            ent.Addres = (string)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["Адрес"];
            ent.PhoneNumber = (string)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["Номер телефона"];
            ent.Fio = (string)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["Представитель"];
            ent.IdInd = (int)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["idInd"];

            eEnt.SetEntity(ent);
            this.Hide();

            eEnt.Show();
        }
        
        private void DeleteEntity_Click(object sender, EventArgs e)
        {
            int currId = (int)Entityds.Tables[0].Rows[EntityGridView.CurrentRow.Index]["id"];
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String sqlExpression = String.Format("exec DeleteEntity {0}", currId);

                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression;
                command.Connection = connection;
                command.ExecuteNonQuery();

                foreach (DataGridViewRow row in EntityGridView.SelectedRows)
                {
                    EntityGridView.Rows.Remove(row);
                }

                ShowClient_Load(this, null);
            }
        }
    }
}
