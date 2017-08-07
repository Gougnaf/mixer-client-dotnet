using System;
using System.Collections.Generic;
using MixerClient.Models.Channel;

namespace MixerClient.Models
{
    public class MixerUser
    {
        public int level { get; set; }
        public Social social { get; set; }
        public int id { get; set; }
        public string username { get; set; }
        public bool verified { get; set; }
        public int experience { get; set; }
        public int sparks { get; set; }
        public object avatarUrl { get; set; }
        public object bio { get; set; }
        public object primaryTeam { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public object deletedAt { get; set; }
        public Group[] groups { get; set; }
        public MixerChannel channel { get; set; }
    }

    public class Social
    {
        public String[] verified { get; set; }
        public String facebook;
        public String twitter;
        public String youtube;
        public String discord;
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
