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
namespace TechnoVision.view
{
    public partial class UI_CONTACT_LENSE_DIAGNOSIS : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Forms.MetroForm f;

        public UI_CONTACT_LENSE_DIAGNOSIS(MetroFramework.Forms.MetroForm form)
        {
            InitializeComponent();
            f = form;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtBlindTest.Text=="" || TxtKReading.Text==""||TxtLeftBc.Text==""||TxtLeftDeze.Text==""||TxtLeftDia.Text==""||TxtLeftOldAdd.Text==""||TxtLeftOldAxis.Text==""||TxtLeftOldCyl.Text==""||TxtLeftOldSph.Text==""||TxtLeftPow.Text==""||TxtLeftPresentAdd.Text==""||TxtLeftPresentAxis.Text==""||TxtLeftPresentCyl.Text==""||TxtLeftPresentSph.Text==""||TxtOverRefract.Text==""||TxtRemarks.Text==""||TxtRightBc.Text==""||TxtRightDeze.Text==""||TxtRightDia.Text==""||TxtRightOldAdd.Text==""||TxtRightOldAxis.Text=="" ||TxtRightOldCyl.Text==""||TxtRightOldSph.Text==""||TxtRightPow.Text==""||TxtRightPresentAdd.Text==""||TxtRightPresentAxis.Text==""||TxtRightPresentCyl.Text==""||TxtRightPresentSph.Text==""||TxtSpecialIns.Text==""||TxtTrailLense.Text=="")
                {
                    CommonFunctions.ShowError(this, "Please Complete All Fields to continue...If You have Empty Fileds Please put'-' into Text Area...");
                }
                else
                {
                    if(LenseOrder.Advance == 0 || LenseOrder.PaymentMethod=="N-C")
                    {
                        LenseOrderController.FillFormTwo(TxtRightOldSph.Text, TxtRightOldCyl.Text, TxtRightOldAxis.Text, TxtRightOldAdd.Text, TxtLeftOldSph.Text, TxtLeftOldCyl.Text, TxtLeftOldAxis.Text, TxtLeftOldAdd.Text, TxtRightPresentSph.Text, TxtRightPresentCyl.Text, TxtRightPresentAxis.Text, TxtRightPresentAdd.Text, TxtRightPresentAdd.Text, TxtLeftPresentCyl.Text, TxtLeftPresentAxis.Text, TxtLeftPresentAdd.Text, TxtRightBc.Text, TxtRightPow.Text, TxtRightDia.Text, TxtRightDeze.Text, TxtLeftBc.Text, TxtLeftPow.Text, TxtLeftDia.Text, TxtLeftDeze.Text, TxtTrailLense.Text, TxtOverRefract.Text, TxtKReading.Text, TxtBlindTest.Text, TxtSpecialIns.Text, TxtRemarks.Text);
                        technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                        t.Insert(LenseOrder.OrderNumber, DateTime.Parse(LenseOrder.OrderDate), DateTime.Parse(LenseOrder.DueDate), LenseOrder.JobType, LenseOrder.TestedBy, LenseOrder.Total, LenseOrder.Discount, LenseOrder.Advance, LenseOrder.Balance, LenseOrder.PaymentMethod, LenseOrder.PaymentPlan, LenseOrder.OrderStatus, LenseOrder.OldRightSph, LenseOrder.OldRightCyl, LenseOrder.OldRightAxis, LenseOrder.OldRightAdd, LenseOrder.OldLeftSph, LenseOrder.OldLeftCyl, LenseOrder.OldLeftAxis, LenseOrder.OldLeftAdd, LenseOrder.PresentRightSph, LenseOrder.PresentRightCyl, LenseOrder.PresentRightAxis, LenseOrder.PresentRightAdd, LenseOrder.PresentLeftSph, LenseOrder.PresentLeftCyl, LenseOrder.PresentLeftAxis, LenseOrder.PresentLeftAdd, LenseOrder.RightBc, LenseOrder.RightPow, LenseOrder.RightDia, LenseOrder.RightDesz, LenseOrder.LeftBc, LenseOrder.LeftPow, LenseOrder.LeftDia, LenseOrder.LeftDesz, LenseOrder.TrailLense, LenseOrder.OverRefract, LenseOrder.KReading, LenseOrder.BlinkTest, LenseOrder.SpecialInstruction, LenseOrder.Remarks, LenseOrder.ReminderDays, LenseOrder.Branch, DateTime.Now.ToString("yyyy"), LenseOrder.custID);
                        //receiptController.WriteReceipt(this);
                        CommonFunctions.WriteUserLog(Session.Username, "Added New Lense Order : " + LenseOrder.OrderNumber);
                        CommonFunctions.ShowSuccess(this, "Order Number " + LenseOrder.OrderNumber + " Saved Succesfully...");
                        this.Dispose();
                        f.Dispose();
                        if(LenseOrder.PaymentMethod =="N-C" && LenseOrder.Advance==0)
                        {
                            new UI_ORDER_COMPLETE("L", LenseOrder.OrderNumber, "N-C").Show();
                        }
                        else if(LenseOrder.PaymentMethod !="N-C" && LenseOrder.Advance==0)
                        {
                            new UI_ORDER_COMPLETE("L", LenseOrder.OrderNumber, "Not Paid").Show();
                        }
                    }
                    else
                    {
                        LenseOrderController.FillFormTwo(TxtRightOldSph.Text, TxtRightOldCyl.Text, TxtRightOldAxis.Text, TxtRightOldAdd.Text, TxtLeftOldSph.Text, TxtLeftOldCyl.Text, TxtLeftOldAxis.Text, TxtLeftOldAdd.Text, TxtRightPresentSph.Text, TxtRightPresentCyl.Text, TxtRightPresentAxis.Text, TxtRightPresentAdd.Text, TxtRightPresentAdd.Text, TxtLeftPresentCyl.Text, TxtLeftPresentAxis.Text, TxtLeftPresentAdd.Text, TxtRightBc.Text, TxtRightPow.Text, TxtRightDia.Text, TxtRightDeze.Text, TxtLeftBc.Text, TxtLeftPow.Text, TxtLeftDia.Text, TxtLeftDeze.Text, TxtTrailLense.Text, TxtOverRefract.Text, TxtKReading.Text, TxtBlindTest.Text, TxtSpecialIns.Text, TxtRemarks.Text);
                        technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                        t.Insert(LenseOrder.OrderNumber, DateTime.Parse(LenseOrder.OrderDate), DateTime.Parse(LenseOrder.DueDate), LenseOrder.JobType, LenseOrder.TestedBy, LenseOrder.Total, LenseOrder.Discount, LenseOrder.Advance, LenseOrder.Balance, LenseOrder.PaymentMethod, LenseOrder.PaymentPlan, LenseOrder.OrderStatus, LenseOrder.OldRightSph, LenseOrder.OldRightCyl, LenseOrder.OldRightAxis, LenseOrder.OldRightAdd, LenseOrder.OldLeftSph, LenseOrder.OldLeftCyl, LenseOrder.OldLeftAxis, LenseOrder.OldLeftAdd, LenseOrder.PresentRightSph, LenseOrder.PresentRightCyl, LenseOrder.PresentRightAxis, LenseOrder.PresentRightAdd, LenseOrder.PresentLeftSph, LenseOrder.PresentLeftCyl, LenseOrder.PresentLeftAxis, LenseOrder.PresentLeftAdd, LenseOrder.RightBc, LenseOrder.RightPow, LenseOrder.RightDia, LenseOrder.RightDesz, LenseOrder.LeftBc, LenseOrder.LeftPow, LenseOrder.LeftDia, LenseOrder.LeftDesz, LenseOrder.TrailLense, LenseOrder.OverRefract, LenseOrder.KReading, LenseOrder.BlinkTest, LenseOrder.SpecialInstruction, LenseOrder.Remarks, LenseOrder.ReminderDays, LenseOrder.Branch, DateTime.Now.ToString("yyyy"), LenseOrder.custID);
                        receiptController.WriteReceipt(this);
                        CommonFunctions.WriteUserLog(Session.Username, "Added New Lense Order : " + LenseOrder.OrderNumber);
                        CommonFunctions.ShowSuccess(this, "Order Number " + LenseOrder.OrderNumber + " Saved Succesfully...");
                        this.Dispose();
                        f.Dispose();
                        new UI_ORDER_COMPLETE("L", LenseOrder.OrderNumber, Receipt.ReceiptNumber).Show();
                    }
                    

                }
                
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                CommonFunctions.ShowError(this,ex.Message);
            }
        }

       

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBlindTest.Text = "";
            TxtKReading.Text = "";
            TxtLeftBc.Text = "";
            TxtLeftDeze.Text = "";
            TxtLeftDia.Text = "";
            TxtLeftOldAdd.Text = "";
            TxtLeftOldAxis.Text = "";
            TxtLeftOldCyl.Text = "";
            TxtLeftOldSph.Text = "";
            TxtLeftPow.Text = "";
            TxtLeftPresentAdd.Text = "";
            TxtLeftPresentAxis.Text = "";
            TxtLeftPresentCyl.Text = "";
            TxtLeftPresentSph.Text = "";
            TxtOverRefract.Text = "";
            TxtRemarks.Text = "";
            TxtRightBc.Text = "";
            TxtRightDeze.Text = "";
            TxtRightDia.Text = "";
            TxtRightOldAdd.Text = "";
            TxtRightOldAxis.Text = "";
            TxtRightOldCyl.Text = "";
            TxtRightOldSph.Text = "";
            TxtRightPow.Text = "";
            TxtRightPresentAdd.Text = "";
            TxtRightPresentAxis.Text = "";
            TxtRightPresentCyl.Text = "";
            TxtRightPresentSph.Text = "";
            TxtSpecialIns.Text = "";
            TxtTrailLense.Text = "";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            f.Show();
        }

        private void UI_CONTACT_LENSE_DIAGNOSIS_Load(object sender, EventArgs e)
        {

        }
    }
}
