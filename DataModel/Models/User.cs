using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
