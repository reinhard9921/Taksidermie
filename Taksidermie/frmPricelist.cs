using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taksidermie.Classes;

namespace Taksidermie
{
    public partial class frmPricelist : Form
    {

        string conString = "Data Source=" + database.server + ";Initial Catalog=" + database.dbName + ";User Id=" + database.username + ";Password=" + database.password + ";";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        public frmPricelist()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataHandler dh = new DataHandler();
        private void FrmPricelist_Load(object sender, EventArgs e)
        {

            FillComboboxMountType();

            FillComboboxAnimalType();

            dgvMounts.DataSource = dh.ReadMounts();
            dgvMounts.DataMember = "tblMounts";
        }

        protected void FillComboboxAnimalType()
        {
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
        protected void FillComboboxMountType()
        {
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TId, TMountType FROM tblMountType", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbMountType.DisplayMember = "TMountType";
                cmbMountType.ValueMember = "TId";
                cmbMountType.DataSource = ds.Tables[0];
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
        int id;
        private void DgvMounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMounts.CurrentCell != null)
            {
                try
                {
                    int index = dgvMounts.CurrentCell.RowIndex;

                    id = (int)dgvMounts.Rows[index].Cells[0].Value;

                    string animalType = dgvMounts.Rows[index].Cells[1].Value.ToString();
                    cmbAnimalType.Text = animalType;
                    string MountType = dgvMounts.Rows[index].Cells[2].Value.ToString();
                    cmbMountType.Text = MountType;
                    double Amount = (double)(decimal)dgvMounts.Rows[index].Cells[3].Value;
                    txtPrice.Text = Amount.ToString();
                    



                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            int AId = dh.SelectAnimalType(cmbAnimalType.Text);
            int TId = dh.SelectMountType(cmbMountType.Text);
            double MAmount = double.Parse(txtPrice.Text);
            dh.AddMount(AId,TId, MAmount);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadMounts();
            dgvMounts.DataMember = "tblMounts";

        }

        private void BtnUpdateAnimal_Click(object sender, EventArgs e)
        {
            int AId = dh.SelectAnimalType(cmbAnimalType.Text);
            int TId = dh.SelectMountType(cmbMountType.Text);
            double MAmount = double.Parse(txtPrice.Text);
            dh.UpdateMount(MAmount ,AId, TId, id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadMounts();
            dgvMounts.DataMember = "tblMounts";

        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            dh.DeleteMount(id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadMounts();
            dgvMounts.DataMember = "tblMounts";

        }
    }
}
