using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;
using GameStationDemo.Abstract;

namespace GameStationDemo.Concrete
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " named game is available now.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " named game updated.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " named game deleted.");
        }
    }
}
