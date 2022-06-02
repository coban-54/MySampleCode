using GameProjectDemo.Abstract;
using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class CustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckServise)
        {
            _customerCheckService = customerCheckServise;
        }
        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.add(customer);
            }
            else
                Console.WriteLine("Bilgileriniz yanlıştır");
        }
    }
}
