using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public void add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "adlı kullanıcı kaydedildi");
        }
          
        public  void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "  isimli kullanıcı silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "isimli kullanıcı bilgileri güncellendi");
        }
    }
}
