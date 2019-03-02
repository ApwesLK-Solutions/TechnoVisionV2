using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.model
{
    class SpecOrder
    {
        public static int custID;
        public static string OrderNumber;
        public static string OrderDate;
        public static string DueDate;
        public static string PaymentPlan;
        public static string PaymentMethod;
        public static string TestBy;
        public static string OrderStatus;
        public static double Eyewear;
        public static double Lense;
        public static double Total;
        public static double Advance;
        public static double Discount;
        public static double Balance;

        //End of Form one

        public static string DistRightSph;
        public static string DistRightCyl;
        public static string DistRightAxis;
        public static string DistLeftSph;
        public static string DistLeftCyl;
        public static string DistLeftAxis;

        public static string AddRight;
        public static string AddLeft;

        public static string LenseType;
        public static string Frame;
        public static string PD;
        public static string SegmentHeight;
        public static string SpecialInstruction;
        public static string Remarks;
        public static int ReminderDays;
        public static int Branch = Session.BranchId;




        /*private string getOrderNumber()
        {
            try
            {
                technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                string newID = t.getMaxID().ToString();
                if (newID == "")
                {
                    newID = "0";
                }
                newID = (int.Parse(newID) + 1).ToString();
                if (newID.Length < 4)
                {
                    while (newID.Length < 4)
                    {
                        newID = "0" + newID;
                    }
                }
                newID = DateTime.Now.ToString("yy") + newID;
                return newID;
            }
            catch (Exception ex)
            {
                return null;
            }
        }*/
    }
}
