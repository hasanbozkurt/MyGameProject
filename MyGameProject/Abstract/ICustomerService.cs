using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Abstract
{
    namespace GameStore.Abstract
    {
        public interface ICustomerService
        {
            void SignUp(Customer customer);
            void UpdateInfo(Customer customer);
            void Delete(Customer customer);
        }
    }
}
