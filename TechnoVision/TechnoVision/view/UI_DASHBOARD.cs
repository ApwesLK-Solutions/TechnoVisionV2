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
    public partial class UI_DASHBOARD : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Forms.MetroForm f;
        
        public UI_DASHBOARD(MetroFramework.Forms.MetroForm form)
        {
            InitializeComponent();
            f = form;
        }

        private void UI_DASHBOARD_Load(object sender, EventArgs e)
        {
            LblBranch.Text = Session.BranchName;
            LblUsername.Text = Session.Username;
        }

        private void BtnSpectacles_Click(object sender, EventArgs e)
        {
            new UI_SELECT_CUSTOMER("S").Show(); 
        }

        private void BtnContactLenses_Click(object sender, EventArgs e)
        {
            new UI_SELECT_CUSTOMER("L").Show(); 
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            new UI_ORDER_LIST().Show();
        }
        private void BtnManageCustomer_Click(object sender, EventArgs e)
        {
            new UI_VIEW_CUSTOMER().Show();
        }

        private void BtnManageFrames_Click(object sender, EventArgs e)
        {
            new UI_MANAGE_FRAMES().Show();
        }

        private void BtnManageTesters_Click(object sender, EventArgs e)
        {
            new UI_MANAGE_TESTERS().Show();
        }

        private void BtnManageBranches_Click(object sender, EventArgs e)
        {
            new UI_ADD_BRANCH().Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            new UI_PAYMENT_VIEWER().Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            new UI_REPORTS().Show();
        }

        private void BtnSystemUsers_Click(object sender, EventArgs e)
        {
            new UI_SELECT_OPTION_SYSTEM_USER().Show();
            
        }

        private void UI_DASHBOARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }
    }
}
