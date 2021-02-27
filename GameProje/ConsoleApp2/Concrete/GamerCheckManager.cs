using GameProje.Abstractlar;
using GameProje.Adapter;
using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class GamerCheckManager : IGamerCheckManager
    {
        IGamerCheckManager _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();

            return _gamerCheckService.Check(gamer);
        }
    }
}
