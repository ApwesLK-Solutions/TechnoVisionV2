﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVision.model;

namespace TechnoVision.controller
{
    class receiptController
    {
        public static void WriteReceipt(MetroFramework.Forms.MetroForm form)
        {
            try
            {
                technovisionDataSetTableAdapters.receiptTableAdapter t = new technovisionDataSetTableAdapters.receiptTableAdapter();
                t.Insert(Receipt.ReceiptNumber,DateTime.Parse(Receipt.receiptDate),Receipt.orderNumber,Receipt.paymentAmount,Receipt.branch,Receipt.OrderType,DateTime.Now.ToString("yyyy"),Receipt.custId);
                CommonFunctions.WriteUserLog(Session.Username, "New Payment Receipt for " + Receipt.OrderType + " Order Number  " + Receipt.orderNumber + " Added to the System.");
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                CommonFunctions.ShowError(form, "show "+Receipt.ReceiptNumber+","+Receipt.receiptDate+","+Receipt.orderNumber+","+Receipt.paymentAmount+","+Receipt.branch+","+Receipt.OrderType+","+Receipt.custId+"");
                CommonFunctions.ShowError(form,ex.Message);

            }

        }
        public static void FillReceipt(string orderNumber , double amount , string date , string OrderType , int CustId)
        {
            Receipt.OrderType = OrderType;
            Receipt.orderNumber = orderNumber;
            Receipt.paymentAmount = amount;
            Receipt.receiptDate = date;
            Receipt.custId = CustId;
        }
    }
}
