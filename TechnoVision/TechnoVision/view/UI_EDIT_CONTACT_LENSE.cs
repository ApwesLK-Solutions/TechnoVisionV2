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
    public partial class UI_EDIT_CONTACT_LENSE : MetroFramework.Forms.MetroForm
    {
        string OrderNumber;
        public UI_EDIT_CONTACT_LENSE(string OrderNumber)
        {
            InitializeComponent();
            this.OrderNumber = OrderNumber;
        }

        private void UI_EDIT_CONTACT_LENSE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technovisionDataSet.contactlense' table. You can move, or remove it, as needed.
            this.contactlenseTableAdapter.Fill(this.technovisionDataSet.contactlense);

        }
    }
}
