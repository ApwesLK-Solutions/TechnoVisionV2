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

namespace TechnoVision.view
{
    public partial class UI_ADD_CUSTOMER : MetroFramework.Forms.MetroForm
    {
        public UI_ADD_CUSTOMER()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtCustomerName.Text =="" || TxtAddress.Text =="" || TxtAge.Text=="" || TxtContactNumber.Text =="" || TxtProffession.Text =="" || TxtEmail.Text=="" || CmbBranch.Text =="")
                {
                    CommonFunctions.ShowError(this, "Please Fill All Required Fields..");
                    CommonFunctions.WriteUserLog(Session.Username, User.Username + " Tried to save without filling all fileds");
                }
                else
                {
                    Customer.Name = TxtCustomerName.Text;
                    Customer.Address = TxtAddress.Text;
                    Customer.Age = TxtAge.Text;
                    Customer.Phone = TxtContactNumber.Text;
                    Customer.Profession = TxtProffession.Text;
                    Customer.Email = TxtEmail.Text;
                    Customer.Branch = CmbBranch.SelectedValue.ToString();
                    Customer.RegisterNewCustomer(this);
                }
                
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Can not proceed. Please try again later");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
        }

        private void UI_ADD_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
                this.branchTableAdapter.Fill(this.technovisionDataSet.branch);
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, "Can not Load Branches List. try again");
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
           

        }
    }
}
