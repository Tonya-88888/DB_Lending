using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lending
{
    public partial class AddEntity : Form
    {

        int id ;
        string fio = "";

        public static Control addEntity;

        public AddEntity()
        {
            InitializeComponent();
        }

        public void GetInd(int ID, string FIO)
        {
            id = ID;
            fio = FIO;
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            SelectIndividual sInd = new SelectIndividual();
            sInd.Show();

            this.Hide();
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {
            if (fio != "")
            {
                FIO.Text = fio + id.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddIndForEntity aInd = new AddIndForEntity();
            aInd.Show();

            
        }
    }
}
