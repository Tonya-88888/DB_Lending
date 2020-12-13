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
    public partial class EditEntity : Form
    {
        string connectionString = @"Server=(local);Database=Lending;User ID=Admin;password=111134";
        public SqlConnection connection;

        Entity tmp;
        public EditEntity()
        {
            InitializeComponent();
        }

        public void SetEntity(Entity value)
        {
            tmp = value;
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
            tmp.IdInd = (sender as SelectIndividual).GetText().id;
        }
        void AddIndForEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            FIOInd.Text = (sender as SelectIndividual).GetText().fio;
            tmp.IdInd = (sender as SelectIndividual).GetText().id;
        }
        private void Edit_Click(object sender, EventArgs e)
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
                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    tmp.Name = EntityName.Text;
                    tmp.Addres = AddresEn.Text;
                    tmp.PhoneNumber = PhoneNumberEn.Text;

                    String sqlExpression1 = String.Format("[dbo].[UpdateEntity] {0},'{1}','{2}','{3}',{4}",
                        tmp.Id, tmp.Name, tmp.Addres, tmp.PhoneNumber, tmp.IdInd);


                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression1;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    ShowClient sh = new ShowClient();
                    sh.Show();
                }
            }
        }

        private void EditEntity_Load(object sender, EventArgs e)
        {
            EntityName.Text = tmp.Name;
            AddresEn.Text = tmp.Addres;
            PhoneNumberEn.Text = tmp.PhoneNumber;
            FIOInd.Text = tmp.Fio;

        }

        private void AddInd_Click(object sender, EventArgs e)
        {

            AddIndForEntity sInd = new AddIndForEntity();

            sInd.FormClosing += new FormClosingEventHandler(AddIndForEntity_FormClosing);
            sInd.ShowDialog();
        }

        private void EditEntity_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowClient showClient = new ShowClient();
            showClient.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
            ShowClient showClient = new ShowClient();
            showClient.Show();

            this.Close();
        }
    }
}
