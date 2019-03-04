using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.reports;

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
            try
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
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this,ex.Message.ToString());
            }
            

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
            if(RadioContactLense.Checked == true)
            {
                contactlenseBindingSource.Filter = "Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";
            }
            else if(RadioSpectacles.Checked == true)
            {
                spectaclesBindingSource.Filter = "Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";

            }
        }

        private void BtnMarkAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioSpectacles.Checked == true)
                {
                    technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                    t.UpdateOrderStatus(CmbSetAs.Text, SpecGrid.SelectedRows[0].Cells[0].Value.ToString());
                    this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                    CommonFunctions.ShowSuccess(this, "Order status Updated to " + CmbSetAs.SelectedText + "Successfully");
                    CommonFunctions.WriteUserLog(Session.Username, "Has Updated Order Status to" + CmbSetAs.Text);
                }
                else if (RadioContactLense.Checked == true)
                {
                    technovisionDataSetTableAdapters.contactlenseTableAdapter t = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                    t.UpdateOrderStatus(CmbSetAs.Text, LenseGrid.SelectedRows[0].Cells[0].Value.ToString());
                    this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
                    CommonFunctions.ShowSuccess(this, "Order Updated to " + CmbSetAs.SelectedText + "Successfully");
                    CommonFunctions.WriteUserLog(Session.Username, "Has Updated Order Status to" + CmbSetAs.Text);
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }

        private void BtnViewCustomerCopy_Click(object sender, EventArgs e)
        {
            if(RadioContactLense.Checked == true)
            {
                InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + LenseGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND Branch =" + Session.BranchId;
                new UI_REPORT_VIEWER(rpt).Show();
            }
            else if(RadioSpectacles.Checked == true)
            {
                InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + SpecGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND Branch =" + Session.BranchId;
                new UI_REPORT_VIEWER(rpt).Show();
            }
        }

        private void BtnViewCompanyCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + LenseGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND Branch =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
                else if (RadioSpectacles.Checked == true)
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + SpecGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND Branch =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
            
        }
        
        private void BtnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    new UI_EDIT_CONTACT_LENSE(LenseGrid.SelectedRows[0].Cells[0].Value.ToString()).Show();
                }
                else if (RadioSpectacles.Checked == true)
                {
                    new UI_EDIT_SPECTACLE(SpecGrid.SelectedRows[0].Cells[0].Value.ToString()).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Can not Edit Order...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
    }
}
