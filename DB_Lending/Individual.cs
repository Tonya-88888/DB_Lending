using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lending
{
    public class Individual
    {
        int id;
        string secondname;
        string firstname;
        string patronymic;
        string passSeries;
        string passID;
        string addres;
        string phoneNumber;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Secondname { get => secondname; set => secondname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string PassSeries { get => passSeries; set => passSeries = value; }
        public string PassID { get => passID; set => passID = value; }
        public string Addres { get => addres; set => addres = value; }
        public int Id { get => id; set => id = value; }
    }
}
