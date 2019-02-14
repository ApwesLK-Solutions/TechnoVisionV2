using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.model
{
    class LenseOrder
    {
        private string OrderNumber;
        private string JobType;
        private string TestedBy;

        private string OldRightSph;
        private string OldRightCyl;
        private string OldRightAxis;
        private string OldRightAdd;

        private string OldLeftSph;
        private string OldLeftCyl;
        private string OldLeftAxis;
        private string OldLeftAdd;

        private string PresentRightSph;
        private string PresentRightCyl;
        private string PresentRightAxis;
        private string PresentRightAdd;

        private string PresentLeftSph;
        private string PresentLeftCyl;
        private string PresentLeftAxis;
        private string PresentLeftAdd;

        private string RightBc;
        private string RightPow;
        private string RightDia;
        private string RightDesz;

        private string LeftBc;
        private string LeftPow;
        private string LeftDia;
        private string LeftDesz;

        private string TrailLense;
        private string OverRefract;
        private string KReading;
        private string BlinkTest;
        private string SpecialInstruction;
        private string Remarks;
        private string ReminderDays;
        
        public LenseOrder()
        {
            this.OrderNumber = getOrderNumber();
        }
        public void testPrintOrderNumber()
        {
            Console.WriteLine(this.OrderNumber);
        }


        private string getOrderNumber()
        {
            try
            {
                technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
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
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
