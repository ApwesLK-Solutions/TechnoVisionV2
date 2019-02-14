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
                    CommonFunctions.ShowError(form, "User does not Exists.");                 
                    // MetroFramework.MetroMessageBox.Show(form, row.Password);
                    Console.WriteLine("user not found");
                    CommonFunctions.WriteUserLog("SYSTEM","Failed Login Attemp With Username -> " + User.Username);
                    //return false;
                    
                }
                else if((User.Username =="") || (User.Password==""))
                {
                    CommonFunctions.ShowError(form, "Please Enter valid username or Password.Fields can not be empty...");
                    CommonFunctions.WriteUserLog("SYSTEM"," Some User Tried to Login with Null username or Password");
                }
                else if ((row != null) && (User.Password != row.Password))
                {
                    //wrong password      
                    CommonFunctions.ShowError(form, "Wrong Password.Please Check and Re enter...");        
                    CommonFunctions.WriteUserLog("SYSTEM",User.Username + " Tried to Login with Wrong Password");
                    //return false;
                }
                else if((User.Username == row.Username) && (row.Password == User.Password) && (row.IsActive == 0))
                {
                    //Disabled User
                    CommonFunctions.ShowError(form, "This User can not Login in to the System. Access Denied...");
                    CommonFunctions.WriteUserLog("SYSTEM","A Disabled User Tried to Login > "+User.Username);
                    //return false;
                }

                else if((User.Username == row.Username) && (row.Password == User.Password))
                {
                    //login success
                    CommonFunctions.ShowSuccess(form, "Login Successfully...");
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
                CommonFunctions.ShowError(form, ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                //return false;
            }         
        }
        public static void RegisterNewUser(MetroForm form)
        {
            try
            {
                //user reg done
                usersAdapter.Insert(User.Username, User.Password, User.FullName, User.Nic, User.ContactNumber, User.BranchId, 1);
                CommonFunctions.ShowSuccess(form, "New User Added Succesfully...");
                CommonFunctions.WriteUserLog(Session.Username, "Added New User to the System (" + User.Username + ")");
            }
            catch(Exception ex)
            {
                //error
                CommonFunctions.ShowError(form, ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }

        }
        public static void DeleteUser(MetroForm form, string username)
        {
            try
            {
                usersAdapter.UpdateUserActiveStatus(0, username);
                CommonFunctions.WriteUserLog(Session.Username, "Made " + username + " As a Disabled User");
                CommonFunctions.ShowSuccess( form,"Deactivate successfull... ");
            }
            catch (Exception ex)
            {
                CommonFunctions.ShowError(form,ex.ToString());
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
            }
        }
        public static void ActiveUser(MetroForm form, string username)
        {
            try
            {
                usersAdapter.UpdateUserActiveStatus(1, username);
                CommonFunctions.WriteUserLog(Session.Username, "Made " + username + " As a active User");
                CommonFunctions.ShowError(form, "user Activate successfull...");
            }
            catch (Exception ex)
            {
                CommonFunctions.WriteToErrorLog(ex.Message.ToString());
                CommonFunctions.ShowError(form, ex.ToString());
            }
        }

    }
}
