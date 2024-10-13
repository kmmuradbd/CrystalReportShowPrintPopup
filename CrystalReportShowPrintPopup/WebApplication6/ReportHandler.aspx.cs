using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class ReportHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ReportPDF"] != null)
            {
                byte[] pdfBytes = (byte[])Session["ReportPDF"];

                // Send the PDF to the client browser
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "inline; filename=Report.pdf");
                Response.BinaryWrite(pdfBytes);
                Response.End();
            }
        }
    }
}