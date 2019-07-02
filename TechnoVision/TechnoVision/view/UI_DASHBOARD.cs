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
using System.Data.SqlClient;
using System.IO;
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
            f.ShowInTaskbar = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string branch = "D:/TechnoVision/Backups/Branch.csv";
                string contactlense = "D:/TechnoVision/Backups/contactlense.csv";
                string customer = "D:/TechnoVision/Backups/customer.csv";
                string frames = "D:/TechnoVision/Backups/frames.csv";
                string logs = "D:/TechnoVision/Backups/logs.csv";
                string receipt = "D:/TechnoVision/Backups/receipt.csv";
                string spectacles = "D:/TechnoVision/Backups/spectacles.csv";
                string testers = "D:/TechnoVision/Backups/testers.csv";
                string users = "D:/TechnoVision/Backups/users.csv";
                string zipfile = "D:/TechnoVision/Backups/Backups.zip";
                if (File.Exists(branch))
                {
                    File.Delete(branch);
                }
                if (File.Exists(contactlense))
                {
                    File.Delete(contactlense);
                }
                if (File.Exists(customer))
                {
                    File.Delete(customer);
                }
                if (File.Exists(frames))
                {
                    File.Delete(frames);
                }
                if (File.Exists(logs))
                {
                    File.Delete(logs);
                }
                if (File.Exists(receipt))
                {
                    File.Delete(receipt);
                }
                if (File.Exists(spectacles))
                {
                    File.Delete(spectacles);
                }
                if (File.Exists(testers))
                {
                    File.Delete(testers);
                }
                if (File.Exists(users))
                {
                    File.Delete(users);
                }
                technovisionDataSetTableAdapters.QueriesTableAdapter t = new technovisionDataSetTableAdapters.QueriesTableAdapter();
                t.Backup();

                File.SetAttributes(branch, FileAttributes.Hidden);
                File.SetAttributes(contactlense, FileAttributes.Hidden);
                File.SetAttributes(customer, FileAttributes.Hidden);
                File.SetAttributes(frames, FileAttributes.Hidden);
                File.SetAttributes(logs, FileAttributes.Hidden);
                File.SetAttributes(receipt, FileAttributes.Hidden);
                File.SetAttributes(spectacles, FileAttributes.Hidden);
                File.SetAttributes(testers, FileAttributes.Hidden);
                File.SetAttributes(users, FileAttributes.Hidden);

                CommonFunctions.ShowSuccess(this,"successfully backup Data");
               
               /* ICSharpCode.SharpZipLib.Zip.ZipFile zip = new ICSharpCode.SharpZipLib.Zip.ZipFile(zipfile);

                zip.Password = "BACKUP@TECHNOVISION";
                zip.BeginUpdate();
                zip.SetComment(DateTime.Now.ToString());

                zip.Delete("branch.csv");
                zip.Delete("contactlense.csv");
                zip.Delete("customer.csv");
                zip.Delete("frames.csv");
                zip.Delete("logs.csv");
                zip.Delete("receipt.csv");
                zip.Delete("spectacles.csv");
                zip.Delete("testers.csv");
                zip.Delete("users.csv");


                zip.Add(branch);
                zip.Add(contactlense);
                zip.Add(customer);
                zip.Add(frames);
                zip.Add(logs);
                zip.Add(receipt);
                zip.Add(spectacles);
                zip.Add(testers);
                zip.Add(users);
                zip.CommitUpdate();

               
             
                zip.Close();
                MessageBox.Show("Done");
                /*File.Delete(branch);
                File.Delete(contactlense);
                File.Delete(customer);
                File.Delete(frames);
                File.Delete(logs);
                File.Delete(receipt);
                File.Delete(spectacles);
                File.Delete(testers);
                File.Delete(users);*/
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.ToString());
            }
           
            
            
        }

        private void UI_DASHBOARD_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
