using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.view;
namespace TechnoVision.view
{
    public partial class UI_ORDER_COMPLETE : MetroFramework.Forms.MetroForm
    {
        string OrderType;
        string OrderNumber;
        string ReceiptNumber;
        public UI_ORDER_COMPLETE(string orderType , string orderNumber , string ReceiptNumber)
        {
            InitializeComponent();
            this.OrderNumber = orderNumber;
            this.OrderType = orderType;
            this.ReceiptNumber = ReceiptNumber;
           
        }

        private void UI_ORDER_COMPLETE_Load(object sender, EventArgs e)
        {

        }

        private void BtnViewCompanyCopy_Click(object sender, EventArgs e)
        {
            /*if(OrderType == "S")
            {
                RPT_SPEC_COMPANY rpt = new RPT_SPEC_COMPANY();
                new UI_REPORT_VIEWER(rpt).Show();
            }
            else if(OrderType == "L")
            {

            }*/
        }
    }
}
