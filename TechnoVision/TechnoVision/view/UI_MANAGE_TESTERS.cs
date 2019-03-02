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
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);

        }

        private void BtnAddTester_Click(object sender, EventArgs e)
        {
            technovisionDataSetTableAdapters.testersTableAdapter t = new technovisionDataSetTableAdapters.testersTableAdapter();
            t.Insert(TxtAddTester.Text);
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
        }

        private void BtnDeleteTester_Click(object sender, EventArgs e)
        {
            technovisionDataSetTableAdapters.testersTableAdapter t = new technovisionDataSetTableAdapters.testersTableAdapter();
            t.DeleteById(int.Parse(GridTesters.SelectedRows[0].Cells[0].Value.ToString()));
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);

        }
    }
}
