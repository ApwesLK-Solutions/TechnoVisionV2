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
                    File.Create(@"D:\TechnoVision\Data\Error_Log.file");
                }
                ErrorLogFilePath = @"D:\TechnoVision\Data\Error_Log.file";
                StreamWriter writer = new StreamWriter(ErrorLogFilePath, true);
                writer.WriteLine(row);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
