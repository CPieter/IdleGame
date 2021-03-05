using Logic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Ip { get; private set; }
        public string Username { get; private set; }
        public Dictionary<Resource, int> Resources { get; private set; }
        public List<Settlement> Settlements { get; private set; }

        public User(Guid id, string ip, string username)
        {
            Id = id;
            Ip = ip;
            Username = username;
        }
    }
}
