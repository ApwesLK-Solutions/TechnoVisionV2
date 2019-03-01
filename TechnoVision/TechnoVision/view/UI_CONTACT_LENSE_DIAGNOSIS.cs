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
using TechnoVision.controller;
namespace TechnoVision.view
{
    public partial class UI_CONTACT_LENSE_DIAGNOSIS : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Forms.MetroForm f;
        public UI_CONTACT_LENSE_DIAGNOSIS(MetroFramework.Forms.MetroForm form)
        {
            InitializeComponent();
            f = form;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LenseOrderController.FillFormTwo(TxtRightOldSph.Text, TxtRightOldCyl.Text, TxtRightOldAxis.Text, TxtRightOldAdd.Text, TxtLeftOldSph.Text, TxtLeftOldCyl.Text, TxtLeftOldAxis.Text, TxtLeftOldAdd.Text, TxtRightPresentSph.Text, TxtRightPresentCyl.Text, TxtRightPresentAxis.Text, TxtRightPresentAdd.Text, TxtRightPresentAdd.Text, TxtLeftPresentCyl.Text, TxtLeftPresentAxis.Text, TxtLeftPresentAdd.Text, TxtRightBc.Text, TxtRightPow.Text, TxtRightDia.Text, TxtRightDeze.Text, TxtLeftBc.Text, TxtLeftPow.Text, TxtLeftDia.Text, TxtLeftDeze.Text, TxtTrailLense.Text, TxtOverRefract.Text, TxtKReading.Text, TxtBlindTest.Text, TxtSpecialIns.Text, TxtRemarks.Text);
        }

        private void UI_CONTACT_LENSE_DIAGNOSIS_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            f.Show();
        }
    }
}
