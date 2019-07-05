using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taksidermie.Classes;
using IniParser;
using IniParser.Model;

namespace Taksidermie
{
    public partial class frmMainScreen : Form
    {
        DataHandler dh;
        BindingSource bis;
        public frmMainScreen()
        {
            InitializeComponent();

            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("db.ini");

            database.server = data.GetKey("host");
            database.dbName = data.GetKey("name");
            database.username = data.GetKey("user");
            database.password = data.GetKey("pass");

            dh = new DataHandler();
            bis = new BindingSource();
        }
       
        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtClientDropoffNumber.Text = "";
            txtPickedUpNumber.Text = "";
            txtSms.Text = "";
            dgvMounts.DataSource = dh.ReadFaktuur();
            dgvMounts.DataMember = "tblFaktuur";
            InvoiceNumberPass = dh.ReadInvoiceNumber();
        }


        public void update()
        {
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadFaktuur();
            dgvMounts.DataMember = "tblFaktuur";

        }

        private void TxtSearchFaktuur_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFaktuur.Text == "")
            {
                update();
            }
            else
            {
                dgvMounts.DataSource = null;
                dgvMounts.DataSource = dh.SearchFaktuur(txtSearchFaktuur.Text);
                dgvMounts.DataMember = "tblFaktuur";
            }
        }

        private void YearlyIncreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void AddMountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageClients ManageClient = new frmManageClients();
            ManageClient.Show();
        }
        int InvoiceNumberPass;
        private void BtnNewInvoice_Click(object sender, EventArgs e)
        {

            InvoiceNumberPass = dh.ReadInvoiceNumber();
            string status = dh.ReadCorrectInvoice(InvoiceNumberPass);

            if (status == "False")
            {
                dh.DeleteInvoice(InvoiceNumberPass);
                dh.CreateFaktuur();
                InvoiceNumberPass = dh.ReadInvoiceNumber();
            }
            else
            {
                dh.CreateFaktuur();
                InvoiceNumberPass = dh.ReadInvoiceNumber();
            }

            frmInvoice invoice = new frmInvoice(InvoiceNumberPass);
            invoice.MyEventHandler += Frm2_MyEventHandler; ;
            invoice.Show();


        }

        private void Frm2_MyEventHandler()
        {
            FileBrowser();
        }

        private void Frm2_MySecondEventHandler()
        {
            string CheckStatus = dh.ReadStatusReport(id);
            if (CheckStatus == "True")
            {
                dh.UpdateStatus(id);
            }

        }

        public void FileBrowser()
        {

            update();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLists list = new frmLists();
            list.Show();

        }

        private void PriceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPricelist plist = new frmPricelist();
            plist.Show();

        }

        private void InvetoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory invent = new frmInventory();
            invent.Show();

        }

        private void AddToInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInventory addinv = new frmAddInventory();
            addinv.Show();
        }

        public int testing;

        public void RefreshGrid()
        {

            testing = 1;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void TmrUpdateDgv_Tick(object sender, EventArgs e)
        {



        }

        private void dgvMounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id;
        private void dgvMounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMounts.CurrentCell != null)
            {
                try
                {
                    int index = dgvMounts.CurrentCell.RowIndex;

                    id = (int)dgvMounts.Rows[index].Cells[0].Value;

                   string cname = dgvMounts.Rows[index].Cells[2].Value.ToString();
                    txtClientDropoff.Text = cname;
                    string DOnumer = dgvMounts.Rows[index].Cells[3].Value.ToString();
                    txtClientDropoffNumber.Text = DOnumer;
                    string cpName = dgvMounts.Rows[index].Cells[4].Value.ToString();
                    txtClientPickUp.Text = cpName;
                    string puNumber = dgvMounts.Rows[index].Cells[5].Value.ToString();
                    txtPickedUpNumber.Text = puNumber;
                    string dPickedUp = dgvMounts.Rows[index].Cells[6].Value.ToString();
                    dtpPDate.Text = dPickedUp;
                    string Status = dgvMounts.Rows[index].Cells[7].Value.ToString();
                    richtxtStatus.Text = Status;
                    string Active = dgvMounts.Rows[index].Cells[8].Value.ToString();
                    if (Active == "False")
                    {
                        chbActive.Checked = false;

                    }
                    else
                    {
                        chbActive.Checked = true;
                    }
                    string sms = dgvMounts.Rows[index].Cells[12].Value.ToString();
                    txtSms.Text = sms;
      

                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
           



        }

        private void BtnUpdateInvoice_Click(object sender, EventArgs e)
        {
            int active;
            string cname = txtClientDropoff.Text;
            string cpName = txtClientPickUp.Text;
            string Status = richtxtStatus.Text ;
            string cpNumber = txtPickedUpNumber.Text;
            string DNumber = txtClientDropoffNumber.Text;
            string pDate = dtpPDate.Value.ToString();
            if  (chbActive.Checked == true)
            {
                active = 1;

            }
            else
            {
                active = 0;
            }
            string sms = txtSms.Text;
            dh.RunInvoiceUpdate(cname, cpName, cpNumber, DNumber, pDate, Status, active.ToString(), sms, id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadFaktuur();
            dgvMounts.DataMember = "tblFaktuur";
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (chbActive.Checked)
            {
               i  = 1;
            }
            frmPayment frmpay = new frmPayment(id, i);
            frmpay.MyEventHandler += Frm2_MyEventHandler; 
            frmpay.MySecondEventHandler += Frm2_MySecondEventHandler;
            frmpay.Show();




        }


        private void DgvMounts_DoubleClick(object sender, EventArgs e)
        {


        }

        private void DgvMounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditInvoice frmedit = new frmEditInvoice(id);
            frmedit.Show();
        }

        private void PaymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentHistory ph = new PaymentHistory();
            ph.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dh.UpdateConceled(id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadFaktuur();
            dgvMounts.DataMember = "tblFaktuur";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dh.UpdateCompleted(id);
            dgvMounts.DataSource = null;
            dgvMounts.DataSource = dh.ReadFaktuur();
            dgvMounts.DataMember = "tblFaktuur";
        }
    }
}
