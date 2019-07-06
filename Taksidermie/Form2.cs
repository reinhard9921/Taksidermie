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
using System.Data;
using Taksidermie.Classes;

namespace Taksidermie
{
    public partial class frmInvoice : Form
    {
        string conString = "Data Source=" + database.server + ";Initial Catalog=" + database.dbName + ";User Id=" + database.username + ";Password=" + database.password + ";";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        public frmInvoice(int invoice)
        {
            InitializeComponent();
            lblInvoice.Text = (invoice).ToString();
            

        }
        DataHandler dh = new DataHandler();
        int ClientID;
        List<Trophee> lstTrophee = new List<Trophee>();
        public delegate void MyHandler();
        public event MyHandler MyEventHandler;
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        int TropheeID;
        private void Form2_Load(object sender, EventArgs e)
        {
            dgvTrophees.DataSource = lstTrophee;
            
            FillCombobox();
            FillComboboxNum1();
            FillComboboxNum2();
            FillComboboxAnimalType();
            FillComboboxMountType();

        }



        double CalculateTotalPrice;
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int invoicenumber = int.Parse(lblInvoice.Text);
                string number = lblInvoice.Text + "-" + txtNumber.Text;
                string remarks = richeditRemarks.Text;
                int AnimalType = dh.SelectAnimalType(cmbAnimalType.Text);
                int MountType = dh.SelectMountType(cmbMountType.Text);
                double TAdiscount = 0;
                TAdiscount = double.Parse(txtDiscount.Text);
                TAdiscount = TAdiscount / 100;
                TAdiscount = dh.ReadTotalPrice(AnimalType, MountType) * TAdiscount;
                double CalculatePrice = dh.ReadTotalPrice(AnimalType, MountType) - TAdiscount;
                double mountType = dh.ReturnMountType(dh.SelectAnimalType(cmbAnimalType.Text), dh.SelectMountType(cmbMountType.Text));
                double deposit = CalculatePrice / 2;
                CalculateTotalPrice = CalculateTotalPrice + dh.ReadTotalPrice(AnimalType, MountType);
                lstTrophee.Add(new Trophee(invoicenumber, number, 1, remarks, cmbAnimalType.Text, cmbMountType.Text, "", CalculatePrice, deposit, TAdiscount));


                dgvTrophees.DataSource = null;
                dgvTrophees.DataSource = lstTrophee;
            }
            catch (Exception d)
            {

                System.Windows.Forms.MessageBox.Show("Add Throphee" + d.Message);
            }

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {

            ClientID = dh.ClientID(cmbNameSurname.Text, cmbCell.Text, cmbPhoneNumber.Text);
            double deposit;

            foreach (Trophee item in lstTrophee)
            {

                double mountType = dh.ReturnMountType(dh.SelectAnimalType(item.Animaltype), dh.SelectMountType(item.Mounttype));

                dh.Insert(item.Invoicenumber, item.Number, item.Amount, item.Remarks, mountType, item.Total, item.Date, item.Deposit, item.Discount);

            }
            int InvoiceNumber = int.Parse(lblInvoice.Text);
            double credit;
            deposit = CalculateTotalPrice / 2;
            double CTotal = dh.GetCredit(ClientID);

            if (CalculateTotalPrice >= CTotal)
            {
                CTotal = CalculateTotalPrice - CTotal;

            }
            else
            {
                credit = CTotal;
                credit = CTotal - CalculateTotalPrice;
                CTotal = 0;

                dh.UpdateCredit(credit, ClientID);

            }
            dh.InsertFaktuur(InvoiceNumber, ClientID, CalculateTotalPrice, CTotal, deposit, txtClientNumber.Text, txtClientName.Text, cmbHandler.Text);
            this.Close();
            MyEventHandler?.Invoke();

        }

        private void CmbMountType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbNameSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbCell_SelectedIndexChanged(object sender, EventArgs e)
        {

          //  ClientID = dh.GetClientName(cmbNameSurname.Text, cmbCell.Text, cmbPhoneNumber.Text);
        }

        private void CmbPhoneNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

         //   ClientID = dh.GetClientName(cmbNameSurname.Text, cmbCell.Text, cmbPhoneNumber.Text);
        }

        protected void FillCombobox()
        {
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CId, CName + ' ' + CSurname as 'FullName' FROM tblClient", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbNameSurname.DisplayMember = "FullName";
                cmbNameSurname.ValueMember = "CId";
                cmbNameSurname.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in FIllComboBox");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        protected void FillComboboxNum1()
        {
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CId, CCell FROM tblClient", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbPhoneNumber.DisplayMember = "CCell";
                cmbPhoneNumber.ValueMember = "CId";
                cmbPhoneNumber.DataSource = ds.Tables[0];
            }
            catch (Exception r)
            {
                MessageBox.Show("Error in FIllComboBoxNum1");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        protected void FillComboboxNum2()
        {
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CId, CCell1 FROM tblClient", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmbCell.DisplayMember = "CCell1";
                cmbCell.ValueMember = "CId";
                cmbCell.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in FIllComboBoxNum2");
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
                MessageBox.Show("Error in FIllComboBoxMountType");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
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

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
