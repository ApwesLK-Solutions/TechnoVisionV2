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
        public static void FillFormOne(string orderNumber, string orderDate, string dueDate, string paymentPlan, string paymentMethod, string testBy, string orderStatus, double eyewear, double lense, double total, double advance, double discount, double balance, int reminderDays)
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
            SpecOrder.ReminderDays = reminderDays;
        }

        public static void FillFormTwo(string distRightSph, string distRightCyl, string distRightAxis, string distLeftSph, string distLeftCyl, string distLeftAxis, string addRight, string addLeft, string lenseType, string frame, string pD, string segmentHeight, string specialInstruction, string remarks)
        {
            SpecOrder.DistRightSph = distRightSph;
            SpecOrder.DistRightCyl = distRightCyl;
            SpecOrder.DistRightAxis = distRightAxis;
            SpecOrder.DistLeftSph = distLeftSph;
            SpecOrder.DistLeftCyl = distLeftCyl;
            SpecOrder.DistLeftAxis = distLeftAxis;
            SpecOrder.AddRight = addRight;
            SpecOrder.AddLeft = addLeft;
            SpecOrder.LenseType = lenseType;
            SpecOrder.Frame = frame;
            SpecOrder.PD = pD;
            SpecOrder.SegmentHeight = segmentHeight;
            SpecOrder.SpecialInstruction = specialInstruction;
            SpecOrder.Remarks = remarks;
            
        }
    }
}
