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
    public partial class UI_FORGET_PASSWORD : MetroFramework.Forms.MetroForm
    {
        public UI_FORGET_PASSWORD()
        {
            InitializeComponent();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            User.UpdatePassword(this, TxtUsername.Text, TxtNewPassword.Text, TxtConfirmPassword.Text, TxtContactNumber.Text, TxtNic.Text);
        }
    }
}
