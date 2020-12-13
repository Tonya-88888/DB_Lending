using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lending
{
    public partial class AddIndividual : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;
        int id;
        string fio = "";
        public AddIndividual()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Individual ind = new Individual();
                ind.Secondname = Secondname.Text;
                ind.Firstname = Firstname.Text;
                ind.Patronymic = Patronymic.Text;
                ind.PassSeries = PassSeries.Text;
                ind.PassID = PassID.Text;
                ind.Addres = Addres.Text;
                ind.PhoneNumber = PhoneNumber.Text;


                String sqlExpression = String.Format("exec InsertIndividual '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                    ind.Secondname, ind.Firstname, ind.Patronymic, ind.PassSeries, ind.PassID, ind.Addres, ind.PhoneNumber);

                SqlCommand command = new SqlCommand();
                command.CommandText = sqlExpression;
                command.Connection = connection;
               
                try
                {
                    id = Convert.ToInt32(command.ExecuteScalar());

                    this.Close();
                    ShowClient shC = new ShowClient();

             
                    shC.Show();

                }
                catch
                {
                    string sdf = command.ExecuteScalar().ToString();

                    MessageBox.Show(
                 sdf,
                 "Сообщение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);
                }
              
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ShowClient showClient = new ShowClient();
            showClient.Show();

            this.Close();
        }

        private void AddIndividual_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowClient showClient = new ShowClient();
            showClient.Show();

            
        }
    }
}
