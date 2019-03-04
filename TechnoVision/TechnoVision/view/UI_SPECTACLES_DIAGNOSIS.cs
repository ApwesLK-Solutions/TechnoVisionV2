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
    public partial class UI_SPECTACLES_DIAGNOSIS : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Forms.MetroForm form;
        public UI_SPECTACLES_DIAGNOSIS(MetroFramework.Forms.MetroForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtRightDistSph.Text=="" ||TxtRightDistCyl.Text==""|| TxtRightDistAxis.Text=="" ||TxtLeftDistSph.Text==""|| TxtLeftDistCyl.Text==""|| TxtLeftDistAxis.Text==""|| TxtRightAdd.Text==""|| TxtLeftAdd.Text==""|| TxtLenseType.Text==""|| CmbFrame.Text==""|| TxtPD.Text==""|| TxtSegmentHeight.Text==""|| TxtSpecialIns.Text==""|| TxtRemarks.Text=="")
                {
                    CommonFunctions.ShowError(this, "Please Complete All Fields to continue...If You have Empty Fileds Please put'-' into Text Area...");
                    CommonFunctions.WriteUserLog(Session.Username, "tried to continue without enter all fields");
                }
                else
                {
                    SpecOrderController.FillFormTwo(TxtRightDistSph.Text, TxtRightDistCyl.Text, TxtRightDistAxis.Text, TxtLeftDistSph.Text, TxtLeftDistCyl.Text, TxtLeftDistAxis.Text, TxtRightAdd.Text, TxtLeftAdd.Text, TxtLenseType.Text, CmbFrame.Text, TxtPD.Text, TxtSegmentHeight.Text, TxtSpecialIns.Text, TxtRemarks.Text);
                    receiptController.FillReceipt(SpecOrder.OrderNumber, SpecOrder.Advance, SpecOrder.OrderDate,"SPEC");
                    technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                    t.Insert(SpecOrder.OrderNumber, DateTime.Parse(SpecOrder.OrderDate), DateTime.Parse(SpecOrder.DueDate), SpecOrder.OrderStatus, SpecOrder.Total, SpecOrder.Advance, SpecOrder.Discount, SpecOrder.Balance, SpecOrder.TestBy, SpecOrder.Eyewear, SpecOrder.Lense, SpecOrder.PaymentPlan, SpecOrder.PaymentMethod, SpecOrder.DistRightSph, SpecOrder.DistRightCyl, SpecOrder.DistRightAxis, SpecOrder.DistLeftSph, SpecOrder.DistLeftCyl, SpecOrder.DistLeftAxis, SpecOrder.AddRight, SpecOrder.AddLeft, SpecOrder.LenseType, SpecOrder.Frame, SpecOrder.PD, SpecOrder.SegmentHeight, SpecOrder.SpecialInstruction, SpecOrder.Remarks, SpecOrder.ReminderDays, SpecOrder.Branch,DateTime.Now.ToString("yyyy"),SpecOrder.custID);
                    CommonFunctions.WriteUserLog(Session.Username, "Added New Spec Order : " + SpecOrder.OrderNumber);
                    receiptController.WriteReceipt();
                    CommonFunctions.ShowSuccess(this, "Order Number " + SpecOrder.OrderNumber + "Saved Succesfully...");
                    this.Dispose();
                    new UI_ORDER_COMPLETE("S", SpecOrder.OrderNumber, Receipt.ReceiptNumber).Show();
                    form.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
            }
        }

        private void UI_SPECTACLES_DIAGNOSIS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.frames' table. You can move, or remove it, as needed.
            this.framesTableAdapter.Fill(this.technovisionDataSet.frames);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form.Show();
        }
    }
}
