using System;
using System.Collections.Generic;

namespace MixerClient.Models.Channel
{
    public class MixerChannel
    {
        public int id;
        public String token;
        public bool online;
        public bool featured;
        public bool partnered;
        public bool transcodingEnabled;
        public bool suspended;
        public bool interactive;
        public bool hasVod;
        public String name;
        public AudienceRating audience;
        public String streamKey;
        public int viewersTotal;
        public int viewersCurrent;
        public int numFollowers;
        public int numSubscribers;
        public String description;
        public int typeId;
        public DateTime createdAt;
        public DateTime updatedAt;
        public int userId;
        public int coverId;
        public int thumbnailId;
        public int badgeId;
        public int interactiveGameId;
        public MixerResource thumbnail;
        public MixerResource cover;
        public MixerResource badge;
        public Type type;
        public Dictionary<String, Object> preferences;
        public MixerUser user;

        public class Type
        {
            public int id;
            public String name;
            public String parent;
            public String description;
            public String source;
            public int viewersCurrent;
            public int online;
            public String coverUrl;
        }

        public enum CostreamPreference
        {
            ALL,
            FOLLOWING,
            NONE
        }

        public enum AudienceRating
        {
            FAMILY,
            TEEN,
            ADULT
        }
    }
}
