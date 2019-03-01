using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.model
{
    class Receipt
    {
        public static int orderNumber;
        public static double paymentAmount;
        public static string receiptDate;
        public static int branch = Session.BranchId;
    }
}
