using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TechnoVision
{
    class CommonFunctions
    {
        private static string ErrorLogFilePath;

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

        public static void ShowError(string msg)
        {

        }
        public static void ShowSuccess(string msg)
        {

        }
        public static bool WriteUserLog(string row)
        {
            return true;
        }
        public static void ShowUnexpectedError()
        {
            
        }
    }
}
