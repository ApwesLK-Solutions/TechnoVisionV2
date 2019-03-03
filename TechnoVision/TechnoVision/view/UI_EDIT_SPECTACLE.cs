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
    public partial class UI_EDIT_SPECTACLE : MetroFramework.Forms.MetroForm
    {
        string OrderNumber;
        public UI_EDIT_SPECTACLE(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void UI_EDIT_SPECTACLE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
            this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
            spectaclesBindingSource.Filter = "OrderNumber = '" + OrderNumber + "' AND Branch = " + Session.BranchId;
            BtnSaveUser.Enabled = false;


        }

        private void TxtMasterPassword_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void TxtMasterPassword_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            spectaclesBindingSource.EndEdit();
            spectaclesTableAdapter.Update(technovisionDataSet);
            this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);

        }

        private void TxtMasterPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtMasterPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtMasterPassword.Text == Session.BranchMasterPassword)
            {
                BtnSaveUser.Enabled = true;
            }
            else if (TxtMasterPassword.Text != Session.BranchMasterPassword)
            {
                BtnSaveUser.Enabled = false;
            }
        }
    }
}
