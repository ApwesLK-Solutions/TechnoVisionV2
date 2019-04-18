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
            try
            {
                 
                fromYear = DateDailyReport.Value.Year.ToString();
                fromMonth = DateDailyReport.Value.Month.ToString();
                fromDay = DateDailyReport.Value.Day.ToString();
                DailyReportContactLense rpt = new DailyReportContactLense();
                //{receipt1.ReceiptDate} = {receipt1.Branch}{receipt1.OrderType}
                rpt.RecordSelectionFormula = "{receipt1.ReceiptDate} = DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") AND {contactlense1.Branch} = " + Session.BranchId + "AND {receipt1.OrderType} = 'LENSE'";
                //CommonFunctions.ShowError(this,rpt.RecordSelectionFormula.ToString());
                new UI_REPORT_VIEWER(rpt).Show();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this,ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.ToString());
            }
           
        }

        private void BtnSpectacles_Click(object sender, EventArgs e)
        {
            try
            {
                fromYear = DateDailyReport.Value.Year.ToString();
                fromMonth = DateDailyReport.Value.Month.ToString();
                fromDay = DateDailyReport.Value.Day.ToString();
                DailyReportSpectacle rpt = new DailyReportSpectacle();
                rpt.RecordSelectionFormula = "{receipt1.ReceiptDate} = DATE(" + fromYear + "," + fromMonth + "," + fromDay + ") AND {spectacles1.Branch} = " + Session.BranchId + "AND {receipt1.OrderType} = 'SPEC'";
                new UI_REPORT_VIEWER(rpt).Show();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.ToString());
            }
            

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DailyReportContactLense rpt = new DailyReportContactLense();
                rpt.RecordSelectionFormula = "{receipt1.ReceiptDate} in Date(" + DateStartDate.Value.ToString("yyyy,MM,dd") + ") to Date(" + DateEndDate.Value.ToString("yyyy,MM,dd") + ") AND {contactlense1.Branch} = " + Session.BranchId + "AND {receipt1.OrderType} = 'LENSE'";
                new UI_REPORT_VIEWER(rpt).Show();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.ToString());
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DailyReportSpectacle rpt = new DailyReportSpectacle();
                rpt.RecordSelectionFormula = "{receipt1.ReceiptDate} in Date(" + DateStartDate.Value.ToString("yyyy,MM,dd") + ") to Date(" + DateEndDate.Value.ToString("yyyy,MM,dd") + ") AND {spectacles1.Branch} = " + Session.BranchId + "AND {receipt1.OrderType} = 'SPEC'";
                new UI_REPORT_VIEWER(rpt).Show();
            }
            catch(Exception ex)
            {
                CommonFunctions.ShowError(this, ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.ToString());
            }
            
        }
    }
}
