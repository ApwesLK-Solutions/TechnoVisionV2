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
            // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
            BtnSave.Enabled = false;
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.technovisionDataSet.customer);
                customerBindingSource.Filter = "Id = '" + Id +"'";
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(technovisionDataSet);
                CommonFunctions.ShowSuccess(this, "Customer Details Edited Successfully...");
                CommonFunctions.WriteUserLog(Session.Username, "has changed dtails of customer " + LblCustomerId);
                this.Dispose();
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                CommonFunctions.ShowError(this, "Customer Details Can not be Edited...");
            }

        }

        private void TxtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtMasterPassword_TextChanged(object sender, EventArgs e)
        {
            if(TxtMasterPassword.Text == Session.BranchMasterPassword)
            {
                BtnSave.Enabled = true;
            }
            else
            {
                BtnSave.Enabled = false;
            }
        }
    }
}
