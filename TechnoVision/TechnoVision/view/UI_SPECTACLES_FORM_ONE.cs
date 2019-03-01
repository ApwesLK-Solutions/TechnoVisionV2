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
        }
    }
}
