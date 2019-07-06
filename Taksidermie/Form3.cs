using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace Taksidermie
{
    public partial class Form3 : Form
    {
        int FaktuurNo;
        public Form3(int _faktuurno)
        {
            InitializeComponent();
            FaktuurNo = _faktuurno;

            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            string path = AppDomain.CurrentDomain.BaseDirectory + "FaktuurPrintOut.rpt";
            cryRpt.Load(path);

            cryRpt.SetParameterValue("FId", FaktuurNo.ToString());

            crConnectionInfo.ServerName = database.server;
            crConnectionInfo.DatabaseName = database.dbName;
            crConnectionInfo.UserID = database.username;
            crConnectionInfo.Password = database.password;

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
