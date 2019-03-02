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
            // TODO: This line of code loads data into the 'technovisionDataSet.frames' table. You can move, or remove it, as needed.
            this.framesTableAdapter.Fill(this.technovisionDataSet.frames);

        }

        private void BtnAddFrame_Click(object sender, EventArgs e)
        {
            technovisionDataSetTableAdapters.framesTableAdapter t = new technovisionDataSetTableAdapters.framesTableAdapter();
            t.Insert(TxtAddFrame.Text);
            this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
        }

        private void BtnDeleteFrame_Click(object sender, EventArgs e)
        {
            technovisionDataSetTableAdapters.framesTableAdapter t = new technovisionDataSetTableAdapters.framesTableAdapter();
            t.DeleteByID(int.Parse(GridFrame.SelectedRows[0].Cells[0].Value.ToString()));
            this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            framesBindingSource.Filter = ("FrameName LIKE '%" + TxtSearch.Text + "%'");
        }
    }
}
