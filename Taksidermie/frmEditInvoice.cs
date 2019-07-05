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
    public partial class frmEditInvoice : Form
    {
        int id;
        string number;
        string amount;
        string animaltype;
        string mounttype;
        string tremarks;
        double deposit;
        string discount;
        double DiscountCalc;
        double totalCalc;
        int iamount;

        string date;
        string total;
        public frmEditInvoice(int id)
        {
            InitializeComponent();
            Fid = id;
        }
        int Fid;
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        DataHandler dh = new DataHandler();
        private void FrmEditInvoice_Load(object sender, EventArgs e)
        {
            dgvTrophees.DataSource = dh.ReadEditInvoice(Fid);
            dgvTrophees.DataMember = "tblTrophee";
            lblInvoice.Text = Fid.ToString();
        }

        private void DgvTrophees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrophees.CurrentCell != null)
            {
                try
                {
                    int index = dgvTrophees.CurrentCell.RowIndex;

                    id = (int)dgvTrophees.Rows[index].Cells[0].Value;

                    number = dgvTrophees.Rows[index].Cells[1].Value.ToString();
                    amount = dgvTrophees.Rows[index].Cells[2].Value.ToString();
                    animaltype = dgvTrophees.Rows[index].Cells[3].Value.ToString();
                    mounttype = dgvTrophees.Rows[index].Cells[4].Value.ToString();
                    date = dgvTrophees.Rows[index].Cells[5].Value.ToString();
                    tremarks = dgvTrophees.Rows[index].Cells[6].Value.ToString();
                    deposit = double.Parse(dgvTrophees.Rows[index].Cells[7].Value.ToString());
                    discount = dgvTrophees.Rows[index].Cells[8].Value.ToString();
                    total = dgvTrophees.Rows[index].Cells[9].Value.ToString();


                    txtNumber.Text = number;
                    txtAmount.Text = amount;
                    cmbAnimalType.Text = animaltype;
                    cmbMountType.Text = mounttype;
                    richeditRemarks.Text = tremarks;




                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddTrophree_Click(object sender, EventArgs e)
        {
            if (amount == "")
            {
                iamount = 1;
            }
            else
            { 
                iamount = int.Parse(amount);
            }

            if (number == "")
            {
                number = "1";
            }

            int Mount = dh.ReturnMountType(dh.SelectAnimalType(animaltype), dh.SelectMountType(mounttype));
            DiscountCalc = double.Parse(discount);
            totalCalc = double.Parse(total);
            DiscountCalc = totalCalc * (DiscountCalc / 100);
            discount = DiscountCalc.ToString();
            date = dateTimePicker1.Value.ToString(); ;
            dh.UpdateTrophee(number, iamount, tremarks, Mount, date, deposit, DiscountCalc, totalCalc, id);

            dgvTrophees.DataSource = null;
            dgvTrophees.DataSource = dh.ReadEditInvoice(Fid);
            dgvTrophees.DataMember = "tblTrophee";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dh.DeleteTrophee(id);
        }
    }
}
