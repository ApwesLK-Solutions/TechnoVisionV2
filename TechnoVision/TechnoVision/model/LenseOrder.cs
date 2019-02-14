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
        public static string JobType;
        public static string TestedBy;
        public static string OrderStatus;
        public static double Total;
        public static double Advance;
        public static double Discount;
        public static double Balance;



        public string OldRightSph;
        public string OldRightCyl;
        public string OldRightAxis;
        public string OldRightAdd;

        public string OldLeftSph;
        public string OldLeftCyl;
        public string OldLeftAxis;
        public string OldLeftAdd;

        public string PresentRightSph;
        public string PresentRightCyl;
        public string PresentRightAxis;
        public string PresentRightAdd;

        public string PresentLeftSph;
        public string PresentLeftCyl;
        public string PresentLeftAxis;
        public string PresentLeftAdd;

        public string RightBc;
        public string RightPow;
        public string RightDia;
        public string RightDesz;

        public string LeftBc;
        public string LeftPow;
        public string LeftDia;
        public string LeftDesz;

        public string TrailLense;
        public string OverRefract;
        public string KReading;
        public string BlinkTest;
        public string SpecialInstruction;
        public string Remarks;
        public string ReminderDays;
        
   
        /*private string getOrderNumber()
        {
            try
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                string newID = t.getMaxID().ToString();
                if (newID =)
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
            catch(Exception ex)
            {
                return null;
            }
        }*/


    }
}
