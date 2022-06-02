
using GameProjectDemo.Entitis;
using System;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(){Id=1,DateOfBirth=new DateTime(1995),FirstName="Hüseyin",LastName="Çoban",NationalityId="2321312312"};
            CustomerManager customerManager = new CustomerManager(new CustomerCheckService());
            customerManager.Add(customer);
            customerManager.Delete(customer);

            
            Campaign campaign = new Campaign() { Name = "Size özel Fırsatımız : ", Id = 10, Discount = 50 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Game game = new Game() { GameName = "Skyrim", Id = 2, Price = 150 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer, game);
        }
    }
}
