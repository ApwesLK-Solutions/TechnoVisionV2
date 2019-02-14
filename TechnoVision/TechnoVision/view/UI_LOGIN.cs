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
            MessageBox.Show(TxtUsername.Text);
            User.Username = TxtUsername.Text;
            User.Password = TxtPassword.Text;
            User.login(this);
        }
    }
}
