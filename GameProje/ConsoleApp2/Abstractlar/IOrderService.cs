using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstractlar
{
    interface IOrderService
    {
        void Order(Game game, Gamer gamer);

        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
    }
}
