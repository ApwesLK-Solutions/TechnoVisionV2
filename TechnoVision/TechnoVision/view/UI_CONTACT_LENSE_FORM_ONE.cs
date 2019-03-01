using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.model;
using TechnoVision.controller;

namespace TechnoVision.view
{
    public partial class UI_CONTACT_LENSE_FORM_ONE : MetroFramework.Forms.MetroForm
    {
        public UI_CONTACT_LENSE_FORM_ONE()
        {
            InitializeComponent();
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                LenseOrderController.FillFormOne(TxtOrderNo.Text, DateOrderDate.Value.ToString("yy-MM-dd"), DateDueDate.Value.ToString("yy-MM-dd"), CmbTestedBy.Text, CmbOrderStatus.Text, Double.Parse(TxtLensesTotal.Text), Double.Parse(TxtAdvance.Text), Double.Parse(TxtDiscount.Text), Double.Parse(TxtBalance.Text), CmbPaymentMethod.Text, CmbPaymentPlan.Text, int.Parse(TxtRemindDays.Text));
            }
            catch(Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
            
        }

        private void UI_CONTACT_LENSE_FORM_ONE_Load(object sender, EventArgs e)
        {
            TxtOrderNo.Text = getOrderNumber();
        }

        private string getOrderNumber()
        {
            try
            {
                string LastOrderNumber;
                string NewOrderNumber;
                technovisionDataSetTableAdapters.contactlenseTableAdapter table = new technovisionDataSetTableAdapters.contactlenseTableAdapter();
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
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
