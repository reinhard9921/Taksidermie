using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Taksidermie.Classes;

namespace Taksidermie
{
    class DataHandler
    {
        string conString = "Data Source=" + database.server + ";Initial Catalog=" + database.dbName + ";User Id=" + database.username + ";Password=" + database.password + ";";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;



        public int ReadInvoiceNumber()
        {
            int i = 0;

            try
            {
                conn = new SqlConnection(conString);
                conn.Open();
                string select = "SELECT TOP 1 FId FROM tblFaktuur ORDER BY FId DESC";
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ReadInvoiceNumber()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }
        public int ReadTropheeID()
        {
            int i = 0;

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT TId FROM  tblTrophee";

                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = cmd1.ExecuteNonQuery();



            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadThrophee()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }

        public int GetClientName(string Name, string num1, string num2)
        {
            int i = 0;

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT CId FROM tblClient WHERE CName LIKE  %" + Name + "% OR CCell = " + num1 + " OR CCell1 = " + num2;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = cmd1.ExecuteNonQuery();



            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("GetClientName()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }
        public int SelectAnimalType(string Animal)
        {
            int i = 1;

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT AId FROM  tblAnimal WHERE AAnimalType = '" + Animal + "'";
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();



            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SelectAnimalType()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }
        public int SelectMountType(string Mount)
        {
            int i = 1;

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT TId FROM  tblMountType WHERE TMountType = '" + Mount + "'";
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();



            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SelectMountType()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }
        public double ReadTotalPrice(int Animal, int mount)
        {
            double i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT Mamount FROM  tblMounts WHERE AId = " + Animal + " AND TId = " + mount;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (double)(decimal)cmd1.ExecuteScalar();
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadTotalPrice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;


        }
        public string ReadCorrectInvoice(int FId)
        {
            string i = "0";
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT FStatusReport FROM  tblFaktuur WHERE FId = " + FId;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                if (cmd1.ExecuteScalar() == null)
                {
                    i = "False";

                }
                else
                {
                    i = "True";
                }


            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadCorrectINvoice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return i;

        }
        public string ReadStatusReport(int FId)
        {
            string i = "0";
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT FStatusReport FROM  tblFaktuur WHERE FId = " + FId;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = cmd1.ExecuteScalar().ToString();

                if (i == "Waiting For Deposit")
                {
                    i = "True";

                }
                else
                {
                    i = "False";
                }


            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadCorrectINvoice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return i;

        }
        public int ReturnMountType(int Animal, int mount)
        {
            int i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT MId FROM  tblMounts WHERE AId = " + Animal + " AND TId = " + mount;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadTotalPrice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;


        }
        public double GetCredit(int clientID)
        {
            double i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT CCredit FROM  tblClient WHERE CID = " + clientID;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (double)(decimal)cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("GetCredit()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;


        }
        public void UpdateCredit(double Credit, int CID)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblClient SET CCredit = " + Credit + " WHERE CId = " + CID;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateCredit()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public void Insert(int invoicenumber, string number, int amount, string remarks, double tropheemount, double total, string date, double deposit, double discount)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();
                /////asdfagfsgvrdfhcdfcgdvsdgvxc
                string select = "INSERT INTO tblTrophee(FId, TNumber, TAmount, TRemarks, TMountType, TVellDate, TTotal, TDeposit, TDiscount)" +
                    " VALUES(" + invoicenumber + ",'" + number + "'," + amount + ",'" + remarks + "'," + tropheemount + ",'" + date + "'," + total + "," + deposit + "," + discount + ")";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblTrophee");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("Insert()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public void CreateFaktuur()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();
                string select = "INSERT INTO tblFaktuur(CID) " +
                    "VALUES(6)";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("CreateFaktuur()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }


        public void DeleteInvoice(int FID)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();
                string select = "DELETE FROM tblFaktuur WHERE FId = " + FID;
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteInvoice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void DeleteTrophee(int TId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();
                string select = "DELETE FROM tbltrophee WHERE TId = " + TId;
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteInvoice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void InsertFaktuur(int FId, int CID, double Total, double CTotal, double Deposit, string DroppedOffNumber, string droppedOffClient, string employee)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET CId = " + CID + " , CidDropoff = '" + droppedOffClient +
                    "' , FStatusReport = 'Waiting For Deposit' " +
                    " , FActive = 0, FTotal = " + Total + " , CIDroppedOffNumber = '" + DroppedOffNumber +
                    "' , FDeposit = " + Deposit + " , FOustanding = " + CTotal + " , Employee = '" + employee + "' WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("InsertFaktuur()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void CalculateOutstanding(int FId, double Amount, int deposit)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET FOustanding = " + Amount + ", FActive = " + deposit + " WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("CalculateOUtstanding()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public double GetOutstanding(int FId)
        {
            double i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT FOustanding FROM  tblFaktuur WHERE FId = " + FId;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (double)(decimal)cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("GetOutstanding()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return i;

        }
        public void MakePayment(DateTime date, int FId, string PaymentType, double Money)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "INSERT INTO tblPayment(FId, PAmount, PPaymentType, PDate)" +
                    "VALUES(" + FId + "," + Money + ",'" + PaymentType + "','" + date + "')";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblPayment");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("MakePayment()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void RunInvoiceUpdate(string name, string pname, string pnumber, string DNumber, string pDate, string statusReport, string active, string sms, int FId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET CIdDropoff = '" + name + "', CIdPickup = '" + pname + "', DatePickedUp = '" + pDate + "'," +
                    " CIdPickedUpNumber = '" + pnumber + "', CIDroppedOffNumber = '" + DNumber + "', FStatusReport = '" + statusReport + "'," +
                    " FActive = '" + active + "', FSms = '" + sms + "' WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("RunInvoiceUpdate()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void UpdateStatus(int FId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET FStatusReport = 'Starting' WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateStatusReport()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public void UpdateCompleted(int FId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET Completed = 'True' WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateStatusReport()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public void UpdateConceled(int FId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET Canceled = 'True' WHERE FId = " + FId;

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateStatusReport()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }
        public DataSet ReadFaktuur()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "Select f.FId AS 'Faktuur ID', c.CName + ' ' + c.CSurname AS 'Client Name', f.CIdDropoff AS 'Client Dropped off'," +
                    " f.CIDroppedOffNumber as 'Dropped off number'" +
                    ", f.CIdPickup AS 'Client Picked Up', f.CIdPickedUpNumber as 'Picked Up Number', f.DatePickedUp  as 'Date Picked Up', f.FStatusReport AS 'Status Report'" +
                    ", f.FActive AS 'Active', f.FTotal AS 'Total', f.FDeposit AS 'Deposit Payable', f.FOustanding AS 'Outstanding Amount', f.FSms AS 'SMS', f.Employee AS 'Handler' " +
                    "FROM tblFaktuur f INNER JOIN tblClient c ON f.CId = c.CId WHERE f.Completed is null AND f.Canceled is null ORDER BY FId DESC";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("READFAKTUUR()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadEditInvoice(int id)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT t.TId, t.TNumber, t.TAmount, a.AAnimalType, mt.TMountType, t.TVellDate, " +
                    "t.TRemarks, t.TDeposit, t.TDiscount, t.TTotal " +
                    "FROM tblTrophee t " +
                    "INNER JOIN tblMounts m " +
                    "ON t.TMountType = m.MId " +
                    "INNER JOIN tblMountType mt " +
                    "ON m.TId = mt.TId " +
                    "INNER JOIN tblAnimal a " +
                    "ON m.AId = a.AId WHERE t.FId = " + id;
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblTrophee");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadEditInvoice()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }

        public DataSet SearchFaktuur(string Search)
        {
            dataSet = null;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "Select f.FId AS 'Faktuur ID', c.CName + ' ' + c.CSurname AS 'Client Name', c.CCell AS 'Cell Number' ,f.CIdDropoff AS 'Client Dropped off'," +
                    " f.CIDroppedOffNumber as 'Dropped off number'" +
                    ", f.CIdPickup AS 'Client Picked Up', f.CIdPickedUpNumber as 'Picked Up Number', f.DatePickedUp  as 'Date Picked Up', f.FStatusReport AS 'Status Report'" +
                    ", f.FActive AS 'Active', f.FTotal AS 'Total', f.FDeposit AS 'Deposit Payable', f.FOustanding AS 'Outstanding Amount', f.FSms AS 'SMS' " +
                    "FROM tblFaktuur f INNER JOIN tblClient c ON f.CId = c.CId WHERE f.FId LIKE '%" + Search + "%' AND f.Completed is null AND" +
                    " f.Canceled is null or c.CName LIKE '%" + Search + "%' AND f.Completed is null AND f.Canceled is null " +
                    "or f.CIdPickUp LIKE '%" + Search + "%' AND f.Completed is null AND f.Canceled is null" +
                    " or f.CIdDropoff LIKE '%" + Search + "%' AND f.Completed is null AND f.Canceled is null " +
                    "or f.FStatusReport LIKE '%" + Search + "%' AND f.Completed is null AND f.Canceled is null" +
                    " or f.FActive LIKE ' % " + Search + " AND f.Completed is null AND f.Canceled is null %" +
                    "' or f.FTotal LIKE '%" + Search + "%' AND f.Completed is null AND f.Canceled is null" +
                    "  or f.FDeposit LIKE '% " + Search + " AND f.Completed is null AND f.Canceled is null" +
                    " %'or f.FOustanding LIKE '% " + Search + " %' AND f.Completed is null AND f.Canceled is null " +
                    "or f.CIdPickedUpNumber LIKE '% " + Search + " %' AND f.Completed is null AND f.Canceled is null" +
                    " or f.DatePickedUp LIKE '% " + Search + " %' AND f.Completed is null AND f.Canceled is null" +
                    " or f.CIDroppedOffNumber LIKE '% " + Search + " %' AND f.Completed is null AND f.Canceled is null " +
                    "or c.CCell LIKE '% " + Search + " %' AND f.Completed is null AND f.Canceled is null ";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SearchFaktuur" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;

        }

        public DataSet SearchClient(string Search)
        {
            dataSet = null;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblClient WHERE CId LIKE '%" + Search + "%' or CName LIKE '%" + Search + "%' " +
                    "or CSurname LIKE '%" + Search + "%' or CEmailAddress LIKE '%" + Search + "%' or CCell LIKE '%" + Search + "%' " +
                    "or CCell1 LIKE '%" + Search + "%' or CCredit LIKE '%" + Search + "%' ";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblClient");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SearchClient" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;

        }
        public DataSet SearchInventory(string Search)
        {
            dataSet = null;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblInvintory WHERE IId LIKE '%" + Search + "%' or IItem LIKE '%" + Search + "%' " +
                    "or IAnimalType LIKE '%" + Search + "%' or IAmount LIKE '%" + Search + "%'";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblInvintory");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SearchClient" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;

        }
        public DataSet SearchPayment(string Search)
        {
            dataSet = null;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblPayment WHERE FId LIKE '%" + Search + "%' or PAmount LIKE '%" + Search + "%' " +
                    "or PPaymentType LIKE '%" + Search + "%' or PDate LIKE '%" + Search + "%'";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblPayment");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("SearchClient" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;

        }
        public void AddClient(Client NewClient)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblClient (CName, CSurname, CEmailAddress, CCell, CCell1)" +
                    " VALUES('" + NewClient.Name + "','" + NewClient.Surname + "','" + NewClient.Email + "','" + NewClient.Cell + "','" + NewClient.Phone + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("AddClient " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public void AddAnimalType(string type)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblAnimal (AAnimalType)" +
                    " VALUES('" + type + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("AddAnimalType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateAnimalType(string type, int AId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblAnimal SET AAnimalType = " +
                    "'" + type + "' WHERE AId = " + AId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateAnimalType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateTrophee(string TNumber, int TAmount, string TRemarks, int MountType, string date, double TDeposit, double TDiscount, double TTotal, int TId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblTrophee " +
                    "SET TNumber = " + TNumber +
                    ", TAmount = " + TAmount +
                    ", TRemarks = '" + TRemarks + "'" +
                    ", TMountType = " + MountType +
                    ", TVellDate = '" + date + "'" +
                    ", TDeposit = " + TDeposit +
                    ", TDiscount = " + TDiscount +
                    ", TTotal = " + TTotal +
                    "WHERE TId = " + TId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("update trophee " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DeleteAnimalType(int AId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "DELETE FROM tblAnimal WHERE AId =" + AId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteAnimalType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void AddMount(int Aid, int TId, double MAmount)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblMounts (AId, TId, MAmount)" +
                    " VALUES(" + Aid + "," + TId + "," + MAmount + ")";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("AddMount " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateMount(double price, int AId, int TId, int MId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblMounts SET AId = " + AId + ", TId = " + TId + ", MAmount = " + price + " WHERE MId = " + MId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateMount " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DeleteMount(int MId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "DELETE FROM tblMounts WHERE MId =" + MId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteMount " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void AddMountType(string type)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblMountType (TMountType)" +
                    " VALUES('" + type + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("AddMountType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateMountType(string type, int TId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblMountType SET TMountType = " +
                    "'" + type + "' WHERE TId = " + TId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateMountType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DeleteMountType(int TId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "DELETE FROM tblMountType WHERE TId =" + TId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteMountType " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void AddInventory(string Item, string aType, int Amount, int faktuur)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblInvintory (IItem, IAnimalType, IAmount, IFaktuurNR)" +
                    " VALUES('" + Item + "', '" + aType + "', '" + faktuur + "', " + Amount + ")";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("addInventory " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateInventroy(string item, int Amount, string Animal, int IId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblINvintory SET IItem = '" + item + "', IAmount = " + Amount + ", IAnimalType = '" + Animal + "' WHERE IId = " + IId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("UpdateInventory " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void Deleteinventroy(int IId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "DELETE FROM tblInvintory WHERE IId =" + IId;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteInventroy " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public void AddClient(string CName, string CSurname, string CEmailAddress, string CCell, string CCell1)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblClient (CName, CSurname, CEmailAddress, CCell, CCell1)" +
                    " VALUES('" + CName + "', " + CSurname + "', " + CEmailAddress + "', " + CCell + "', " + CCell1 + ")";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("addclient " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void updateClient(string CName, string CSurname, string CEmailAddress, string CCell, string CCell1, int id)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE SET CName = '" + CName + "',CSurname = " + CSurname + "',CEmailAddress = " + CEmailAddress + "'," +
                    " CCell = " + CCell + "',CCell1 = " + CCell1 + " WHERE CId = " + id;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("updateClient " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DeleteClient(int ID)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "DELETE FROM tblClient WHERE CId =" + ID;
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DeleteClient " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public DataSet ReadAnimalType()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblAnimal";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblAnimal");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadAnimalType()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadPaymentHistory()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT FId as 'Faktuur ID', PAmount as 'Amount', PPaymentType as 'Payment Type', PDate as 'Date' FROM tblPayment";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblPayment");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadAnimalType()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadMountType()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblMountType";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblMountType");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadMountType()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadMounts()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT m.MId AS 'Mount ID',  a.AAnimalType  AS 'Animal Type', mt.TMountType AS 'Mount Type' , m.MAmount AS 'Amount' " +
                    "FROM tblMounts m " +
                    "INNER JOIN tblMountType mt" +
                    " ON m.TId = mt.TId " +
                    "INNER JOIN tblAnimal a " +
                    "ON m.AId = a.AId";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblMounts");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadMounts()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadClient()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblClient";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblClient");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadClient()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public DataSet ReadInventory()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT * FROM tblInvintory";
                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblInvintory");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ReadInvintory()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dataSet;
        }
        public int ClientID(string name, string cell, string cell1)
        {
            int i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT CId FROM  tblCLient WHERE CName + ' ' + CSurname = '" + name + "' OR CCell = '" + cell + "' OR CCell1 = '" + cell1 + "'";
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("ClientID()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }
        public int CIDFID(int FID)
        {
            int i = 0;
            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "SELECT CId FROM  tblFaktuur WHERE FId = " + FID;
                SqlCommand cmd1 = new SqlCommand(select, conn);
                i = (int)cmd1.ExecuteScalar();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("CIDFID()" + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return i;
        }

    }
}
