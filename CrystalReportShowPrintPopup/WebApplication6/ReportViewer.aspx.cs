using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowReport();
            }
        }

        private void ShowReport()
        {
            ReportDocument report = new ReportDocument();

            // Load the Crystal Report file
            report.Load(Server.MapPath("CrystalReport1.rpt"));

            // Export the report to a PDF stream
            Stream reportStream = report.ExportToStream(ExportFormatType.PortableDocFormat);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                reportStream.CopyTo(memoryStream);

                // Store the PDF in Session or save to a temporary file to access from client-side
                Session["ReportPDF"] = memoryStream.ToArray();  // Store PDF bytes in session
            }

            reportStream.Close();
            report.Close();
            report.Dispose();
        }
    }
}