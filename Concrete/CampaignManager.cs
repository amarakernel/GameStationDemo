using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;
using GameStationDemo.Abstract;

namespace GameStationDemo.Concrete
{
    class CampaignManager:ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign uploaeded to system.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign is updated");
        }
    }
}
