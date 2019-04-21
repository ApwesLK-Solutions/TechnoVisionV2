using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.controller;
using TechnoVision.model;
using TechnoVision.reports;

namespace TechnoVision.view
{
    public partial class UI_ADD_ADVANCE : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_ADVANCE(string orderNumber, string orderType, int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_ADVANCE_Load(object sender, EventArgs e)
        {
            DateOrderDate.MinDate = DateTime.UtcNow.AddDays(-1);
            LblOrderNo.Text = orderNumber;
            showReceiptNumber();
            if (orderType == "LENSE")
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                LblDueAmount.Text = t.FindBalanceByOrderNumber(orderNumber).ToString();
                t.Dispose();
            }
            if (orderType == "SPEC")
            {
                technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                LblDueAmount.Text = t.FindBalanceByOrderNumber(orderNumber).ToString();
                t.Dispose();
            }
        }

        private void showReceiptNumber()
        {
            technovisionDataSetTableAdapters.receiptTableAdapter t = new technovisionDataSetTableAdapters.receiptTableAdapter();
            string rno;
            string newRno;
            try
            {
                t.GetMaxReceipt(Session.BranchId, DateTime.Now.ToString("yyyy"), out rno);
                Console.WriteLine(rno);
                string BranchCharacter = rno.Substring(0, 1);
                newRno = BranchCharacter + (int.Parse(rno.Remove(0, 1)) + 1).ToString();
            }
            catch (NullReferenceException ex)
            {
                newRno = Session.BranchName[0] + "1";
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            LblReceiptNo.Text = newRno;
            TechnoVision.model.Receipt.ReceiptNumber = newRno;
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                Receipt.branch = Session.BranchId;
                Receipt.custId = custID;
                Receipt.orderNumber = LblOrderNo.Text;
                Receipt.OrderType = orderType;
                Receipt.paymentAmount = Double.Parse(TxtAmount.Text);
                Receipt.receiptDate = DateTime.Now.ToString("yyyy-MM-dd");
                Receipt.ReceiptNumber = LblReceiptNo.Text;
                receiptController.WriteReceipt(this);

                if(orderType =="LENSE")
                {
                    technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                    t.UpdateBalanceByOrderNumber(double.Parse(LblDueAmount.Text) - double.Parse(TxtAmount.Text), orderNumber);
                    t.UpdateAdvanceByOrderNumber(Receipt.paymentAmount, orderNumber);
                    t.Dispose();
                    CommonFunctions.ShowSuccess(this, "New Advance Payment Added To " + LblOrderNo.Text);
                    InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + Receipt.orderNumber + "' AND {receipt1.ReceiptNumber} = '" + Receipt.ReceiptNumber + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt).Show();
                    
                    InvoiceLenseCompany rpt1 = new InvoiceLenseCompany();
                    rpt1.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + orderNumber + "'AND {receipt1.ReceiptNumber} = '" + LblReceiptNo.Text + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    rpt1.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt1).Show();

                }
                if(orderType =="SPEC")
                {
                    technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                    t.UpdateBalanceByOrderNumber(double.Parse(LblDueAmount.Text) - double.Parse(TxtAmount.Text), orderNumber);
                    t.UpdateAdvanceByOrderNumber(Receipt.paymentAmount, orderNumber);
                    t.Dispose();
                    CommonFunctions.ShowSuccess(this, "New Advance Payment Added To " + LblOrderNo.Text);
                    InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + Receipt.orderNumber + "' AND {receipt1.ReceiptNumber} = '" + Receipt.ReceiptNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt).Show();

                    InvoiceSpecCompany rpt1 = new InvoiceSpecCompany();
                    rpt1.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + orderNumber + "' AND {receipt1.ReceiptNumber} = '" + Receipt.ReceiptNumber + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    rpt1.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt1).Show();
                }
                

            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.ToString());
            }
            

        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
