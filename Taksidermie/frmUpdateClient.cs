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
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient(int id, string name, string surname, string email, string cell, string cell1)
        {
            InitializeComponent();
            uid = id;
            uname = name;
            usurname = surname;
            uemail = email;
            ucell = cell;
            ucell1 = cell1;
        }
        int uid;
        string uname, usurname, uemail, ucell, ucell1;
        DataHandler dh = new DataHandler();

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            dh.updateClient(uname, usurname, uemail, ucell, ucell1, uid); 
        }

        private void FrmUpdateClient_Load(object sender, EventArgs e)
        {
            txtName.Text = uname;
            txtSurname.Text = usurname;
            txtEmail.Text = uemail;
            txtCell.Text = ucell;
            txtPhone.Text = ucell1;

        }
    }
}
