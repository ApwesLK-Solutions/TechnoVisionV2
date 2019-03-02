using System;
using System.IO;
using TechnoVision.model;
using MetroFramework.Forms;
namespace TechnoVision
{
    class CommonFunctions
    {
        private static string ErrorLogFilePath;
        private static technovisionDataSetTableAdapters.logsTableAdapter UserLog = new technovisionDataSetTableAdapters.logsTableAdapter();

        public static bool WriteToErrorLog(string row)
        {
            try
            {
                if (Directory.Exists(@"D:\TechnoVision\Data") == false)
                {
                    Directory.CreateDirectory(@"D:\TechnoVision\Data");
                }
                if (File.Exists(@"D:\TechnoVision\Data\Error_Log.file") == false)
                {
                    File.Create(@"D:\TechnoVision\Data\Error_Log.file").Close();
                }
                ErrorLogFilePath = @"D:\TechnoVision\Data\Error_Log.file";
                StreamWriter writer = new StreamWriter(ErrorLogFilePath, true);
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") +" " +DateTime.Now.ToString("hh:mm:ss")+" : " + row);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool WriteUserLog(string user,string row)
        {
            try
            {
                UserLog.Insert(user, User.BranchId, DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")), DateTime.Parse(DateTime.Now.ToString("hh:mm:ss")), row);
                return true;
            }
            catch(Exception ex)
            {
                WriteToErrorLog(ex.Message.ToString());
                return false;
            }
        }
        public static void ShowError(MetroForm form , string msg)
        {
            MetroFramework.MetroMessageBox.Show(form, msg, "Error!",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
        }
        public static void ShowSuccess(MetroForm form, string msg)
        {
            MetroFramework.MetroMessageBox.Show(form, msg, "Success!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
        }
        
    }
}
