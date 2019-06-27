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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = dh.ReadInventory();
            dgvInventory.DataMember = "tblInvintory";
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            int amount = int.Parse(txtAmountInStock.Text);
            dh.UpdateInventroy(item, amount, id);
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = dh.ReadInventory();
            dgvInventory.DataMember = "tblInvintory";
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            int amount = int.Parse(txtAmountInStock.Text);
            dh.Deleteinventroy(id);
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = dh.ReadInventory();
            dgvInventory.DataMember = "tblInvintory";
        }
        int id;
        private void DgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentCell != null)
            {
                try
                {
                    int index = dgvInventory.CurrentCell.RowIndex;

                    id = (int)dgvInventory.Rows[index].Cells[0].Value;

                    string items = dgvInventory.Rows[index].Cells[2].Value.ToString();
                    txtItem.Text = items;
                    int amount = (int)dgvInventory.Rows[index].Cells[3].Value;
                    txtAmountInStock.Text = amount.ToString();




                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }
    }
}
