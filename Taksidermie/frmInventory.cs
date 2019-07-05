using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Taksidermie.Classes;

namespace Taksidermie
{

    public partial class frmInventory : Form
    {

        string conString = "Data Source=" + database.server + ";Initial Catalog=" + database.dbName + ";User Id=" + database.username + ";Password=" + database.password + ";";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;


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
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AId, AAnimalType FROM tblAnimal", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbAnimalType.DisplayMember = "AAnimalType";
                cmbAnimalType.ValueMember = "AId";
                cmbAnimalType.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in FIllComboBoxAnimalType  " + ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            string item = cmbItem.Text;
            string Animal = cmbAnimalType.Text;
            int amount = int.Parse(txtAmountInStock.Text);
            dh.UpdateInventroy(item, amount, Animal, id);
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = dh.ReadInventory();
            dgvInventory.DataMember = "tblInvintory";
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            string item = cmbItem.Text;
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
                    string items = dgvInventory.Rows[index].Cells[1].Value.ToString();
                    cmbItem.Text = items;
                    string Animal = dgvInventory.Rows[index].Cells[2].Value.ToString();
                    cmbAnimalType.Text = Animal;
                    int amount = (int)dgvInventory.Rows[index].Cells[3].Value;
                    txtAmountInStock.Text = amount.ToString();




                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }

        private void TxtSearchFaktuur_TextChanged(object sender, EventArgs e)
        {
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = dh.SearchInventory(txtSearchFaktuur.Text);
            dgvInventory.DataMember = "tblInvintory";
        }
    }
}
