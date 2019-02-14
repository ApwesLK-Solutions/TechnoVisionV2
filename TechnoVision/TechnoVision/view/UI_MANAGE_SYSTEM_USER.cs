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
    public partial class UI_MANAGE_SYSTEM_USER : MetroFramework.Forms.MetroForm
    {
        public UI_MANAGE_SYSTEM_USER()
        {
            InitializeComponent();
        }

        private void UI_MANAGE_SYSTEM_USER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.technovisionDataSet.users);

        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            User.DeleteUser(this, UserGrid.SelectedRows[0].Cells[0].Value.ToString());
            this.usersTableAdapter.Fill(this.technovisionDataSet.users);
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            new UI_EDIT_SYSTEM_USER(UserGrid.SelectedRows[0].Cells[0].Value.ToString()).Show();
        }
    }
}
