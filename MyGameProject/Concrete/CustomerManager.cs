using MyGameProject.Abstract;
using MyGameProject.Abstract.GameStore.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerValidationService customerValidationService;

        public CustomerManager(ICustomerValidationService customerValidationService)
        {
            this.customerValidationService = customerValidationService;
        }

        public void SignUp(Customer customer)
        {
            if (customerValidationService.ValidateCustomer(customer))
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " , Başarıyla Kaydoldunuz.");
            }
            else
            {
                throw new Exception("Kullanıcı doğrulaması başarısız oldu, kaydolamazsınız");
            }
        }

        public void UpdateInfo(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " , Bilgileriniz güncellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " , Hesabınız silinmiştir.");
        }
    }
}
