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
        }
    }
}
