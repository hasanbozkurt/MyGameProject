using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    class CustomerValidationManager : ICustomerValidationService
    {
        public bool ValidateCustomer(Customer customer)
        {
            if (customer.FirstName.Equals("Hasan") && customer.LastName.Equals("Bozkurt")
                && customer.IdentityNumber.Equals("2728562645") && customer.DateOfBirth.Year == 1996)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
