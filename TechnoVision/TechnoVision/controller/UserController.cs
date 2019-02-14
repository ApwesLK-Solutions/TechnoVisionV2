using MetroFramework.Forms;
using TechnoVision.model;
using System;

namespace TechnoVision.controller
{
    class UserController
    {
        private static technovisionDataSetTableAdapters.usersTableAdapter usersAdapter = new technovisionDataSetTableAdapters.usersTableAdapter();
        private static technovisionDataSet.usersDataTable userTable = usersAdapter.GetData();

        private static technovisionDataSetTableAdapters.branchTableAdapter branchAdapter = new technovisionDataSetTableAdapters.branchTableAdapter();
        private static technovisionDataSet.branchDataTable branchTable = branchAdapter.GetData();

        private static technovisionDataSet.usersRow row;
        private static technovisionDataSet.branchRow Brow;
        public static void login(MetroForm form)
        {
            try
            {                
                row = userTable.FindByUsername(User.Username);
                if (row == null)
                {
                    //user not exists                  

                    // MetroFramework.MetroMessageBox.Show(form, row.Password);
                    Console.WriteLine("user not found");
                    CommonFunctions.WriteUserLog("SYSTEM","Failed Login Attemp With Username -> " + User.Username);
                    //return false;
                    
                }
                else if ((row != null) && (User.Password != row.Password))
                {
                    //wrong password      
                    Console.WriteLine("wrong password");         
                    CommonFunctions.WriteUserLog("SYSTEM",User.Username + " Tried to Login with Wrong Password");
                    //return false;
                }
                else if((User.Username == row.Username) && (row.Password == User.Password) && (row.IsActive == 0))
                {
                    //Disabled User
                    Console.WriteLine("Deleted user");
                    CommonFunctions.WriteUserLog("SYSTEM","A Disabled User Tried to Login > "+User.Username);
                    //return false;
                }

                else if((User.Username == row.Username) && (row.Password == User.Password))
                {
                    //login success
                    Console.WriteLine("login success");
                    Session.Username = row.Username;
                    Session.BranchId = row.BranchId;
                    Brow = branchTable.FindById(row.BranchId);
                    Session.BranchMasterPassword = Brow.MasterPassword;
                    CommonFunctions.WriteUserLog("SYSTEM" , User.Username + " is Log into the System");
                    //return true;
                }
            }
            catch(Exception ex)
            {
                //show some error and log the original error!
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                //return false;
            }         
        }
    }
}
