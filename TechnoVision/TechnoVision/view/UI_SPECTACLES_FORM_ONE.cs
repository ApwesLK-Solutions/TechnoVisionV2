using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.controller;
using TechnoVision.model;
namespace TechnoVision.view
{
    public partial class UI_SPECTACLES_FORM_ONE : MetroFramework.Forms.MetroForm
    {
        public UI_SPECTACLES_FORM_ONE()
        {
            InitializeComponent();
        }

        private void UI_SPECTACLES_FORM_ONE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.testers' table. You can move, or remove it, as needed.
            this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
            DateOrderDate.Value = DateTime.UtcNow;
            DateDueDate.Value = DateTime.UtcNow;
            CmbOrderStatus.SelectedIndex = 0;
            CmbPaymentMethod.SelectedIndex = 0;
            CmbPaymentPlan.SelectedIndex = 0;
            //CmbTestedBy.SelectedIndex = 0;
            showReceiptNumber();     
            TxtOrderNo.Text = getOrderNumber();
        }
        private string getOrderNumber()
        {
            try
            {
                string LastOrderNumber;
                string NewOrderNumber;
                technovisionDataSetTableAdapters.spectaclesTableAdapter table = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                try
                {
                    LastOrderNumber = table.GetMaxOrderNumber(Session.BranchId).ToString();
                    NewOrderNumber = (int.Parse(LastOrderNumber) + 1).ToString();
                }
                catch (NullReferenceException ex)
                {
                    NewOrderNumber = DateTime.Now.ToString("yy") + "0001";
                }
                return NewOrderNumber;
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
                return null;
            }
        }
        private void showReceiptNumber()
        {
            technovisionDataSetTableAdapters.receiptTableAdapter t = new technovisionDataSetTableAdapters.receiptTableAdapter();
            string rno;
            string newRno;
            try
            {
                rno = t.getReceiptNumberByBranch(Session.BranchId).ToString();
                newRno = (int.Parse(rno) + 1).ToString();
            }
            catch (NullReferenceException ex)
            {
                newRno = "1";
            }
            LblReceiptNo.Text = newRno;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtOrderNo.Text=="" || TxtAdvance.Text=="" || TxtBalance.Text =="" || TxtDiscount.Text=="" || TxtEyeWearAmount.Text =="" || TxtLenseAmount.Text=="" ||TxtRemindDays.Text ==""||TxtTotal.Text=="" || CmbOrderStatus.Text =="" || CmbPaymentMethod.Text =="" || CmbPaymentPlan.Text =="" || CmbTestedBy.Text=="")
                {
                    CommonFunctions.ShowError(this, "Please Complete All Fields to continue...");
                    CommonFunctions.WriteUserLog(Session.Username, "tried to continue without enter all fields");
                }
                else
                {
                    SpecOrderController.FillFormOne(TxtOrderNo.Text,DateOrderDate.Value.ToString("yyyy-MM-dd"),DateDueDate.Value.ToString("yyyy-MM-dd"),CmbPaymentPlan.Text,CmbPaymentMethod.Text,CmbTestedBy.Text,CmbOrderStatus.Text,Double.Parse(TxtEyeWearAmount.Text),Double.Parse(TxtLenseAmount.Text),Double.Parse(TxtTotal.Text),Double.Parse(TxtAdvance.Text),Double.Parse(TxtDiscount.Text),Double.Parse(TxtBalance.Text),int.Parse(TxtRemindDays.Text));
                    new UI_SPECTACLES_DIAGNOSIS(this).Show();
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }
    }
}
