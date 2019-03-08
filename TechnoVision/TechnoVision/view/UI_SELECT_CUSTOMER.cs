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
    public partial class UI_SELECT_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        private string OrderType;
        public UI_SELECT_CUSTOMER(string OrderType)
        {
            InitializeComponent();
            this.OrderType = OrderType;
        }

        private void UI_SELECT_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
                customerBindingSource.Filter = "Branch =" + Session.BranchId;
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this,"Can not Load Customer List OR no Customers in database");
            }
            

        }

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.Filter = "Branch =" + Session.BranchId + " AND Name LIKE '%" + TxtSearchCustomer.Text + "%' OR Phone LIKE'%" + TxtSearchCustomer.Text + "%'";

            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, "No search results");
            }

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            new UI_ADD_CUSTOMER().Show();
            new UI_ADD_CUSTOMER().BringToFront();
        }

        private void GridSelectCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    new UI_SPECTACLES_FORM_ONE(int.Parse(GridSelectCustomer.SelectedRows[0].Cells[0].Value.ToString())).Show();
                }
                else if (OrderType == "L")
                {
                    new UI_CONTACT_LENSE_FORM_ONE(int.Parse(GridSelectCustomer.SelectedRows[0].Cells[0].Value.ToString())).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Please Select a customer from the table or Double click on customer");
                CommonFunctions.WriteUserLog(Session.Username, "selected customer null");
                CommonFunctions.WriteToErrorLog("selected customer null");
            }
            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderType == "S")
                {
                    new UI_SPECTACLES_FORM_ONE(int.Parse(GridSelectCustomer.SelectedRows[0].Cells[0].Value.ToString())).Show();
                }
                else if (OrderType == "L")
                {
                    new UI_CONTACT_LENSE_FORM_ONE(int.Parse(GridSelectCustomer.SelectedRows[0].Cells[0].Value.ToString())).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Please Select a customer from the table or Double click on customer");
                CommonFunctions.WriteUserLog(Session.Username, "selected customer null");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
            this.Dispose();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
        }

        
    }
}
