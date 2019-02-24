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
    public partial class UI_VIEW_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        public UI_VIEW_CUSTOMER()
        {
            InitializeComponent();
        }

        private void UI_VIEW_CUSTOMER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.technovisionDataSet.customer);

        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            new UI_EDIT_CUSTOMER(GridManageCustomer.SelectedRows[0].Cells[0].Value.ToString()).Show();
        }
    }
}