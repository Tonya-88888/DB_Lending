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
    public partial class EditIndividual : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;
        Individual currIndividual = new Individual();
        Individual edit = new Individual();
        public EditIndividual()
        {
            InitializeComponent();
        } 

        public void SetInd(Individual value)
        {
            currIndividual = value;
        }
        private void EditIndividual_Load(object sender, EventArgs e)
        {
            Surname.Text     = currIndividual.Secondname;
            Firstname.Text   = currIndividual.Firstname;
            Patronymic.Text  = currIndividual.Patronymic;
            PassSeries.Text  = currIndividual.PassSeries;
            PassID.Text      = currIndividual.PassID;
            Addres.Text      = currIndividual.Addres;
            PhoneNumber.Text = currIndividual.PhoneNumber;
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                edit.Secondname = Surname.Text;
                edit.Firstname = Firstname.Text;
                edit.Patronymic = Patronymic.Text;
                edit.PassSeries = PassSeries.Text;
                edit.PassID = PassID.Text;
                edit.Addres = Addres.Text;
                edit.PhoneNumber = PhoneNumber.Text;

                String sqlExpression1 = String.Format("[dbo].[UpdateIndividual] {0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}'"
                    , currIndividual.Id, edit.Secondname, edit.Firstname, edit.Patronymic, edit.PassSeries, edit.PassID, edit.Addres, edit.PhoneNumber);


                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression1;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }

        }

        private void Rready_Click(object sender, EventArgs e)
        {
            ShowClient shC = new ShowClient();
            shC.Show();
            this.Hide();

        }
    }
}
