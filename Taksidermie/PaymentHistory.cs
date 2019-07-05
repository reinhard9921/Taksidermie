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
    public partial class PaymentHistory : Form
    {
        DataSet ds = new DataSet();
        DataHandler dh = new DataHandler();
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            ds = dh.ReadPaymentHistory();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblPayment";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dh.SearchPayment(textBox1.Text);

            ds = dh.SearchPayment(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblPayment";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
