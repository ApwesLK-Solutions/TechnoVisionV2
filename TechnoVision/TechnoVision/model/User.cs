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
        public static int BranchId = 0;

        public static void login(MetroForm form)
        {
            UserController.login(form);
        }
        
        public static void RegisterNewUser(MetroForm form)
        {
            UserController.RegisterNewUser(form);
        }

        public static void DeleteUser(MetroForm form , string username)
        {
            UserController.DeleteUser(form , username);
        }
        public static void ActiveUser(MetroForm form, string username)
        {
            UserController.ActiveUser(form, username);
        }

        public static void UpdatePassword(MetroForm form, string username, string password, string confirmPassword, string Contact, string nic)
        {
            UserController.UpdatePassword(form, username, password, confirmPassword, Contact, nic);

        }
    }
}
