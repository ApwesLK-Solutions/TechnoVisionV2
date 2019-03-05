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
    public partial class UI_SELECT_OPTION_SYSTEM_USER : MetroFramework.Forms.MetroForm
    {
        public UI_SELECT_OPTION_SYSTEM_USER()
        {
            InitializeComponent();
        }

        private void BtnAddSystemUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new UI_ADD_USER().Show();
        }

        private void BtnEditSystemUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new UI_MANAGE_USER().Show();
        }
    }
}
