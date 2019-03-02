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
    public partial class UI_ORDER_LIST : MetroFramework.Forms.MetroForm
    {
        public UI_ORDER_LIST()
        {
            InitializeComponent();
        }

        private void UI_ORDER_LIST_Load(object sender, EventArgs e)
        {
            spectaclesBindingSource.Filter = "Branch =" + Session.BranchId;
            contactlenseBindingSource.Filter = "Branch =" + Session.BranchId;
            // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
            this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
            timer1.Enabled = true;
            RadioSpectacles.Checked = true;
            // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
            this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RadioSpectacles.Checked == true)
            {
                SpecGrid.Visible = true;
                LenseGrid.Visible = false;
            }
            else if(RadioContactLense.Checked == true)
            {
                SpecGrid.Visible = false;
                LenseGrid.Visible = true;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(RadioContactLense.Checked==true)
            {
                contactlenseBindingSource.Filter += "AND OrderNumber LIKE '*" + TxtSearch.Text + "*'";
            }
            else if(RadioSpectacles.Checked ==true)
            {
                spectaclesBindingSource.Filter += "AND OrderNumber LIKE '*" + TxtSearch.Text + "*'";

            }
        }
    }
}
