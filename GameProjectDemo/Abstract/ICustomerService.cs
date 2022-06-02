using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface ICustomerService
    {
        void add(Customer customer);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
