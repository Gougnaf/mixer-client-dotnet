using System;
using System.Collections.Generic;
using System.Text;
using MixerClient.Models;
using MixerClient.Http;
using System.Threading.Tasks;
using MixerClient.Models.Channel;
using System.Linq;

namespace MixerClient.Services
{
    public class ChannelsService : HttpService
    {
        protected readonly MixerHttpClient http;
        protected readonly String path;

        public ChannelsService(MixerAPI mixerAPI) : base(mixerAPI, "channels") { }

        public async Task<IEnumerable<MixerChannel>> GetSegmentedAsync(int page, int limit)
        {
            var options = new Dictionary<string, object>();
            options.Add("page", Math.Max(0, page));
            options.Add("limit", Math.Max(0, limit));
            return await this.GetAsync<IEnumerable<MixerChannel>>(null, ToQueryString(options));
        }
    }
}
