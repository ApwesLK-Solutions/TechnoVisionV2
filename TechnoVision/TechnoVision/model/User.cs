using TechnoVision.controller;
using MetroFramework.Forms;
namespace TechnoVision.model
{
    class User
    {
        public static string Username;
        public static string Password;
        public static string FullName;
        public static string Nic;
        public static string ContactNumber;
        public static int branchId = 0;

        public static void login(MetroForm form)
        {
            UserController.login(form);
        }
    }
}
