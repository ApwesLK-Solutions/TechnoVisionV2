using System;
using TechnoVision.model;

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
    public partial class UI_ADD_USER : MetroFramework.Forms.MetroForm
    {
        public UI_ADD_USER()
        {
            InitializeComponent();
        }

        private void UI_ADD_USER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.technovisionDataSet.branch);

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            User.Username = TxtUsername.Text;
            User.Password = TxtPassword.Text;
            User.FullName = TxtFullName.Text;
            User.Nic = TxtNic.Text;
            User.ContactNumber = TxtContactNumber.Text;
            User.BranchId = (int)CmbBranch.SelectedValue;
            User.RegisterNewUser(this);
        }
    }
}
