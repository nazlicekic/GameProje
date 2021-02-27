using GameProje.Abstractlar;
using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(" Kamyanya Eklendi " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(" Kamyanya Silindi " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(" Kamyanya Güncelledi " + campaign.CampaignName);
        }
    }
}
