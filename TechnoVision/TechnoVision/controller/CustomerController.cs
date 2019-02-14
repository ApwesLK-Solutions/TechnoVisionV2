using System;
using TechnoVision.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace TechnoVision.controller
{
    class CustomerController
    {
        private static technovisionDataSetTableAdapters.customerTableAdapter tableAdapter = new technovisionDataSetTableAdapters.customerTableAdapter();
        public static void SaveCustomer(MetroForm form)
        {
            try
            {
                tableAdapter.Insert(Customer.Name, Customer.Address, Customer.Profession, Customer.Age, Customer.Phone, Customer.Email, int.Parse(Customer.Branch));
            }
            catch(Exception ex)
            {

            }
        }
    }
}
