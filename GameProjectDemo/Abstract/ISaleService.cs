using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void SaleCamp(Customer customer, Game game, Campaign campaign);
        void Sale(Customer customer, Game game);
    }
}
