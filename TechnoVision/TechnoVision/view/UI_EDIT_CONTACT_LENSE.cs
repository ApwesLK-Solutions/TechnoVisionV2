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
        public UI_EDIT_CONTACT_LENSE(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void UI_EDIT_CONTACT_LENSE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
            this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
            contactlenseBindingSource.Filter = "OrderNumber = '" + OrderNumber +"' AND Branch =" + Session.BranchId;
            BtnSave.Enabled = false;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            contactlenseBindingSource.EndEdit();
            contactlenseTableAdapter.Update(technovisionDataSet);
            this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
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
    }
}
