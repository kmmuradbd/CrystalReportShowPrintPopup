<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="WebApplication6.ReportViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function triggerPrint() {
            var iframe = document.createElement('iframe');
            iframe.style.display = 'none'; // Hide the iframe
            iframe.src = 'ReportHandler.aspx'; // This page will serve the PDF content

            document.body.appendChild(iframe);

            iframe.onload = function () {
                iframe.contentWindow.focus(); // Focus the iframe window
                iframe.contentWindow.print(); // Trigger the print dialog
            };
        }
    </script>
</head>
<body onload="triggerPrint()">
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
