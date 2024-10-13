<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <input id="btnPrint" type="button" value="Print" onclick="Print()" />  
<div id="dvReport">  
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ToolPanelView="None" EnableDatabaseLogonPrompt="false" PrintMode="Pdf" />
</div> 

<script type="text/javascript">  
    function Print() {
        var dvReport = document.getElementById("dvReport");
        var frame1 = dvReport.getElementsByTagName("iframe")[0];

        // Check if iframe exists
        if (!frame1) {
            alert("Report not available yet.");
            return;
        }

        // Wait for the iframe to load completely
        frame1.onload = function () {
            if (navigator.appName.indexOf("Internet Explorer") != -1 || navigator.appVersion.indexOf("Trident") != -1) {
                frame1.name = frame1.id;
                window.frames[frame1.id].focus();
                window.frames[frame1.id].print();
            } else {
                var frameDoc = frame1.contentWindow ? frame1.contentWindow : frame1.contentDocument.document ? frame1.contentDocument.document : frame1.contentDocument;
                frameDoc.focus();
                frameDoc.print();
            }
        };
    }
</script>

</asp:Content>
