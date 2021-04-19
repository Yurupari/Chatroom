using System;
using System.Collections.Generic;

namespace Chatroom.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}
