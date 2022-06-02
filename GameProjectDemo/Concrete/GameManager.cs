using GameProjectDemo.Abstract;
using GameProjectDemo.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "kütüphanenize tanımlandı");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "adlı oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "adlı oyun güncelleniyor");
        }
    }
}
