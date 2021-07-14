using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;

namespace GameStationDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaing);
        void Delete(Campaign campaing);
    }
}
