using System;
using TechnoVision.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.controller
{
    class LenseOrderController
    {
        public static void FillFormOne(string orderNumber, string orderDate, string dueDate, string testedBy, string orderStatus, double total, double advance, double discount, double balance , string paymentMethod , string PaymentPlan,int ReminderDays)
        {
            LenseOrder.OrderNumber = orderNumber;
            LenseOrder.OrderDate = orderDate;
            LenseOrder.DueDate = dueDate;
            LenseOrder.TestedBy = testedBy;
            LenseOrder.OrderStatus = orderStatus;
            LenseOrder.Total = total;
            LenseOrder.Advance = advance;
            LenseOrder.Discount = discount;
            LenseOrder.Balance = balance;
            LenseOrder.PaymentMethod = paymentMethod;
            LenseOrder.PaymentPlan = PaymentPlan;
            LenseOrder.ReminderDays = ReminderDays;
        }

       public static void FillFormTwo(string oldRightSph, string oldRightCyl, string oldRightAxis, string oldRightAdd, string oldLeftSph, string oldLeftCyl, string oldLeftAxis, string oldLeftAdd, string presentRightSph, string presentRightCyl, string presentRightAxis, string presentRightAdd, string presentLeftSph, string presentLeftCyl, string presentLeftAxis, string presentLeftAdd, string rightBc, string rightPow, string rightDia, string rightDesz, string leftBc, string leftPow, string leftDia, string leftDesz, string trailLense, string overRefract, string kReading, string blinkTest, string specialInstruction, string remarks, int reminderDays)
       {
           LenseOrder.OldRightSph = oldRightSph;
           LenseOrder.OldRightCyl = oldRightCyl;
           LenseOrder.OldRightAxis = oldRightAxis;
           LenseOrder.OldRightAdd = oldRightAdd;
           LenseOrder.OldLeftSph = oldLeftSph;
           LenseOrder.OldLeftCyl = oldLeftCyl;
           LenseOrder.OldLeftAxis = oldLeftAxis;
           LenseOrder.OldLeftAdd = oldLeftAdd;
           LenseOrder.PresentRightSph = presentRightSph;
           LenseOrder.PresentRightCyl = presentRightCyl;
           LenseOrder.PresentRightAxis = presentRightAxis;
           LenseOrder.PresentRightAdd = presentRightAdd;
           LenseOrder.PresentLeftSph = presentLeftSph;
           LenseOrder.PresentLeftCyl = presentLeftCyl;
           LenseOrder.PresentLeftAxis = presentLeftAxis;
           LenseOrder.PresentLeftAdd = presentLeftAdd;
           LenseOrder.RightBc = rightBc;
           LenseOrder.RightPow = rightPow;
           LenseOrder.RightDia = rightDia;
           LenseOrder.RightDesz = rightDesz;
           LenseOrder.LeftBc = leftBc;
           LenseOrder.LeftPow = leftPow;
           LenseOrder.LeftDia = leftDia;
           LenseOrder.LeftDesz = leftDesz;
           LenseOrder.TrailLense = trailLense;
           LenseOrder.OverRefract = overRefract;
           LenseOrder.KReading = kReading;
           LenseOrder.BlinkTest = blinkTest;
           LenseOrder.SpecialInstruction = specialInstruction;
           LenseOrder.Remarks = remarks;
           LenseOrder.ReminderDays = reminderDays;
       }
    }
}
