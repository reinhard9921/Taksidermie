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
        private double tropheemountid;
        private double total;
        private double deposit;
        private double Discount;

        public int Invoicenumber { get => invoicenumber; set => invoicenumber = value; }
        public string Number { get => number; set => number = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public double Tropheemountid { get => tropheemountid; set => tropheemountid = value; }
        public double Total { get => total; set => total = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double Discount1 { get => Discount; set => Discount = value; }

        public Trophee(int invoicenumber, string number, int amount, string remarks, double tropheemountid, double total, double deposit, double discount)
        {
            this.invoicenumber = invoicenumber;
            this.number = number;
            this.amount = amount;
            this.remarks = remarks;
            this.tropheemountid = tropheemountid;
            this.total = total;
            this.deposit = deposit;
            Discount = discount;
        }
    }
}
