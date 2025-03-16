﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class User
    {
        public User(int v1, string v2, string v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public int V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
    }
}
