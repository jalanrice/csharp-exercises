﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C9UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Joined { get; private set; }
        public int UserId { get; private set; }
        private static int nextId = 1;

        public User()
        {
            UserId = nextId;
            nextId++;

            Joined = DateTime.Now;

        }


    }
}
