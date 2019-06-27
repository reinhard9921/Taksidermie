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
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        private void BtnClientUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateClient UpdateClient = new frmUpdateClient(id, name, surname, email, cell, cell1);
            UpdateClient.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataHandler dh = new DataHandler();
        private void FrmManageClients_Load(object sender, EventArgs e)
        {

            dgvMounts.DataSource = dh.ReadClient();
            dgvMounts.DataMember = "tblClient";
        }

        private void BtnClientDelete_Click(object sender, EventArgs e)
        {
            dh.DeleteClient(id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadClient();
            dgvMounts.DataMember = "tblClient";
        }
        int id;
        string name, surname, email, cell, cell1;

        private void DgvMounts_SelectionChanged(object sender, EventArgs e)
        {
            {
                if (dgvMounts.CurrentCell != null)
                {
                    try
                    {
                        int index = dgvMounts.CurrentCell.RowIndex;

                        id = (int)dgvMounts.Rows[index].Cells[0].Value;

                        name = dgvMounts.Rows[index].Cells[1].Value.ToString();
                        surname = dgvMounts.Rows[index].Cells[2].Value.ToString();
                        email = dgvMounts.Rows[index].Cells[3].Value.ToString();
                        cell = dgvMounts.Rows[index].Cells[4].Value.ToString();
                        cell1 = dgvMounts.Rows[index].Cells[5].Value.ToString();





                    }
                    catch (Exception r)
                    {

                        MessageBox.Show("Selection Change " + r);
                    }
                }
            }
        }
    }
}
