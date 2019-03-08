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
    public partial class UI_ADD_NEW_PAYMENT : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_NEW_PAYMENT(string orderNumber, string orderType, int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_NEW_PAYMENT_Load(object sender, EventArgs e)
        {
            DateOrderDate.MinDate = DateTime.UtcNow;
            // TODO: This line of code loads data into the 'technovisionDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
            receiptBindingSource.Filter = "OrderNumber ='" + orderNumber + "' AND OrderType = '" + orderType + "' AND Branch = " + Session.BranchId;

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
                t.GetMaxReceipt(Session.BranchId,DateTime.Now.ToString("yyyy"),out rno);
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
                receiptController.FillReceipt(orderNumber, double.Parse(TxtAmount.Text), DateOrderDate.Value.ToString("yyyy-MM-dd"), orderType, custID);
                receiptController.WriteReceipt(this);
                if (orderType == "LENSE")
                {
                    technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                    t.UpdateBalanceByOrderNumber(double.Parse(TxtAmount.Text), orderNumber);
                    t.Dispose();
                    CommonFunctions.ShowSuccess(this, "New Payment Added To " + LblOrderNo.Text);
                    CommonFunctions.WriteUserLog(Session.Username, "New Payment Added To " + LblOrderNo.Text);
                    InvReceiptContactLense rpt = new InvReceiptContactLense();
                    rpt.RecordSelectionFormula = "{receipt1.ReceiptNumber} ='" + LblReceiptNo.Text + "'";
                    rpt.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt).Show();
                    this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
                    receiptBindingSource.Filter = "OrderNumber ='" + orderNumber + "' AND OrderType = '" + orderType + "' AND Branch = " + Session.BranchId;
                }
                if (orderType == "SPEC")
                {
                    technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                    t.UpdateBalanceByOrderNumber(double.Parse(TxtAmount.Text), orderNumber);
                    t.Dispose();
                    CommonFunctions.ShowSuccess(this, "New Payment Added To " + LblOrderNo.Text);
                    CommonFunctions.WriteUserLog(Session.Username, "New Payment Added To " + LblOrderNo.Text);
                    InvReceipt rpt = new InvReceipt();
                    rpt.RecordSelectionFormula = "{receipt1.ReceiptNumber} ='" + LblReceiptNo.Text + "'";
                    rpt.PrintToPrinter(1, false, 1, 1);
                    new UI_REPORT_VIEWER(rpt).Show();
                    this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
                    receiptBindingSource.Filter = "OrderNumber ='" + orderNumber + "' AND OrderType = '" + orderType + "' AND Branch = " + Session.BranchId;
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
    }
}
