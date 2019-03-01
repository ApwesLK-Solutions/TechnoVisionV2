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
    public partial class UI_EDIT_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        private string Id;
        public UI_EDIT_CUSTOMER(string e)
        {
            InitializeComponent();
            this.LblCustomerId.Text = e;
            this.Id = e; 
        }

        private void UI_EDIT_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
                customerBindingSource.Filter = "Id ='" + Id + "'";
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
