using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoVision.model
{
    class Receipt
    {
        public static string orderNumber;
        public static double paymentAmount;
        public static string receiptDate;
        public static int branch = Session.BranchId;
        public static string OrderType;
        public static string ReceiptNumber;
        public static int custId;
    }
}
