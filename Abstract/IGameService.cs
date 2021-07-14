using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;

namespace GameStationDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
