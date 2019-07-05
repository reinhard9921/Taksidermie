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
    public partial class frmAddInventory : Form
    {
        string conString = "Data Source=" + database.server + ";Initial Catalog=" + database.dbName + ";User Id=" + database.username + ";Password=" + database.password + ";";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        public frmAddInventory()
        {
            InitializeComponent();
        }

        DataHandler dh = new DataHandler();
        private void FrmAddInventory_Load(object sender, EventArgs e)
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

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            dh.AddInventory(cmbItem.Text, cmbAnimalType.Text, int.Parse(txtAmountInStock.Text));
            this.Close();
        }
    }
}
