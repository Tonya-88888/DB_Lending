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
    public partial class AddEntity : Form
    {

        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;

        int id;
        string fio = "";
        string name;
        string addres;
        string phoneNumber;

        public static Control addEntity;

        public AddEntity()
        {
            InitializeComponent();
        }

        public void GetInd(int ID, string str)
        {
            id = ID;
            fio = str;

            FIOInd.Text = fio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectIndividual sInd = new SelectIndividual();

            sInd.FormClosing += new FormClosingEventHandler(SelectIndividual_FormClosing);
            sInd.ShowDialog();
        }

        void SelectIndividual_FormClosing(object sender, FormClosingEventArgs e)
        {
            FIOInd.Text = (sender as SelectIndividual).GetText().fio;
            id = (sender as SelectIndividual).GetText().id;
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {     

            AddIndForEntity aInd = new AddIndForEntity();
     
            aInd.FormClosing += new FormClosingEventHandler(AddIndForEntity_FormClosing);
            aInd.ShowDialog();
        }


        void AddIndForEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            FIOInd.Text = (sender as AddIndForEntity).GetText().Fio;
            id = (sender as AddIndForEntity).GetText().Id;
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (EntityName.TextLength == 0)
            {
                MessageBox.Show(
                  "Данные о названии  не введены",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
            }
            else if (AddresEn.TextLength == 0)
            {
                MessageBox.Show(
                    "Данные об адресе не введены",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else if (PhoneNumberEn.TextLength != 17)
            {
                MessageBox.Show(
                  "Номер телефона введен некорректно",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1);
            }
            else if (FIOInd.Text == "")
            {
                MessageBox.Show(
                 "Не выбран представитель",
                 "Сообщение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);
            }
            else
            {
                name = EntityName.Text;
                addres = AddresEn.Text;
                phoneNumber = PhoneNumberEn.Text;

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String sqlExpression = String.Format("exec InsertEntity'{0}','{1}','{2}',{3}",
                        name, addres, phoneNumber, id);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression;
                    command.Connection = connection;
                    command.ExecuteScalar();

                    this.Close();

                    ShowClient shC = new ShowClient();

                    shC.Show();
                }
            }

        }

        private void AddEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowClient showBankLoan = new ShowClient();
            showBankLoan.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
