using System;
using TechnoVision.model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoVisionOptical.view
{
    public partial class frm_customer : MetroFramework.Forms.MetroForm
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Customer.Name = TxtName.Text;
            Customer.Address = TxtAddress.Text;
            Customer.Age = TxtAge.Text;
            Customer.Phone = TxtPhone.Text;
            Customer.Profession = TxtProfession.Text;
            Customer.Email = TxtEmail.Text;
            Customer.Branch = CmbBranch.SelectedValue.ToString();
        }

        private void frm_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.technovisionDataSet.branch);

        }
    }
}
