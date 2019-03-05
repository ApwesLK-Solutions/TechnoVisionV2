using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.model;

namespace TechnoVision.view
{
    public partial class UI_MANAGE_USER : MetroFramework.Forms.MetroForm
    {
        public UI_MANAGE_USER()
        {
            InitializeComponent();
        }

        private void UI_MANAGE_USER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.technovisionDataSet.users);
                usersBindingSource.Filter = "BranchId = " + Session.BranchId;
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this,ex.Message.ToString());
            }
            

        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                User.DeleteUser(this, GrdUser.SelectedRows[0].Cells[0].Value.ToString());
                this.usersTableAdapter.Fill(this.technovisionDataSet.users);
                CommonFunctions.WriteUserLog(Session.Username,"has change system user "+GrdUser.SelectedRows[0].Cells[0].Value.ToString() + " to DEACTIVATE status");
                CommonFunctions.ShowSuccess(this,"User Deactivated Successfully...");
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnActivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                User.ActiveUser(this, GrdUser.SelectedRows[0].Cells[0].Value.ToString());
                this.usersTableAdapter.Fill(this.technovisionDataSet.users);
                CommonFunctions.WriteUserLog(Session.Username, "has change system user " + GrdUser.SelectedRows[0].Cells[0].Value.ToString() + " to ACTIVATE status");
                CommonFunctions.ShowSuccess(this, "User Activated Successfully...");
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                new UI_EDIT_SYSTEM_USER(GrdUser.SelectedRows[0].Cells[0].Value.ToString()).Show();
            }
            catch(Exception)
            {
                CommonFunctions.ShowError(this, "No User Selected...");
            }
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                usersBindingSource.Filter = ("Nic LIKE '%" + TxtSearch.Text + "%' AND BranchId =" + Session.BranchId);
            }
            catch(Exception)
            {
                CommonFunctions.ShowError(this, "No data to search...");
            }
            
        }
    }
}
