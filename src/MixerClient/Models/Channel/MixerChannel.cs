using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MixerClient.Models.Channel
{
    public class MixerChannel
    {
        public int id;
        public String token;
        public bool online;
        public bool featured;
        public int? featureLevel;
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
        public int? typeId;
        public DateTime createdAt;
        public DateTime updatedAt;
        public int userId;
        public int? coverId;
        public int? thumbnailId;
        public int? badgeId;
        public int? interactiveGameId;
        public MixerResource thumbnail;
        public MixerResource cover;
        public MixerResource badge;
        public Type type;
        public Dictionary<String, Object> preferences;
        public MixerUser user;
        public object transcodingProfileId { get; set; }
        public int ftl { get; set; }
        public String bannerUrl { get; set; }
        public object hosteeId { get; set; }
        public bool hasTranscodes { get; set; }
        public bool vodsEnabled { get; set; }
        public object costreamId { get; set; }
        public object deletedAt { get; set; }

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

        [JsonConverter(typeof(StringEnumConverter))]
        public enum AudienceRating
        {
            [EnumMember(Value = "family")]
            FAMILY,
            [EnumMember(Value = "teen")]
            TEEN,
            [EnumMember(Value = "18+")]
            ADULT
        }
    }
}
