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
    public partial class UI_VIEW_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        public UI_VIEW_CUSTOMER()
        {
            InitializeComponent();
        }

        private void UI_VIEW_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
            //edit upon multi branch to filter for branch customers
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                new UI_EDIT_CUSTOMER(GridManageCustomer.SelectedRows[0].Cells[0].Value.ToString()).Show();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "There is Nothing To Select Or Not Selected");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if(TxtSearchCustomer.Text=="")
            {
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
                this.GridManageCustomer.DataSource = this.technovisionDataSet.customer;

            }
            else
            {
                technovisionDataSetTableAdapters.customerTableAdapter ta = new technovisionDataSetTableAdapters.customerTableAdapter();
                technovisionDataSet.customerDataTable dt = ta.GetDataByName("%" + TxtSearchCustomer.Text + "%");
                this.GridManageCustomer.DataSource = dt;
                //"SELECT * FROM customer WHERE Name LIKE '*" + TxtSearchCustomer.Text + "*' OR Phone LIKE'*" + TxtSearchCustomer.Text + "*'";
            }
            //customerBindingSource.Filter = "Name LIKE '*" + TxtSearchCustomer.Text + "*' OR Phone LIKE'*" + TxtSearchCustomer.Text + "*'";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
            }
            catch(Exception)
            {
                CommonFunctions.ShowError(this, "No data to search...");
            }
           
        }

        private void BtnShowOrders_Click(object sender, EventArgs e)
        {
            try
            {
                new UI_SHOW_ORDER_BY_CUSTOMER(GridManageCustomer.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(GridManageCustomer.SelectedRows[0].Cells[0].Value.ToString())).Show();

            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this,ex.Message.ToString());
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearchCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
