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
    public partial class UI_MANAGE_USER : MetroFramework.Forms.MetroForm
    {
        public UI_MANAGE_USER()
        {
            InitializeComponent();
        }

        private void UI_MANAGE_USER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.technovisionDataSet.users);

        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            model.User.DeleteUser(this, GrdUser.SelectedRows[0].Cells[0].Value.ToString());
            this.usersTableAdapter.Fill(this.technovisionDataSet.users);
        }
    }
}
