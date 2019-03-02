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
    public partial class UI_EDIT_SYSTEM_USER : MetroFramework.Forms.MetroForm
    {
        private string username;
        public UI_EDIT_SYSTEM_USER(string e)
        {
            InitializeComponent();
            this.username = e;
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(technovisionDataSet);
            CommonFunctions.WriteUserLog(Session.Username, "Changed the Password of " + username);
        }

        private void UI_EDIT_SYSTEM_USER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.technovisionDataSet.users);
            usersBindingSource.Filter = "username = '" + username + "'";
        }

        private void TmrMasterPassword_Tick(object sender, EventArgs e)
        {
            if(TxtMasterPassword.Text == Session.BranchMasterPassword)
            {
                BtnEditUser.Enabled = true;
            }
            else
            {
                BtnEditUser.Enabled = false;
            }
        }
    }
}
