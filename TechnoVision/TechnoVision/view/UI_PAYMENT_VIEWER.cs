using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoVision.view
{
    public partial class UI_PAYMENT_VIEWER : MetroFramework.Forms.MetroForm
    {
        public UI_PAYMENT_VIEWER()
        {
            InitializeComponent();
           
            
        }

        private void UI_PAYMENT_VIEWER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.technovisionDataSet.receipt);


        }
    }
}
