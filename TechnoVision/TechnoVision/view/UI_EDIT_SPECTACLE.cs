using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TechnoVision.technovisionDataSetTableAdapters;

namespace TechnoVision.view
{
    public partial class UI_EDIT_SPECTACLE : MetroFramework.Forms.MetroForm
    {
        string OrderNumber;
        double EyeWearAmount = 0;
        double LenseAmount = 0;
        double total = 0;
        double discount = 0;
        double advance = 0;
        double balance = 0;
        public UI_EDIT_SPECTACLE(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void UI_EDIT_SPECTACLE_Load(object sender, EventArgs e)
        {
            

            try
            {
                this.testersTableAdapter.Fill(this.technovisionDataSet.testers);
                this.framesTableAdapter.Fill(this.technovisionDataSet.frames);
                // TODO: This line of code loads data into the 'technovisionDataSet.spectacles' table. You can move, or remove it, as needed.
                this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                spectaclesBindingSource.Filter = "OrderNumber = '" + OrderNumber + "' AND Branch = " + Session.BranchId;
                BtnSaveUser.Enabled = false;
                testedBy.Text = CmbTestedBy.Text;
                frame.Text = CmbFrame.Text;
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(this,ex.Message.ToString());
            }
            


        }
        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAdvance.Text == "" || TxtDiscount.Text == "" || TxtTotal.Text == "")
                {
                    CommonFunctions.ShowError(this, "Fields cannot be empty");
                }
                else
                {
                    //technovisionDataSet.receiptDataTable receiptT = new technovisionDataSet.receiptDataTable();
                    technovisionDataSetTableAdapters.receiptTableAdapter tt = new receiptTableAdapter();
                    if(int.Parse(tt.getReceiptCountByOrder(TxtOrderNo.Text, "SPEC").ToString()) == 0 || int.Parse(tt.getReceiptCountByOrder(TxtOrderNo.Text, "SPEC").ToString()) >=2)
                    {
                        CommonFunctions.ShowError(this, "You can not update the 'PAYMENT DETAILS' because there is two or more payments to this order. You can only update order when there was one payment.But Other details such as Diognosis Details, other Order details Except Payment Details will update as normally...");
                        spectaclesBindingSource.EndEdit();
                        spectaclesTableAdapter.Update(technovisionDataSet);
                        this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                        CommonFunctions.ShowSuccess(this, "Successfully Changed Diognosis Details and other Order details...");
                        CommonFunctions.WriteUserLog(Session.Username, "Edited order number" + TxtOrderNo.Text + "...Critical");
                        new UI_ORDER_LIST().Show();
                        this.Dispose();
                    }
                    else if(int.Parse(tt.getReceiptCountByOrder(TxtOrderNo.Text,"SPEC").ToString()) == 1)
                    {
                        tt.UpdatePaymentAmountByOrder(double.Parse(TxtAdvance.Text),TxtOrderNo.Text,"SPEC");
                        spectaclesBindingSource.EndEdit();
                        spectaclesTableAdapter.Update(technovisionDataSet);
                        this.spectaclesTableAdapter.Fill(this.technovisionDataSet.spectacles);
                        CommonFunctions.ShowSuccess(this, "Successfully Changed edit Details...");
                        CommonFunctions.WriteUserLog(Session.Username, "Edited order number" + TxtOrderNo.Text + "...Critical");
                        new UI_ORDER_LIST().Show();
                        this.Dispose();
                    }
                    
                }

            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Error occurred. error - "+ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
        }
        
        private void TxtMasterPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtMasterPassword.Text == Session.BranchMasterPassword)
            {
                BtnSaveUser.Enabled = true;
            }
            else if (TxtMasterPassword.Text != Session.BranchMasterPassword)
            {
                BtnSaveUser.Enabled = false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (TxtAdvance.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtAdvance.Text = "0";
            }
            else if(TxtDiscount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtDiscount.Text = "0";
            }
            else if(TxtEyeWearAmount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtEyeWearAmount.Text = "0";
            }
            else if(TxtLenseAmount.Text == "")
            {
                CommonFunctions.ShowError(this, " Amounts Can not be Null. please Enter Valid Amount");
                TxtLenseAmount.Text = "0";
            }
            
            else
            {
                

                EyeWearAmount = Double.Parse(TxtEyeWearAmount.Text);
                LenseAmount = Double.Parse(TxtLenseAmount.Text);
                total = Double.Parse(TxtDiscount.Text);
                discount = Double.Parse(TxtDiscount.Text);
                advance = Double.Parse(TxtAdvance.Text);
                balance = Double.Parse(TxtBalance.Text);

                total = (EyeWearAmount + LenseAmount);
                TxtTotal.Text = total.ToString();
                balance = (total - discount - advance);
                TxtBalance.Text = balance.ToString();
            }
            
        }

        private void TxtEyeWearAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtLenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CmbTestedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void testedBy_TextChanged(object sender, EventArgs e)
        {
            CmbTestedBy.Text = testedBy.Text;
        }

        private void frame_TextChanged(object sender, EventArgs e)
        {
            CmbFrame.Text = frame.Text;
        }

        private void UI_EDIT_SPECTACLE_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UI_ORDER_LIST().Show();
        }
    }
}
