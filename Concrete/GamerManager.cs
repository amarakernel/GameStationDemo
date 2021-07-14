using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;
using GameStationDemo.Abstract;

namespace GameStationDemo.Concrete
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " named user added.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " named user information updated. ");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " named user deleted.");
        }
    }
}
