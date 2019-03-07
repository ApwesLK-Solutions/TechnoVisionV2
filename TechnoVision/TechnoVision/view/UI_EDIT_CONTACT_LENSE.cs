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
    public partial class UI_EDIT_CONTACT_LENSE : MetroFramework.Forms.MetroForm
    {
        string OrderNumber;
        double total = 0;
        double discount = 0;
        double advance = 0;
        double balance = 0;
        public UI_EDIT_CONTACT_LENSE(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void UI_EDIT_CONTACT_LENSE_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
                this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
                contactlenseBindingSource.Filter = "OrderNumber = '" + OrderNumber + "' AND Branch =" + Session.BranchId;
                BtnSave.Enabled = false;
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());

            }
            

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                contactlenseBindingSource.EndEdit();
                contactlenseTableAdapter.Update(technovisionDataSet);
                this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
                CommonFunctions.WriteUserLog(Session.Username, "Edited order number" + TxtOrderNo + "...Critical");
                CommonFunctions.ShowSuccess(this, "Successfully Changed edit Details...");
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void TxtMasterPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtMasterPassword.Text == Session.BranchMasterPassword)
            {
                BtnSave.Enabled = true;
            }
            else if (TxtMasterPassword.Text != Session.BranchMasterPassword)
            {
                BtnSave.Enabled = false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if(TxtLensesTotal.Text=="")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtLensesTotal.Text = "0";
            }
            else if(TxtDiscount.Text=="")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtDiscount.Text = "0";
            }
            else if(TxtAdvance.Text=="")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtAdvance.Text = "0";
            }
            else
            {
                total = Double.Parse(TxtLensesTotal.Text);
                discount = Double.Parse(TxtDiscount.Text);
                advance = Double.Parse(TxtAdvance.Text);

                balance = (total) - (discount) - (advance);
                TxtBalance.Text = balance.ToString();
            }
            
        }

        private void TxtLensesTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
