using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class SaleManager
    {
        ublic void Sale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı Oyun " + customer.FirstName + " isimli müşteriye, " +
                campaign.Name + " Kampanyası ile " + game.Price + " Tl yerine " + (game.Price - (campaign.Discount * game.Price / 100)) + " Tl ile satılmıştır.");
        }

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(game.GameName + " adlı Oyun " + customer.FirstName + " isimli müşteriye, " +
                game.Price + " Tl ile satılmıştır.");
        }
    }
}
