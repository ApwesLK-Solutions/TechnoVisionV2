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
            DateOrderDate.Value = DateTime.UtcNow;
            DateDueDate.Value = DateTime.UtcNow;
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
            //SpecOrderController.FillFormOne(); fill this
            new UI_SPECTACLES_DIAGNOSIS(this).Show();
        }
    }
}
