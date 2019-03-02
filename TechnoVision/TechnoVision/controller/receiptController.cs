using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVision.model;

namespace TechnoVision.controller
{
    class receiptController
    {
        public static void WriteReceipt()
        {
            try
            {
                technovisionDataSetTableAdapters.receiptTableAdapter t = new technovisionDataSetTableAdapters.receiptTableAdapter();
                t.Insert(DateTime.Parse(Receipt.receiptDate), Receipt.orderNumber.ToString(), Receipt.paymentAmount, Receipt.branch);
                CommonFunctions.WriteUserLog(Session.Username, "New Payment Receipt for Order Number " + Receipt.orderNumber + " Added to the System.");
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
            }

        }
        public static void FillReceipt(int orderNumber , double amount , string date , string OrderType)
        {
            Receipt.OrderType = OrderType;
            Receipt.orderNumber = orderNumber;
            Receipt.paymentAmount = amount;
            Receipt.receiptDate = date;
        }
    }
}
