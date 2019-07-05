using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksidermie
{
    class Trophee
    {
        private int invoicenumber;
        private string number;
        private int amount;
        private string remarks;
        private string animaltype;
        private string mounttype;
        private string date;
        private double total;
        private double deposit;
        private double discount;

        public int Invoicenumber { get => invoicenumber; set => invoicenumber = value; }
        public string Number { get => number; set => number = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Animaltype { get => animaltype; set => animaltype = value; }
        public string Mounttype { get => mounttype; set => mounttype = value; }
        public string Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double Discount { get => discount; set => discount = value; }

        public Trophee(int invoicenumber, string number, int amount, string remarks, string animaltype, string mounttype, string date, double total, double deposit, double discount)
        {
            this.invoicenumber = invoicenumber;
            this.number = number;
            this.amount = amount;
            this.remarks = remarks;
            this.animaltype = animaltype;
            this.mounttype = mounttype;
            this.date = date;
            this.total = total;
            this.deposit = deposit;
            this.discount = discount;
        }
    }
}
