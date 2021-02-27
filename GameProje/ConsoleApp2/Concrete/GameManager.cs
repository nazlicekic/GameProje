using GameProje.Abstractlar;
using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(" Oyun Eklendi " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(" Oyun silindi " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine(" Oyun güncellendi " + game.GameName);
        }
    }
}
