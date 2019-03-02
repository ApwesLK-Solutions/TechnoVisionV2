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
    public partial class UI_ADD_BRANCH : MetroFramework.Forms.MetroForm
    {
        public UI_ADD_BRANCH()
        {
            InitializeComponent();
        }

        private void UI_ADD_BRANCH_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
                this.branchTableAdapter.Fill(this.technovisionDataSet.branch);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this,"Can not Load Branches List...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            

        }

        private void BtnAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                technovisionDataSetTableAdapters.branchTableAdapter t = new technovisionDataSetTableAdapters.branchTableAdapter();
                t.Insert(TxtBranchName.Text, TxtMasterPassword.Text);
                CommonFunctions.ShowSuccess(this, "New Branch Added Successfully...");
                this.branchTableAdapter.Fill(this.technovisionDataSet.branch);

            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
    }
}
