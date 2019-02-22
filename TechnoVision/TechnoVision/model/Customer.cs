using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoVision.controller;

namespace TechnoVision.model
{
    class Customer
    {
        public static string Name;
        public static string Address;
        public static string Profession;
        public static string Age;
        public static string Phone;
        public static string Email;
        public static string Branch;

        public static void RegisterNewCustomer(MetroForm form)
        {
            CustomerController.SaveCustomer(form);
        }
    }
}

