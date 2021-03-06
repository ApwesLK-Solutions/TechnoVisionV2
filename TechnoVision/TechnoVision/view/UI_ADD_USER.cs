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
    public partial class UI_ADD_USER : MetroFramework.Forms.MetroForm
    {
        public UI_ADD_USER()
        {
            InitializeComponent();
        }

        private void UI_ADD_USER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
                this.branchTableAdapter.Fill(this.technovisionDataSet.branch);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtUsername.Text=="" || TxtPassword.Text =="" || TxtFullName.Text=="" || TxtNic.Text=="" || TxtContactNumber.Text=="")
                {
                    CommonFunctions.ShowError(this, "All Fileds Required...");
                    CommonFunctions.WriteUserLog("SYSTEM", User.Username + " is tried to save data without filling required fields");
                }
                else if(TxtContactNumber.Text.Length !=10)
                {
                    CommonFunctions.ShowError(this, "Please Enter 10 Digits Contact Number");
                }
                else
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
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                CommonFunctions.ShowError(this,ex.ToString());
            }
            
        }

        private void TxtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
