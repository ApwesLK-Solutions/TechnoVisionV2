using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoVision.view
{
    public partial class UI_ADD_NEW_PAYMENT : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_NEW_PAYMENT(string orderNumber , string orderType , int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_NEW_PAYMENT_Load(object sender, EventArgs e)
        {
            MessageBox.Show(orderNumber + " - " + orderType + " - " + custID.ToString());
        }
    }
}
