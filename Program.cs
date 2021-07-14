using System;
using GameStationDemo.Entities;
using GameStationDemo.Concrete;

namespace GameStationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Seda";
            gamer1.LastName = "Cede";
            gamer1.UserName = "Fury Montana";
            gamer1.NationalityId = "12345678910";
            gamer1.Email = "sedacedepsg@hotmail.com";
            gamer1.Password = "123456";
            gamer1.DateOfBirth = new DateTime(1997, 1, 1);
            gamer1.GamerId = 1;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Berkay";
            gamer2.LastName = "Erol";
            gamer2.UserName = "SolidMoon";
            gamer2.NationalityId = "98765432100";
            gamer2.Email = "berkayerol@hotmail.com";
            gamer2.Password = "987654";
            gamer2.DateOfBirth = new DateTime(2000, 2, 2);
            gamer2.GamerId = 2;

            Game game1 = new Game();
            game1.GameName = "Doom : Eternal";
            game1.ReleaseDay = new DateTime(2016, 1, 1);
            game1.GameId = 1;
            game1.Price = 99.99;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Friday Sale";
            campaign1.CampaignNo = 1;
            campaign1.DiscountRate = 50;
            campaign1.OriginalPrice = 150;

            Console.WriteLine("Please, chose your action to do.");
            Console.WriteLine("1. Gamer Transactions");
            Console.WriteLine("2. Game Transactions");
            Console.WriteLine("3. Campaign  Transactions");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:

                 Console.WriteLine("Chose your action to do.");
                 Console.WriteLine("1. Add a new gamer.");
                 Console.WriteLine("2. Update a gamer.");
                 Console.WriteLine("3. Delete a gamer.");

                 int Case1 = Convert.ToInt32(Console.ReadLine());
                 GamerManager gamerManager = new GamerManager();
                    
                    if(Case1 == 1)
                    {
                        gamerManager.Add(gamer1);
                    }

                    else if(Case1 == 2)
                    {
                        gamerManager.Update(gamer2);
                    }

                    else
                    {
                        gamerManager.Delete(gamer1);
                    }

                   
                break;

                case 2:
                Console.WriteLine("Chose your action to do.");
                Console.WriteLine("1. Add a new game.");
                Console.WriteLine("2. Update a game.");
                Console.WriteLine("3. Delete a game.");

                int Case2 = Convert.ToInt32(Console.ReadLine());
                GameManager gameManager = new GameManager();

                    if (Case2 == 1)
                    {
                        gameManager.Add(game1);
                    }

                    else if (Case2 == 2)
                    {
                        gameManager.Update(game1);
                    }

                    else
                    {
                        gameManager.Delete(game1);
                    }
                    break;

                case 3:
                Console.WriteLine("Chose your action to do.");
                Console.WriteLine("1. Add a new campaign.");
                Console.WriteLine("2. Update a campaign.");
                Console.WriteLine("3. Delete a campaign.");

                int Case3 = Convert.ToInt32(Console.ReadLine());
                CampaignManager campaignManager = new CampaignManager();

                    if (Case3 == 1)
                    {
                        campaignManager.Add(campaign1);
                    }

                    else if (Case3 == 2)
                    {
                        campaignManager.Update(campaign1);
                    }

                    else
                    {
                        campaignManager.Delete(campaign1);
                    }
                    break;
                    
            }
           
           



        }
    }
}
