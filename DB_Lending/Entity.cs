using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lending
{
    public class Entity
    {
        int id;
        string name;
        string addres;
        string phoneNumber;
        string fio;
        int idInd;

        public int IdInd { get => idInd; set => idInd = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Addres { get => addres; set => addres = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Fio { get => fio; set => fio = value; }
    }
}
