using System;
using System.Collections.Generic;
using System.Text;

namespace LoginAndRegister.Model
{
    public class User
    {
        private int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User() { }

        public User(int id, string username, string password, string[] message)
        {
            Id = id;
            UserName = username;
            Password = password;
            Messages = message;
        }
        public int userId(int id)
        {
            Id = id;
            return id;
        }
    }
   
}
