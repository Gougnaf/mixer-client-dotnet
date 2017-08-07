using System;
using System.Collections.Generic;

namespace MixerClient.Models.Channel
{
    public class MixerResource
    {
        public int id;
        public Dictionary<String, Object> meta;
        public int relid;
        public String remotePath;
        public String store;
        public String type;
        public String url;
        public DateTime createdAt;
        public DateTime updatedAt;
    }
}
