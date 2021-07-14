using System;
using System.Collections.Generic;
using System.Text;
using GameStationDemo.Entities;
using GameStationDemo.Abstract;

namespace GameStationDemo.Concrete
{
    class CheckPerson:ICheckPerson
    {
        public bool Check(Gamer gamer)
        {
            if(gamer.NationalityId.Length == 11)
            {
                Console.WriteLine("This ID number is acceptable.");
                return true;
            }

            else
            {
                Console.WriteLine("This ID number is not in the system.");
                return false;
            }
        }
    }
}
