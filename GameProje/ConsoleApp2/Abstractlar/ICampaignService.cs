using GameProje.Enity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstractlar
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
