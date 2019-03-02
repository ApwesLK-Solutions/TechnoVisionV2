﻿using System;
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
        public UI_DASHBOARD()
        {
            InitializeComponent();
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
    }
}
