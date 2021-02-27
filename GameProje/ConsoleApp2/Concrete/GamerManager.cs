using GameProje.Abstractlar;
using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckManager _gamerCheckManager;

        public GamerManager(IGamerCheckManager gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
              Console.WriteLine("BAŞARILI");
              Console.WriteLine(gamer.UserName + "Oyuncusu eklendi.");
            }

            else
            {
                Console.WriteLine("Bi daha bu mekana GELME :) sahtekar seni gidi..");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + "Oyuncusu Silindi ");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine("BAŞARILI");
                Console.WriteLine(gamer.UserName + "Oyuncusu güncellendi.");
            }

            else
            {
                Console.WriteLine("Malesef güncelleme başarısız !!!");
            }
        }
    }
}
