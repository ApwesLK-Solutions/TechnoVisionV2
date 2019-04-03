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
    public partial class UI_SHOW_ORDER_BY_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        int custID;
        string CustName;
        public UI_SHOW_ORDER_BY_CUSTOMER(string custName , int custID)
        {
            InitializeComponent();
            this.custID = custID;
            this.CustName = custName;
        }

        private void UI_SHOW_ORDER_BY_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                RadioSpectacles.Checked = true;
                // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
                this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
                this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);
                contactlenseBindingSource.Filter = "CustomerId = " + custID;
                spectaclesBindingSource.Filter = "CustomerId = " + custID;
                LblCustomerName.Text = CustName;
                BtnMakeAdvance.Visible = false;
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RadioSpectacles.Checked == true)
            {
                GridContactLense.Visible = false;
                GridSpectacle.Visible = true;
            }
            else if(RadioContactLense.Checked == true)
            {
                GridContactLense.Visible = true;
                GridSpectacle.Visible = false;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (RadioContactLense.Checked == true)
            {
                contactlenseBindingSource.Filter ="CustomerId = " + custID + " AND Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";
            }
            else if (RadioSpectacles.Checked == true)
            {
                spectaclesBindingSource.Filter = "CustomerId = " + custID + " AND Branch =" + Session.BranchId + "AND OrderNumber LIKE '%" + TxtSearch.Text + "%'";
            }
        }

        private void BtnPrintCompanyCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioSpectacles.Checked == true)
                {
                    InvoiceSpecCompany rpt = new InvoiceSpecCompany();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + GridSpectacle.SelectedRows[0].Cells[1].Value.ToString() + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
                else if (RadioContactLense.Checked == true)
                {
                    InvoiceLenseCompany rpt = new InvoiceLenseCompany();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + GridContactLense.SelectedRows[0].Cells[1].Value.ToString() + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
            }
            catch (Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
        }

        private void BtnPrintCustomerCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioSpectacles.Checked == true)
                {
                    InvoiceSpecCustomer rpt = new InvoiceSpecCustomer();
                    rpt.RecordSelectionFormula = "{spectacles1.OrderNumber} ='" + GridSpectacle.SelectedRows[0].Cells[1].Value.ToString() + "' AND {spectacles1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
                else if (RadioContactLense.Checked == true)
                {
                    InvoiceLenseCustomer rpt = new InvoiceLenseCustomer();
                    rpt.RecordSelectionFormula = "{contactlense1.OrderNumber} = '" + GridContactLense.SelectedRows[0].Cells[1].Value.ToString() + "' AND {contactlense1.Branch} =" + Session.BranchId;
                    new UI_REPORT_VIEWER(rpt).Show();
                    rpt.PrintToPrinter(1, false, 1, 1);
                }
            }
            catch (Exception ex)
            {
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
        }

       

        private void BtnMakeAdvance_Click(object sender, EventArgs e)
        {
            try
            {
                if(RadioSpectacles.Checked == true)
                {
                    new UI_ADD_ADVANCE(GridSpectacle.SelectedRows[0].Cells[1].Value.ToString(), "SPEC", int.Parse(GridSpectacle.SelectedRows[0].Cells[30].Value.ToString())).Show();
                }
                else if(RadioContactLense.Checked == true)
                {
                    new UI_ADD_ADVANCE(GridContactLense.SelectedRows[0].Cells[1].Value.ToString(),"LENSE", int.Parse(GridContactLense.SelectedRows[0].Cells[46].Value.ToString())).Show();
                }
               
            }
            catch (Exception ex)
            {
                CommonFunctions.ShowError(this, "No payemnts to Select ");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }

        }

        private void GridContactLense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridContactLense.SelectedRows[0].Cells[8].Value.ToString() == "0")
            {
                BtnMakeAdvance.Visible = true;
            }
            else
            {
                BtnMakeAdvance.Visible = false;
            }
        }

        private void GridSpectacle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridSpectacle.SelectedRows[0].Cells[6].Value.ToString() == "0")
            {
                BtnMakeAdvance.Visible = true;
            }
            else
            {
                BtnMakeAdvance.Visible = false;
            }
        }
    }
}
