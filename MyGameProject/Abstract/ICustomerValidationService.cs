using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Abstract
{
    public interface ICustomerValidationService
    {
        bool ValidateCustomer(Customer customer);
    }
}
