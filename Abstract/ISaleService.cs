using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;

namespace GameStationDemo.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
    }
}
