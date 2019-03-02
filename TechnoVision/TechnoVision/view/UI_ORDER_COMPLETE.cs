﻿using System;
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
    public partial class UI_ORDER_COMPLETE : MetroFramework.Forms.MetroForm
    {
        string OrderType;
        string OrderNumber;
        string ReceiptNumber;
        string CustomerID;
        public UI_ORDER_COMPLETE(string orderType , string orderNumber , string ReceiptNumber , string CustomerId)
        {
            InitializeComponent();
            this.OrderNumber = orderNumber;
            this.OrderType = orderType;
            this.ReceiptNumber = ReceiptNumber;
            this.CustomerID = CustomerId;
        }

        private void UI_ORDER_COMPLETE_Load(object sender, EventArgs e)
        {

        }
    }
}
