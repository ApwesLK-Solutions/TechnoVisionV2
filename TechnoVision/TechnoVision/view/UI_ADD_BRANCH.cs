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
            // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.technovisionDataSet.branch);

        }

        private void BtnAddBranch_Click(object sender, EventArgs e)
        {
            //cover with try
            technovisionDataSetTableAdapters.branchTableAdapter t = new technovisionDataSetTableAdapters.branchTableAdapter();
            t.Insert(TxtBranchName.Text, TxtMasterPassword.Text);
        }
    }
}
