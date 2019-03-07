using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.view;
using TechnoVision.reports;
namespace TechnoVision.view
{
    public partial class UI_ORDER_COMPLETE : MetroFramework.Forms.MetroForm
    {
        string OrderType;
        string OrderNumber;
        string ReceiptNumber;
        public UI_ORDER_COMPLETE(string orderType , string orderNumber , string ReceiptNumber)
        {
            InitializeComponent();
            this.OrderNumber = orderNumber;
            this.OrderType = orderType;
            this.ReceiptNumber = ReceiptNumber;
           
        }

        private void UI_ORDER_COMPLETE_Load(object sender, EventArgs e)
        {

        }

        private void BtnViewCompanyCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "'AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
                else if (OrderType == "L")
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "'AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnViewCustomerCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
                else if (OrderType == "L")
                {
                    InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnPrintCustomerCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
                else if (OrderType == "L")
                {
                    InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnPrintCompanyCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);

                }
                else if (OrderType == "L")
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnPrintBothCopies_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                    InvoiceSpecCustomer rpt2 = new InvoiceSpecCustomer();
                    rpt2.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + OrderNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt2.PrintToPrinter(1, false, 1, 1);
                }
                else if (OrderType == "L")
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                    InvoiceLenseCustomer rpt2 = new InvoiceLenseCustomer();
                    rpt2.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + OrderNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt2.PrintToPrinter(1, false, 1, 1);
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }
    }
}
