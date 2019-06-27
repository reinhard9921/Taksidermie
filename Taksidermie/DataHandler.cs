﻿using System;
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

                string select = "SELECT MAmount FROM  tblMounts WHERE AId = " + Animal + " AND TId = " + mount;
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

        public void Insert(int invoicenumber, string number, int amount, string remarks, double tropheemount, double total, double deposit, double discount)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();
                /////asdfagfsgvrdfhcdfcgdvsdgvxc
                string select = "INSERT INTO tblTrophee(FId, TNumber, TAmount, TRemarks, TMountType, TTotal, TDeposit, TDiscount)" +
                    " VALUES(" + invoicenumber + ",'" + number + "'," + amount + ",'" + remarks + "'," + total + "," + tropheemount + "," + deposit + "," + discount + ")";
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
                    "VALUES(1)";
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
        public void InsertFaktuur(int FId, int CID, double Total, double CTotal, double Deposit)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET CId = " + CID + ", CidDropoff = (SELECT CName FROM tblClient WHERE CId = " + CID + "), FStatusReport = 'Waiting For Deposit'" +
                    ", FActive = 0, FTotal = " + Total + ", " +
                    "FDeposit = " + Deposit + ", FOustanding = " + CTotal + " WHERE FId = " + FId;

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
        public void MakePayment(DateTime date, int FId, double Money)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "INSERT INTO tblPayment(FId, PAmount, PDate)" +
                    "VALUES(" + FId + "," + Money + ",'" + date + "')";

                adapter = new SqlDataAdapter(select, conn);

                adapter.Fill(dataSet, "tblFaktuur");

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
        public void RunInvoiceUpdate(string name, string pname, string statusReport, string active, string sms, int FId)
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "UPDATE tblFaktuur SET CIdDropoff = '" + name + "', CIdPickup = '" + pname + "', FStatusReport = '" + statusReport + "'," +
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
        public DataSet ReadFaktuur()
        {

            try
            {
                dataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string select = "Select f.FId AS 'Faktuur ID', c.CName AS 'Client Name', f.CIdDropoff AS 'Client Dropped off'" +
                    ", f.CIdPickup AS 'Client Picked Up',  f.FStatusReport AS 'Status Report'" +
                    ", f.FActive AS 'Active', f.FTotal AS 'Total', f.FDeposit AS 'Deposit', f.FOustanding AS 'Outstanding Amount', f.FSms AS 'SMS' " +
                    "FROM tblFaktuur f INNER JOIN tblClient c ON f.CId = c.CId ORDER BY FId DESC";
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

                string select = "SELECT a.AAnimalType, mt.TMountType " +
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

                string select = "SELECT * FROM tblFaktuur WHERE FId LIKE '%" + Search + "%' or CId LIKE '%" + Search + "%' " +
                    "or FNumber LIKE '%" + Search + "%' or TId LIKE '%" + Search + "%' or CIdPickup LIKE '%" + Search + "%' " +
                    "or CidDropoff LIKE '%" + Search + "%' or PPamentID LIKE '%" + Search + "%' ";

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
        public void AddInventory(string Item, int Amount)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "INSERT INTO tblInvintory (IItem, IAmount)" +
                    " VALUES('" + Item + "', " + Amount + ")";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("AddINventroy " + e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateInventroy(string item, int Amount, int IId)
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();


                string insert = "UPDATE tblINvintory SET IItem = '" + item + "', IAmount = " + Amount + " WHERE IId = " + IId;
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

                string select = "SELECT m.MId, a.AAnimalType , mt.TMountType , m.MAmount " +
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

                adapter.Fill(dataSet, "tblAnimal");

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

                string select = "SELECT CId FROM  tblCLient WHERE CName = '" + name + "' OR CCell = '" + cell + "' OR CCell1 = '" + cell1 + "'";
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