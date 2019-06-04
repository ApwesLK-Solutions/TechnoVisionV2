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
    public partial class UI_PAYMENT_VIEWER : MetroFramework.Forms.MetroForm
    {
        technovisionDataSetTableAdapters.customerTableAdapter cust = new technovisionDataSetTableAdapters.customerTableAdapter();
        technovisionDataSetTableAdapters.spectaclesTableAdapter spec = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
        technovisionDataSetTableAdapters.contactlenseTableAdapter lense = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
        string ordertype;
        string orderNumber;

        string T_OrderNumber;
        string T_OrderType;
        int T_CustID;
        public UI_PAYMENT_VIEWER()
        {
            InitializeComponent();

        }

        private void UI_PAYMENT_VIEWER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.receipt' table. You can move, or remove it, as needed.
                this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);
                receiptBindingSource.Filter = "Branch = " + Session.BranchId;

                LblCustomer.Text = cust.FindNameById(int.Parse(GridPayment.SelectedRows[0].Cells[8].Value.ToString())).ToString();
                getAmounts();
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, "Can not Load or No Data to Load ");

            }

        }

        private void GridPayment_Click(object sender, EventArgs e)
        {
            try
            {
                LblCustomer.Text = cust.FindNameById(int.Parse(GridPayment.SelectedRows[0].Cells[8].Value.ToString())).ToString();
                T_OrderNumber = GridPayment.SelectedRows[0].Cells[1].Value.ToString();
                T_OrderType = GridPayment.SelectedRows[0].Cells[4].Value.ToString();
                T_CustID = int.Parse(GridPayment.SelectedRows[0].Cells[8].Value.ToString());
                getAmounts();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "No payemnts to Select ");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
           
        }

        private void getAmounts()
        {
            try
            {
                ordertype = GridPayment.SelectedRows[0].Cells[4].Value.ToString();
                orderNumber = GridPayment.SelectedRows[0].Cells[1].Value.ToString();
               
                if (ordertype == "SPEC")
                {
                    LblDue.Text = spec.FindBalanceByOrderNumber(orderNumber).ToString();
                    LblTotal.Text = spec.FindTotalByOrderNumber(orderNumber).ToString();
                }
                else if (ordertype == "LENSE")
                {
                    LblDue.Text = lense.FindBalanceByOrderNumber(orderNumber).ToString();
                    LblTotal.Text = lense.FindTotalByOrderNumber(orderNumber).ToString();
                }
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, "Can not Load Customer Name or Due amount or No Data to Load ");

            }

        }

        private void BtnNewPayment_Click(object sender, EventArgs e)
        {
            try
            {
                new UI_ADD_NEW_PAYMENT(T_OrderNumber, T_OrderType, T_CustID).Show();
                this.Dispose();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "No payemnts to Select ");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }


        private void TxtReceiptSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                receiptBindingSource.Filter = "ReceiptNumber LIKE '%" + TxtReceiptSearch.Text + "%' OR OrderNumber LIKE '%" + TxtReceiptSearch.Text + "%' AND Branch = " + Session.BranchId;

            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this, ex.Message.ToString());
            }
        }
        
        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            string OrderType = GridPayment.SelectedRows[0].Cells[4].Value.ToString();
            string ReceiptNumber = GridPayment.SelectedRows[0].Cells[2].Value.ToString();

            if (OrderType == "LENSE")
            {
                InvReceiptContactLense rpt = new InvReceiptContactLense();
                rpt.RecordSelectionFormula = "{receipt1.ReceiptNumber} ='" + ReceiptNumber + "'";
                rpt.PrintToPrinter(1, false, 1, 1);
                new UI_REPORT_VIEWER(rpt).Show();
                rpt.PrintToPrinter(1, false, 1, 1);
            }
            else if(OrderType == "SPEC")
            {
                InvReceipt rpt = new InvReceipt();
                rpt.RecordSelectionFormula = "{receipt1.ReceiptNumber} ='" + ReceiptNumber + "'";
                rpt.PrintToPrinter(1, false, 1, 1);
                new UI_REPORT_VIEWER(rpt).Show();
                rpt.PrintToPrinter(1, false, 1, 1);


            }

        }

        private void GridPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LblCustomer.Text = cust.FindNameById(int.Parse(GridPayment.SelectedRows[0].Cells[8].Value.ToString())).ToString();
                T_OrderNumber = GridPayment.SelectedRows[0].Cells[1].Value.ToString();
                T_OrderType = GridPayment.SelectedRows[0].Cells[4].Value.ToString();
                T_CustID = int.Parse(GridPayment.SelectedRows[0].Cells[8].Value.ToString());
                getAmounts();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "No payemnts to Select ");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
    }
}
