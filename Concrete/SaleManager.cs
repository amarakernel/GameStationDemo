using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;
using GameStationDemo.Abstract;

namespace GameStationDemo.Concrete
{
    class SaleManager:ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.UserName + " named gamer bought " + game.GameName + " named game.");
            Console.WriteLine("Campaign: " + campaign.CampaignName + " Game:" + game.GameName);
        }
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.UserName + " named user bought " + game.GameName + " named game.");
        }
    }
}
