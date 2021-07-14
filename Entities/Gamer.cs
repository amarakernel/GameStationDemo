﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStationDemo.Entities
{
    class Gamer
    {
        public int GamerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
