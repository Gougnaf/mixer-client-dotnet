using System;
using System.Collections.Generic;
using System.Text;
using MixerClient.Models;
using MixerClient.Http;
using System.Threading.Tasks;

namespace MixerClient.Services
{
    public class UsersService : HttpService
    {
        protected readonly MixerHttpClient http;
        protected readonly String path;

        public UsersService(MixerAPI mixerAPI) : base(mixerAPI, "users") { }

        public async Task<MixerUser> GetCurrentAsync()
        {
            return await this.GetAsync<MixerUser>("current");
        }
    }
}
