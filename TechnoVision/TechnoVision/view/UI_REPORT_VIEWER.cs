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
    public partial class UI_REPORT_VIEWER : Form
    {
        CrystalDecisions.CrystalReports.Engine.ReportDocument rpt;
        public UI_REPORT_VIEWER(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            InitializeComponent();
            this.rpt = rpt;
        }

        private void UI_REPORT_VIEWER_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }
    }
}
