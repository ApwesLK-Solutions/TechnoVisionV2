﻿using System;
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
namespace TechnoVision.view
{
    public partial class UI_SPECTACLES_FORM_ONE : MetroFramework.Forms.MetroForm
    {
        int custID;
        double EyeWearAmount = 0;
        double LenseAmount = 0;
        double total = 0;
        double discount = 0;
        double advance = 0;
        double balance = 0;
        public UI_SPECTACLES_FORM_ONE(int CustID)
        {
            InitializeComponent();
            this.custID = CustID;
        }

        private void UI_SPECTACLES_FORM_ONE_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
                this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
                DateOrderDate.Value = DateTime.UtcNow;
                DateDueDate.Value = DateTime.UtcNow;
                CmbOrderStatus.SelectedIndex = 0;
                CmbPaymentMethod.SelectedIndex = 0;
                CmbPaymentPlan.SelectedIndex = 0;
                CmbTestedBy.SelectedIndex = 0;
                
                DateOrderDate.MinDate =  DateTime.UtcNow.AddDays(-30);;
                DateDueDate.MinDate = DateTime.UtcNow;
            }
            catch(Exception)
            {
                CommonFunctions.ShowError(this,"Can not Find any Testers in a system.Please Enter Tester to Continue");

            }
            showReceiptNumber();
            TxtOrderNo.Text = getOrderNumber();


        }
        private string getOrderNumber()
        {
            try
            {
                string LastOrderNumber;
                string NewOrderNumber;

                technovisionDataSetTableAdapters.spectaclesTableAdapter table = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                try
                {
                    LastOrderNumber = table.GetLastOrderNumber(Session.BranchId , DateTime.Now.ToString("yyyy")).ToString();
                    NewOrderNumber = (int.Parse(LastOrderNumber) + 1).ToString();                  
                }
                catch (NullReferenceException ex)
                {
                    NewOrderNumber = DateTime.Now.ToString("yy") + "0001";
                }
                return NewOrderNumber;
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                return null;
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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtOrderNo.Text=="" || TxtAdvance.Text=="" || TxtBalance.Text =="" || TxtDiscount.Text=="" || TxtEyeWearAmount.Text =="" || TxtLenseAmount.Text=="" ||TxtRemindDays.Text ==""||TxtTotal.Text=="" || CmbOrderStatus.Text =="" || CmbPaymentMethod.Text =="" || CmbPaymentPlan.Text =="" || CmbTestedBy.Text=="")
                {
                    CommonFunctions.ShowError(this, "Please Complete All Fields to continue...");
                    CommonFunctions.WriteUserLog(Session.Username, "tried to continue without enter all fields");
                }
            
                else
                {
                       
                    SpecOrderController.FillFormOne(TxtOrderNo.Text, DateOrderDate.Value.ToString("yyyy-MM-dd"), DateDueDate.Value.ToString("yyyy-MM-dd"), CmbPaymentPlan.Text, CmbPaymentMethod.Text, CmbTestedBy.Text, CmbOrderStatus.Text, Double.Parse(TxtEyeWearAmount.Text), Double.Parse(TxtLenseAmount.Text), Double.Parse(TxtTotal.Text), Double.Parse(TxtAdvance.Text), Double.Parse(TxtDiscount.Text), Double.Parse(TxtBalance.Text), int.Parse(TxtRemindDays.Text), custID);
                    receiptController.FillReceipt(SpecOrder.OrderNumber, SpecOrder.Advance, SpecOrder.OrderDate, "SPEC", custID);

                    new UI_SPECTACLES_DIAGNOSIS(this).Show();
                    this.Hide();
                       
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (TxtAdvance.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtAdvance.Text = "0";
            }
            else if (TxtDiscount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtDiscount.Text = "0";
            }
            else if (TxtEyeWearAmount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtEyeWearAmount.Text = "0";
            }
            else if (TxtLenseAmount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtLenseAmount.Text = "0";
            }
            else
            {
                EyeWearAmount = Double.Parse(TxtEyeWearAmount.Text);
                LenseAmount = Double.Parse(TxtLenseAmount.Text);
                total = Double.Parse(TxtDiscount.Text);
                discount = Double.Parse(TxtDiscount.Text);
                advance = Double.Parse(TxtAdvance.Text);
                balance = Double.Parse(TxtBalance.Text);

                total = EyeWearAmount + LenseAmount;
                TxtTotal.Text = total.ToString();
                balance = total - discount - advance;
                TxtBalance.Text = balance.ToString();
            }
            
        }

        private void TxtEyeWearAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtLenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtRemindDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtAdvance.Text = "0";
            TxtDiscount.Text = "0";
            TxtEyeWearAmount.Text = "0";
            TxtLenseAmount.Text = "0";
            TxtBalance.Text = "0";
            TxtTotal.Text = "0";
            TxtRemindDays.Text = "";
        }
    }
}
