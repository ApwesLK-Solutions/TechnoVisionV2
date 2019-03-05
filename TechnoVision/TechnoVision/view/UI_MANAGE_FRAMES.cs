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
    public partial class UI_MANAGE_FRAMES : MetroFramework.Forms.MetroForm
    {
        public UI_MANAGE_FRAMES()
        {
            InitializeComponent();
        }

        private void UI_MANAGE_FRAMES_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO: This line of code loads data into the 'technovisionDataSet.frames' table.You can move, or remove it, as needed.
            this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Can not Load Frames");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }

        }

        private void BtnAddFrame_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtAddFrame.Text =="")
                {
                    CommonFunctions.ShowError(this, "Please Enter Value In Textbox...");
                }
                else
                {
                    technovisionDataSetTableAdapters.framesTableAdapter t = new technovisionDataSetTableAdapters.framesTableAdapter();
                    t.Insert(TxtAddFrame.Text);
                    this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
                    CommonFunctions.ShowSuccess(this, "New Frame Saved Successfully...");
                    CommonFunctions.WriteUserLog(Session.Username, "Added new Frame" + TxtAddFrame.Text);
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnDeleteFrame_Click(object sender, EventArgs e)
        {
            try
            {
                technovisionDataSetTableAdapters.framesTableAdapter t = new technovisionDataSetTableAdapters.framesTableAdapter();
                t.DeleteByID(int.Parse(GridFrame.SelectedRows[0].Cells[0].Value.ToString()));
                this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
                CommonFunctions.WriteUserLog(Session.Username, "Deleted Frame" + GridFrame.SelectedRows[0].Cells[1].Value.ToString());
                CommonFunctions.ShowSuccess(this, "Frame Deleted Successfully...");
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Nothing To Delete Or Not Selected...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                framesBindingSource.Filter = ("FrameName LIKE '%" + TxtSearch.Text + "%'");
            }
            catch(Exception)
            {
                CommonFunctions.ShowError(this, "No data to search...");
            }
           
        }
    }
}
