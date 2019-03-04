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
    public partial class UI_MANAGE_TESTERS : MetroFramework.Forms.MetroForm
    {
        public UI_MANAGE_TESTERS()
        {
            InitializeComponent();
        }

        private void UI_MANAGE_TESTERS_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
                this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, "Can not Load Testers...");
            }
        }

        private void BtnAddTester_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtAddTester.Text =="")
                {
                    CommonFunctions.ShowError(this, "Please Enter Tester Name...");
                }
                else
                {
                    technovisionDataSetTableAdapters.testersTableAdapter t = new technovisionDataSetTableAdapters.testersTableAdapter();
                    t.Insert(TxtAddTester.Text);
                    this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
                    CommonFunctions.ShowSuccess(this, "New Tester Saved Successfully...");
                    CommonFunctions.WriteUserLog(Session.Username, "Added new Tester" + TxtAddTester.Text);
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnDeleteTester_Click(object sender, EventArgs e)
        {
            try
            {
                technovisionDataSetTableAdapters.testersTableAdapter t = new technovisionDataSetTableAdapters.testersTableAdapter();
                t.DeleteById(int.Parse(GridTesters.SelectedRows[0].Cells[0].Value.ToString()));
                this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Nothing To Delete Or Not Selected...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowSuccess(this, "Tester Deleted Successfully...");
                CommonFunctions.WriteUserLog(Session.Username, "Deleted Tester" + GridTesters.SelectedRows[0].Cells[1].Value.ToString());
            }
            

        }
    }
}
