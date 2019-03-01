using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.model
{
    class LenseOrder
    {
        public static string OrderNumber;
        public static string OrderDate;
        public static string DueDate;
        public static string TestedBy;
        public static string OrderStatus;
        public static double Total;
        public static double Advance;
        public static double Discount;
        public static double Balance;
        public static string PaymentPlan;
        public static string PaymentMethod;
        



        public static string OldRightSph;
        public static string OldRightCyl;
        public static string OldRightAxis;
        public static string OldRightAdd;

        public static string OldLeftSph;
        public static string OldLeftCyl;
        public static string OldLeftAxis;
        public static string OldLeftAdd;

        public static string PresentRightSph;
        public static string PresentRightCyl;
        public static string PresentRightAxis;
        public static string PresentRightAdd;

        public static string PresentLeftSph;
        public static string PresentLeftCyl;
        public static string PresentLeftAxis;
        public static string PresentLeftAdd;

        public static string RightBc;
        public static string RightPow;
        public static string RightDia;
        public static string RightDesz;

        public static string LeftBc;
        public static string LeftPow;
        public static string LeftDia;
        public static string LeftDesz;

        public static string TrailLense;
        public static string OverRefract;
        public static string KReading;
        public static string BlinkTest;
        public static string SpecialInstruction;
        public static string Remarks;
        public static int ReminderDays;
        public static int Branch = Session.BranchId;

    }
}
