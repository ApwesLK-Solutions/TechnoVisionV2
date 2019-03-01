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
                
                //SpecOrderController.FillFormTwo();fill this
                receiptController.FillReceipt(int.Parse(SpecOrder.OrderNumber), SpecOrder.Advance, SpecOrder.OrderDate);
                technovisionDataSetTableAdapters.spectaclesTableAdapter t = new technovisionDataSetTableAdapters.spectaclesTableAdapter();
                
                //t.Insert();fillthis
                CommonFunctions.WriteUserLog(Session.Username, "Added New Spec Order : " + SpecOrder.OrderNumber);
                receiptController.WriteReceipt();
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message);
            }
        }

        private void UI_SPECTACLES_DIAGNOSIS_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form.Show();
        }
    }
}
