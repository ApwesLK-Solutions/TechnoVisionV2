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
        public UI_SELECT_CUSTOMER()
        {
            InitializeComponent();
        }

        private void UI_SELECT_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this,"CancelButton not Load Customer List");
            }
            

        }

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            customerBindingSource.Filter = "Name LIKE '*" + TxtSearchCustomer.Text + "*' OR Phone LIKE'*" + TxtSearchCustomer.Text + "*'";
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            new UI_ADD_CUSTOMER().Show();
            new UI_ADD_CUSTOMER().BringToFront();
        }
    }
}
