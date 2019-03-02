﻿using System;
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
using TechnoVision.view;

namespace TechnoVision.view
{
    public partial class UI_CONTACT_LENSE_FORM_ONE : MetroFramework.Forms.MetroForm
    {
        public UI_CONTACT_LENSE_FORM_ONE()
        {
            InitializeComponent();
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtAdvance.Text=="" || TxtBalance.Text=="" || TxtDiscount.Text=="" || TxtLensesTotal.Text=="" || TxtOrderNo.Text == ""||TxtRemindDays.Text=="")
                {
                    CommonFunctions.ShowError(this, "Please Complete All Fields to continue...");
                    CommonFunctions.WriteUserLog(Session.Username, "tried to continue without enter all fields");
                }
                else
                {
                    LenseOrderController.FillFormOne(TxtOrderNo.Text, DateOrderDate.Value.ToString("yyyy-MM-dd"), DateDueDate.Value.ToString("yyyy-MM-dd"), CmbTestedBy.Text, CmbOrderStatus.Text, Double.Parse(TxtLensesTotal.Text), Double.Parse(TxtAdvance.Text), Double.Parse(TxtDiscount.Text), Double.Parse(TxtBalance.Text), CmbPaymentMethod.Text, CmbPaymentPlan.Text, int.Parse(TxtRemindDays.Text),CmbJobType.Text);
                    this.Hide();
                    new UI_CONTACT_LENSE_DIAGNOSIS(this).Show();
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void UI_CONTACT_LENSE_FORM_ONE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
            DateOrderDate.Value = DateTime.UtcNow;
            DateDueDate.Value = DateTime.UtcNow;
            
            CmbJobType.SelectedIndex = 0;
            CmbOrderStatus.SelectedIndex = 0;
            CmbPaymentMethod.SelectedIndex = 0;
            CmbPaymentPlan.SelectedIndex = 0;
            //CmbTestedBy.SelectedIndex = 0;
            TxtOrderNo.Text = getOrderNumber();
            showReceiptNumber();
        }

        private string getOrderNumber()
        {
            try
            {
                string LastOrderNumber;
                string NewOrderNumber;
                technovisionDataSetTableAdapters.contactlenseTableAdapter table = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                try
                {
                    LastOrderNumber = table.GetLastOrderNumber(Session.BranchId,DateTime.Now.ToString("yyyy")).ToString();
                    NewOrderNumber = (int.Parse(LastOrderNumber) + 1).ToString();
                }
                catch (NullReferenceException ex)
                {
                    NewOrderNumber = DateTime.Now.ToString("yy") + "0001";
                }
                return NewOrderNumber;
            }
            catch(Exception ex)
            {
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
                rno = t.getReceiptNumberByBranch(Session.BranchId).ToString();
                newRno = (int.Parse(rno) + 1).ToString();
            }
            catch(NullReferenceException ex)
            {
                newRno = "1";
            }
            LblReceiptNo.Text = newRno;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            double discount = 0;
            double advance = 0;
            double balance = 0;

            total = Double.Parse(TxtLensesTotal.Text);
            discount = Double.Parse(TxtDiscount.Text);
            advance = Double.Parse(TxtAdvance.Text);

            balance = (total) - (discount) -(advance);
            TxtBalance.Text = balance.ToString();


        }

        private void TxtLensesTotal_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
