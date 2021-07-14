using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;

namespace GameStationDemo.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
