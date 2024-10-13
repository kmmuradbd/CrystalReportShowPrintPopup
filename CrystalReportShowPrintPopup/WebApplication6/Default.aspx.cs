using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportDocument rptDoc = new ReportDocument();
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con1"].ConnectionString);
                //dt = new DataTable();
                //dt.TableName = "Crystal Report Example";
                //com.Connection = conn;
                //string sql = "SELECT * from Table1 "; // As per condition  
                //com.CommandText = sql;
                //sqlda = new SqlDataAdapter(com);
                //sqlda.Fill(dt);
                //ds.Tables[0].Merge(dt);
                rptDoc.Load(Server.MapPath("CrystalReport1.rpt"));
                // rptDoc.SetDatabaseLogon("Username", "password", @"IPADDRESS\SERVERR2", "DB_DatabaseName");
                // rptDoc.SetDataSource(ds);
                CrystalReportViewer1.ReportSource = rptDoc;
            }

        }
    }
}