using System;
using System.Collections.Generic;
using MixerClient.Models.Channel;

namespace MixerClient.Models
{
    public class MixerUser
    {
        public int level { get; set; }
        //public Social social { get; set; }
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
        //public Channel channel { get; set; }
    }

    public class Social
    {
        public SocialEnum[] verified { get; set; }
    }

    //public class Channel
    //{
    //    public bool featured { get; set; }
    //    public int id { get; set; }
    //    public int userId { get; set; }
    //    public string token { get; set; }
    //    public bool online { get; set; }
    //    public int featureLevel { get; set; }
    //    public bool partnered { get; set; }
    //    public object transcodingProfileId { get; set; }
    //    public bool suspended { get; set; }
    //    public string name { get; set; }
    //    public string audience { get; set; }
    //    public int viewersTotal { get; set; }
    //    public int viewersCurrent { get; set; }
    //    public int numFollowers { get; set; }
    //    public object description { get; set; }
    //    public object typeId { get; set; }
    //    public bool interactive { get; set; }
    //    public object interactiveGameId { get; set; }
    //    public int ftl { get; set; }
    //    public bool hasVod { get; set; }
    //    public object languageId { get; set; }
    //    public object coverId { get; set; }
    //    public object thumbnailId { get; set; }
    //    public object badgeId { get; set; }
    //    public object bannerUrl { get; set; }
    //    public object hosteeId { get; set; }
    //    public bool hasTranscodes { get; set; }
    //    public bool vodsEnabled { get; set; }
    //    public object costreamId { get; set; }
    //    public DateTime createdAt { get; set; }
    //    public DateTime updatedAt { get; set; }
    //    public DateTime? deletedAt { get; set; }
    //}

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    //public class MixerUser
    //{
    //    public DateTime createdAt;
    //    public string email;
    //    public int id;
    //    public MixerChannel channel;
    //    public int points;
    //    public int experience;
    //    public int sparks;
    //    public DateTime resetTime;
    //    public Social social;
    //    public DateTime updatedAt;
    //    public String username;
    //    public bool verified;
    //    public IList<MixerResource> avatars;

    //    public enum Role
    //    {
    //        BANNED,
    //        MUTED,
    //        USER,
    //        PRO,
    //        SUBSCRIBER,
    //        MOD,
    //        GLOBAL_MOD,
    //        FOUNDER,
    //        STAFF,
    //        OWNER
    //    }

    public class SocialEnum
    {
        public String facebook;
        public String twitter;
        public String youtube;
        public String discord;
    }
}
