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
    public partial class AddIndForEntity : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;
        int id;
        string fio = "";
        Indi tmp = new Indi();
        public AddIndForEntity()
        {
            InitializeComponent();
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
                //command.ExecuteScalar();


                try
                {
                    tmp.Id = Convert.ToInt32(command.ExecuteScalar());
                    tmp.Fio = ind.Secondname + ind.Firstname + ind.Patronymic;

                    this.Close();                  
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
            this.Close();

            //AddEntity addEnt = new AddEntity();

          //  addEnt.Show();         
        }

        private void AddIndForEntity_Load(object sender, EventArgs e)
        {

        }

        public Indi GetText()
        {
            return tmp;
        }
    }
}
