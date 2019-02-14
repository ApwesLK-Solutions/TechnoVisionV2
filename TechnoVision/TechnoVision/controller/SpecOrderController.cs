using TechnoVision.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.controller
{
    class SpecOrderController
    {
        public static void FillFormOne(string orderNumber, string orderDate, string dueDate, string paymentPlan, string paymentMethod, string testBy, string orderStatus, double eyewear, double lense, double total, double advance, double discount, double balance)
        {
            SpecOrder.OrderNumber = orderNumber;
            SpecOrder.OrderDate = orderDate;
            SpecOrder.DueDate = dueDate;
            SpecOrder.PaymentPlan = paymentPlan;
            SpecOrder.PaymentMethod = paymentMethod;
            SpecOrder.TestBy = testBy;
            SpecOrder.OrderStatus = orderStatus;
            SpecOrder.Eyewear = eyewear;
            SpecOrder.Lense = lense;
            SpecOrder.Total = total;
            SpecOrder.Advance = advance;
            SpecOrder.Discount = discount;
            SpecOrder.Balance = balance;
        }

        public static void FillFormTwo(string distRightSph, string distRightCyl, string distRightAxis, string distLeftSph, string distLeftCyl, string distLeftAxis, string addRightSph, string addRightCyl, string addRightAxis, string addLeftSph, string addLeftCyl, string addLeftAxis, string lenseType, string frame, string pD, string segmentHeight, string specialInstruction, string remarks, int reminderDays)
        {
            SpecOrder.DistRightSph = distRightSph;
            SpecOrder.DistRightCyl = distRightCyl;
            SpecOrder.DistRightAxis = distRightAxis;
            SpecOrder.DistLeftSph = distLeftSph;
            SpecOrder.DistLeftCyl = distLeftCyl;
            SpecOrder.DistLeftAxis = distLeftAxis;
            SpecOrder.AddRightSph = addRightSph;
            SpecOrder.AddRightCyl = addRightCyl;
            SpecOrder.AddRightAxis = addRightAxis;
            SpecOrder.AddLeftSph = addLeftSph;
            SpecOrder.AddLeftCyl = addLeftCyl;
            SpecOrder.AddLeftAxis = addLeftAxis;
            SpecOrder.LenseType = lenseType;
            SpecOrder.Frame = frame;
            SpecOrder.PD = pD;
            SpecOrder.SegmentHeight = segmentHeight;
            SpecOrder.SpecialInstruction = specialInstruction;
            SpecOrder.Remarks = remarks;
            SpecOrder.ReminderDays = reminderDays;
        }
    }
}
