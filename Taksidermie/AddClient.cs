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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            dh.AddClient(new Client(txtName.Text, txtSurname.Text, txtEmail.Text, txtCell.Text, txtPhone.Text));
            this.Close();

        }
    }
}
