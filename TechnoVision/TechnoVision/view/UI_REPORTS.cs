using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoVision.reports;
namespace TechnoVision.view
{
    public partial class UI_REPORTS : MetroFramework.Forms.MetroForm
    {
        string fromYear;
        string fromMonth;
        string fromDay;

        string toYear;
        string toMonth;
        string toDay;
        public UI_REPORTS()
        {
            InitializeComponent();
        }

        private void BtnContactLenses_Click(object sender, EventArgs e)
        {
            fromYear = DateDailyReport.Value.Year.ToString();
            fromMonth = DateDailyReport.Value.Month.ToString();
            fromDay = DateDailyReport.Value.Day.ToString();
            DailyReportContactLense rpt = new DailyReportContactLense();
            rpt.RecordSelectionFormula = "{contactlense1.OrderDate} = DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") AND {contactlense1.Branch} = " + Session.BranchId;          
            new UI_REPORT_VIEWER(rpt).Show();
        }

        private void BtnSpectacles_Click(object sender, EventArgs e)
        {
            fromYear = DateDailyReport.Value.Year.ToString();
            fromMonth = DateDailyReport.Value.Month.ToString();
            fromDay = DateDailyReport.Value.Day.ToString();
            DailyReportSpectacle rpt = new DailyReportSpectacle();
            rpt.RecordSelectionFormula = "{spectacles1.OrderDate} = DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") AND {spectacles1.Branch} = " + Session.BranchId;
            new UI_REPORT_VIEWER(rpt).Show();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            fromYear = DateStartDate.Value.Year.ToString();
            fromMonth = DateStartDate.Value.Month.ToString();
            fromDay = DateStartDate.Value.Day.ToString();
            toYear = DateEndDate.Value.Day.ToString();
            toMonth = DateEndDate.Value.Day.ToString();
            toDay = DateEndDate.Value.Day.ToString();
            DailyReportContactLense rpt = new DailyReportContactLense();
            rpt.RecordSelectionFormula = "{contactlense1.OrderDate} FROM DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") TO DATE(" + toYear + "," + toMonth + "," + toDay + ") AND {contactlense1.Branch} = " + Session.BranchId;
            new UI_REPORT_VIEWER(rpt).Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            fromYear = DateStartDate.Value.Year.ToString();
            fromMonth = DateStartDate.Value.Month.ToString();
            fromDay = DateStartDate.Value.Day.ToString();
            toYear = DateEndDate.Value.Day.ToString();
            toMonth = DateEndDate.Value.Day.ToString();
            toDay = DateEndDate.Value.Day.ToString();
            DailyReportSpectacle rpt = new DailyReportSpectacle();
            rpt.RecordSelectionFormula = "{spectacles1.OrderDate} FROM DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") TO DATE(" + toYear + "," + toMonth + "," + toDay + ") AND {spectacles1.Branch} = " + Session.BranchId;
            new UI_REPORT_VIEWER(rpt).Show();
        }
    }
}
