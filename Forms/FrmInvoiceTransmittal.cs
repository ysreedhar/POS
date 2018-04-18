using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POCS.Ds;

namespace POCS
{
    public partial class FrmInvoiceTransmittal : Form
    {
        private StringBuilder htmlContent;
        private string newline;
        public FrmInvoiceTransmittal()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            WriteHTML();
            report.SaveReport(Application.StartupPath + "\\report.html", htmlContent);
            webBrowser1.Navigate(Application.StartupPath +  "\\report.html");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //webBrowser1.Print();
            webBrowser1.ShowPrintDialog();
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
        private void WriteHTML()
        {
            htmlContent = new StringBuilder();
            newline = "\n";
            htmlContent.Append("<HTML>" + newline);
            htmlContent.Append(" <head" + newline);
            htmlContent.Append(" <Style" + newline);
            htmlContent.Append("    .BODY {FONT-FAMILY: Tahoma; FONT-SIZE: 8pt;}" + newline);
            htmlContent.Append("    .TableFont" + newline);
            htmlContent.Append("    {" + newline);
            htmlContent.Append("        COLOR: Black;" + newline);
            htmlContent.Append("        FONT-FAMILY: Tahoma;" + newline);
            htmlContent.Append("        FONT-SIZE: 8pt;" + newline);
            htmlContent.Append("        TEXT-TRANSFORM: capitalize;" + newline);
            htmlContent.Append("    }" + newline);
            htmlContent.Append("    .TrFont" + newline);
            htmlContent.Append("    {" + newline);
            htmlContent.Append("        COLOR: black;" + newline);
            htmlContent.Append("        FONT-FAMILY: Tahoma;" + newline);
            htmlContent.Append("        FONT-SIZE: 8pt;" + newline);
            htmlContent.Append("        TEXT-TRANSFORM: capitalize;" + newline);
            htmlContent.Append("        CURSOR:HAND;" + newline);
            htmlContent.Append("   }" + newline);
            htmlContent.Append("</style></head" + newline);
            htmlContent.Append(" <body class=TableFont" + newline);
            htmlContent.Append(" <table border=0 cellspacing=1 cellpadding=2 BORDERCOLOR=GRAY width=95%" + newline);
            htmlContent.Append("  <tr bgcolor=white  height=15" + newline);
            htmlContent.Append("   <td  colspan=2 align=center valign=top " + newline);
            htmlContent.Append("<FONT size=4> " + "RS!CompanyName" + "</font><FONT size=2> - [" + "RS!regno" + "] </FONT>" + newline);
            htmlContent.Append("   </td>" + newline);
            htmlContent.Append("  </tr>" + newline);
            htmlContent.Append("  <tr>" + newline);
            htmlContent.Append("   <td align=center colspan=2>Vendor Invoice  Transmittal Form" + newline);
            htmlContent.Append("   </td> </tr>" + newline);
            htmlContent.Append("   <tr><td colspan=2><hr></td></tr>" + newline);
            htmlContent.Append(" <tr><td>To: </br>" + "UCase(txtTransmitToName.Text)" + " </br> " + "UCase(txtTransmitToDept.Text)" + "</td>" + newline);
            htmlContent.Append("   <td valign='top'>   Transmittal No.:" + " intTransmittalNumber, 0000000)" + "   </td></tr>" + newline);
            htmlContent.Append(" <tr><td valign=top>From:</br>" + "UCase(pubUserName)" + " </br>" + "UCase(pubUserDept)" + " </td>" + newline);
            htmlContent.Append("   <td  valign=top>Date: " + " Date, 'dd/MM/yyyy')" + " </td></tr>" + newline);
            htmlContent.Append("   <tr><td colspan=2><hr></td></tr>" + newline);
            htmlContent.Append("  <tr>  <td colspan=2 valign=top >Please receive the following Vendor Invoices:</br></td></tr>" + newline);
            htmlContent.Append("  <tr><td  colspan=2 valign=top" + newline);
            htmlContent.Append("   <table border=1 cellspacing=1 cellpadding=2" + newline);
            htmlContent.Append("    <tr><td align='center' nowrap >Sno.</td>" + newline);
            htmlContent.Append("     <td align='center' nowrap>Vendor</td>" + newline);
            htmlContent.Append("     <td align='center' nowrap>Invoice No.</td>" + newline);
            htmlContent.Append("    <td width=100 align='center' nowrap>Value</td>" + newline);
            htmlContent.Append(" <td align='center' nowrap>Currency</td>" + newline);
            htmlContent.Append("     <td align='center' nowrap >Inv. Date</td>" + newline);
            htmlContent.Append("     <td align='center' nowrap>Receipt Date</td>" + newline);
            htmlContent.Append("    <td align='center' nowrap >PO / SO #</td></tr>" + newline);
            htmlContent.Append("    <tr class='trfont'><td>" + newline);
            htmlContent.Append("     " + "Sno" + "</td>" + newline);
            htmlContent.Append("     <td nowrap>" + "vendorName" + "</td>" + newline);
            htmlContent.Append("     <td>" + "InvoiceNumber" + "</td>" + newline);
            htmlContent.Append("    <td align = 'right'>" + "Invoice_Value" + "</td>" + newline);
            htmlContent.Append(" <td>" + "Currency" + "</td>" + newline);
            htmlContent.Append("     <td>" + "InvoiceDate" + "</td>" + newline);
            htmlContent.Append("     <td>" + "ReceiptDate" + "</td>" + newline);
            htmlContent.Append("    <td valign=top>" + "PO_oRDERNO" + "</td></tr>" + newline);
            htmlContent.Append("     </table>" + newline);
            htmlContent.Append("     </td> </tr> " + newline);
            htmlContent.Append("   <tr><td colspan=2><hr></td></tr>" + newline);
            htmlContent.Append("    <tr><td>Received By:</br>NAME:</br" + newline);
            htmlContent.Append("  DEPARTMENT:</td>" + newline);
            htmlContent.Append("  <td>Signature:</td></tr>" + newline);
            htmlContent.Append(" <tr><td colspan=2>Received Date:</td></tr>" + newline);
            htmlContent.Append("</table" + newline);
            htmlContent.Append("</body" + newline);
            htmlContent.Append("</html" + newline);
        }

        private void FrmInvoiceTransmittal_Load(object sender, EventArgs e)
        {
            LoadInvoiceNumbers();
        }
        void LoadInvoiceNumbers()
        {
          


        }

    }
}