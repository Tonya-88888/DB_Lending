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
    public static class User { public static int State; }
    public partial class LoginForm : Form
    {
        public SqlConnection connection;
        String sqlExpression10 = "SELECT ORIGINAL_LOGIN()";
        string user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var connectionString = Properties.Settings.Default.connectionString;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
              builder.Password = Password.Text;
              builder.UserID = Login.Text;


            try
            {
                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = sqlExpression10;
                    command.Connection = connection;
                    user = command.ExecuteScalar().ToString();
                    if (user == "Admin")
                    {
                        User.State = 1;
                    }
                    else User.State = 0;

                    EmployeeMenu menu = new EmployeeMenu();
                    menu.Show();

                    this.Hide();
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

                // PassTextBox.Text = "";
                // LoginTextBox.Text = "";

            }



        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
