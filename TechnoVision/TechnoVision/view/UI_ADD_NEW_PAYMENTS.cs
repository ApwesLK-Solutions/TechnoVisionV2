using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.model;
using TechnoVision.controller;
namespace TechnoVision.view
{
    public partial class UI_ADD_NEW_PAYMENTS : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_NEW_PAYMENTS(string orderNumber , string orderType , int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_NEW_PAYMENT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
            receiptBindingSource.Filter = "OrderNumber ='" + orderNumber + "' AND OrderType = '" + orderType + "' AND Branch = " + Session.BranchId;

            LblOrderNo.Text = orderNumber;
            showReceiptNumber();
            if (orderType == "LENSE")
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                LblDueAmount.Text = t.FindBalanceByOrderNumber(orderNumber).ToString();
                Amount.Dispose();
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
                rno = t.getReceiptNumberByBranch(Session.BranchId, DateTime.Now.ToString("yyyy")).ToString();
                MessageBox.Show(rno);
                string BranchCharacter = rno.Substring(0, 1);
                MessageBox.Show(rno);
                MessageBox.Show(BranchCharacter);

                newRno = BranchCharacter + (int.Parse(rno.Remove(0, 1)) + 1).ToString();
            }
            catch (NullReferenceException ex)
            {
                newRno = Session.BranchName[0] + "1";
            }
            LblReceiptNo.Text = newRno;
            Receipt.ReceiptNumber = newRno;
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            receiptController.FillReceipt(orderNumber, double.Parse(Amount.Text), DateOrderDate.Value.ToString("yyyy-MM-dd"), orderType, custID);
            receiptController.WriteReceipt(this);
            if(orderType == "LENSE")
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                t.UpdateBalanceByOrderNumber(double.Parse(Amount.Text), orderNumber);
                Amount.Dispose();
            }
            if (orderType == "SPEC")
            {
                technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                t.UpdateBalanceByOrderNumber(double.Parse(Amount.Text), orderNumber);
                t.Dispose();
            }
            
            this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
            receiptBindingSource.Filter = "OrderNumber ='" + orderNumber + "' AND OrderType = '" + orderType + "' AND Branch = " + Session.BranchId;
        }

        private void BtnAddPayment_Click_1(object sender, EventArgs e)
        {

        }
    }
}
