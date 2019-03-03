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
    public partial class UI_SHOW_ORDER_BY_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        int custID;
        string CustName;
        public UI_SHOW_ORDER_BY_CUSTOMER(string custName , int custID)
        {
            InitializeComponent();
            this.custID = custID;
            this.CustName = custName;
        }

        private void UI_SHOW_ORDER_BY_CUSTOMER_Load(object sender, EventArgs e)
        {
            RadioSpectacles.Checked = true;
            // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
            this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
            // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
            this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
            contactlenseBindingSource.Filter = "CustomerId = " + custID;
            spectaclesBindingSource.Filter = "CustomerId = " + custID;
            LblCustomerName.Text = CustName;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RadioSpectacles.Checked == true)
            {
                GridContactLense.Visible = false;
                GridSpectacle.Visible = true;
            }
            else if(RadioContactLense.Checked == true)
            {
                GridContactLense.Visible = true;
                GridSpectacle.Visible = false;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (RadioContactLense.Checked == true)
            {
                contactlenseBindingSource.Filter ="CustomerId = " + custID + " AND Branch =" + Session.BranchId + "AND OrderNumber LIKE '*" + TxtSearch.Text + "*'";
            }
            else if (RadioSpectacles.Checked == true)
            {
                spectaclesBindingSource.Filter = "CustomerId = " + custID + " AND Branch =" + Session.BranchId + "AND OrderNumber LIKE '*" + TxtSearch.Text + "*'";
            }
        }
    }
}
