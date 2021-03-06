﻿using System;
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
                cmbYear.SelectedIndex = 0;

                // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
                //this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
                timer1.Enabled = true;
                RadioSpectacles.Checked = true;

                // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
                //this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                loadData();
                CmbSetAs.SelectedIndex = 0;

            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this,ex.Message.ToString());
            }
            

        }

        private void loadData() 
        {
            try
            {
                
                technovisionDataSetTableAdapters.spectaclesTableAdapter ta = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                technovisionDataSetTableAdapters.spec_ordersTableAdapter taa = new technovisionDataSetTableAdapters.spec_ordersTableAdapter();

                //technovisionDataSet.spectaclesDataTable dt = new technovisionDataSet.spectaclesDataTable();
                //ta.FillByYearSpectacles(dt, cmbYear.Text);
                this.SpecGrid.DataSource = taa.GetDataByYear(cmbYear.Text);
                //this.SpecGrid.DataSource = ta.GetDataByYear(cmbYear.Text);

                //load contact lenses
                technovisionDataSetTableAdapters.contactlenseTableAdapter co = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
                technovisionDataSet.contactlenseDataTable tb = new technovisionDataSet.contactlenseDataTable();
                co.FillByYearContactlenses(tb, cmbYear.Text);
                this.LenseGrid.DataSource = tb;
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
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
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    (LenseGrid.DataSource as DataTable).DefaultView.RowFilter = "Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";
                }
                else if (RadioSpectacles.Checked == true)
                {
                    (SpecGrid.DataSource as DataTable).DefaultView.RowFilter = "Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";

                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "No data to search...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
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
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnViewCustomerCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + LenseGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
                else if (RadioSpectacles.Checked == true)
                {
                    InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + SpecGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnViewCompanyCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + LenseGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
                else if (RadioSpectacles.Checked == true)
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + SpecGrid.SelectedRows[0].Cells[0].Value.ToString() + "'AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
        
        private void BtnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioContactLense.Checked == true)
                {
                    new UI_EDIT_CONTACT_LENSE(LenseGrid.SelectedRows[0].Cells[0].Value.ToString()).Show();
                    this.Dispose();
                }
                else if (RadioSpectacles.Checked == true)
                {
                    new UI_EDIT_SPECTACLE(SpecGrid.SelectedRows[0].Cells[0].Value.ToString()).Show();
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Can not Edit Order...");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void BtnViewPayments_Click(object sender, EventArgs e)
        {
            if(RadioContactLense.Checked == true)
            {
                
            }
        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            technovisionDataSetTableAdapters.spectaclesTableAdapter ta = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
            technovisionDataSet.spectaclesDataTable dt = new technovisionDataSet.spectaclesDataTable();
            ta.FillByYearSpectacles(dt, cmbYear.Text);
            this.SpecGrid.DataSource = dt;

            //load contact lenses
            technovisionDataSetTableAdapters.contactlenseTableAdapter co = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
            technovisionDataSet.contactlenseDataTable tb = new technovisionDataSet.contactlenseDataTable();
            co.FillByYearContactlenses(tb, cmbYear.Text);
            this.LenseGrid.DataSource = tb;
        }
    }
}
