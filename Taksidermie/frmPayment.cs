using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksidermie
{
    public partial class frmPayment : Form
    {
        int publicid;
        int Check1;
        public frmPayment(int id, int Check)
        {
            Check1 = Check;
            publicid = id;
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        int FId;
        int CID;
        double Outstanding;
        public delegate void MyHandler();
        public event MyHandler MyEventHandler;
        public delegate void MyHandler2();
        public event MyHandler2 MySecondEventHandler;
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            double amount;
            double credit;
            double cred1;
            int deposit;
            amount = double.Parse(txtSurname.Text);
            dh.MakePayment(dateTimePicker1.Value.Date, publicid, cmbPaymentType.Text, amount);
            Outstanding = dh.GetOutstanding(publicid);

            if (chbDeposit.Checked == true)
            {
                deposit = 1;
                MySecondEventHandler?.Invoke();

            }
            else if (chbDeposit.Checked == true && Check1 == 1 || chbDeposit.Checked == false && Check1 == 1)
            {
                deposit = 1;
            }
            else
            {
                deposit = 0;
            }


            if (amount  > Outstanding)
            {
                credit = amount - Outstanding;
                Outstanding = 0;
                cred1 = dh.GetCredit(CID);
                credit = cred1 + credit;
                dh.UpdateCredit(credit, CID);

                dh.CalculateOutstanding(publicid, Outstanding, deposit);
                MyEventHandler?.Invoke();
                this.Close();
            }
            else
            {

                Outstanding = Outstanding - amount;
                dh.CalculateOutstanding(publicid, Outstanding, deposit);
                MyEventHandler?.Invoke();
                this.Close();

            }
            
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            CID = dh.CIDFID(publicid);
        }
    }
}
