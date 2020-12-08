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
using System.Configuration;

namespace DB_Lending
{
    public static class User { public static string Name; }

    public partial class LogIn : Form
    {
        public SqlConnection connection;
        String sqlExpression10 = "SELECT ORIGINAL_LOGIN()";
        string user;
        public LogIn()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var connectionString = Properties.Settings.Default.connectionString;

            SqlConnectionStringBuilder builder =
          new SqlConnectionStringBuilder(connectionString);
            builder.Password = PassTextBox.Text;
            builder.UserID = LoginTextBox.Text;


            try
            {
                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression10;
                    command.Connection = connection;
                     user = command.ExecuteScalar().ToString();
                    User.Name = user;
                }
            }
            catch
            {
                MessageBox.Show(
               "Не верные логин и/или пароль",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            }
            if(user == "Admin")
            {

            }else if(user == "BankEmployee")
            {

            }
          

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
