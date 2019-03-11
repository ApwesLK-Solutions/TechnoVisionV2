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
using TechnoVision;


namespace TechnoVision.view
{
    public partial class UI_LOGIN : MetroFramework.Forms.MetroForm
    {
        public UI_LOGIN()
        {
            InitializeComponent();
        }

        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            User.Username = TxtUsername.Text;
            User.Password = TxtPassword.Text;
            User.login(this);
            TxtPassword.Text = "";
        }

        private void BtnForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UI_FORGET_PASSWORD().Show();
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void UI_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
