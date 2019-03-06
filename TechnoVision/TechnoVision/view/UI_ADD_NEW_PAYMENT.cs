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
    public partial class UI_ADD_NEW_PAYMENT : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_NEW_PAYMENT(string orderNumber , string orderType , int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_NEW_PAYMENT_Load(object sender, EventArgs e)
        {
            LblOrderNumber.Text = orderNumber;
            showReceiptNumber();
            if (orderType == "LENSE")
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                LblDueAmount.Text = t.FindBalanceByOrderNumber(orderNumber).ToString();
                TxtPaymentAmount.Dispose();
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
            receiptController.FillReceipt(orderNumber, double.Parse(TxtPaymentAmount.Text), DateOrderDate.Value.ToString("yyyy-MM-dd"), orderType, custID);
            receiptController.WriteReceipt(this);
            if(orderType == "LENSE")
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                t.UpdateBalanceByOrderNumber(double.Parse(TxtPaymentAmount.Text), orderNumber);
                TxtPaymentAmount.Dispose();
            }
            if (orderType == "SPEC")
            {
                technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                t.UpdateBalanceByOrderNumber(double.Parse(TxtPaymentAmount.Text), orderNumber);
                t.Dispose();
            }
        }
    }
}
