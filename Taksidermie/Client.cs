using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksidermie
{
    class Client
    {

        private string name;
        private string surname;
        private string email;
        private string cell;
        private string phone;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Phone { get => phone; set => phone = value; }

        public Client(string name, string surname, string email, string cell, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.cell = cell;
            this.phone = phone;
        }
    }
}
