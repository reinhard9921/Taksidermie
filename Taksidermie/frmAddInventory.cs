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
    public partial class frmAddInventory : Form
    {
        public frmAddInventory()
        {
            InitializeComponent();
        }

        private void FrmAddInventory_Load(object sender, EventArgs e)
        {

        }
        DataHandler dh = new DataHandler();
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            dh.AddInventory(txtItem.Text, int.Parse(txtAmountInStock.Text));
        }
    }
}
