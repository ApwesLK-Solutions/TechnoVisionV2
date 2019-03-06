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
    public partial class UI_ADD_NEW_PAYMENT : MetroFramework.Forms.MetroForm
    {
        string orderNumber;
        string orderType;
        int custID;
        public UI_ADD_NEW_PAYMENT(string orderNumber , string orderType , int custID)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.custID = custID;
        }

        private void UI_ADD_NEW_PAYMENT_Load(object sender, EventArgs e)
        {
            LblOrderNumber.Text = orderNumber;
            showReceiptNumber();
        }
        private void showReceiptNumber()
        {
            technovisionDataSetTableAdapters.receiptTableAdapter t = new technovisionDataSetTableAdapters.receiptTableAdapter();
            string rno;
            string newRno;
            try
            {
                rno = t.getReceiptNumberByBranch(Session.BranchId, DateTime.Now.ToString("yyyy")).ToString();
                MessageBox.Show(rno);
                string BranchCharacter = rno.Substring(0, 1);
                MessageBox.Show(rno);
                MessageBox.Show(BranchCharacter);

                newRno = BranchCharacter + (int.Parse(rno.Remove(0, 1)) + 1).ToString();
            }
            catch (NullReferenceException ex)
            {
                newRno = Session.BranchName[0] + "1";
            }
            LblReceiptNo.Text = newRno;
            Receipt.ReceiptNumber = newRno;
        }
    }
}
