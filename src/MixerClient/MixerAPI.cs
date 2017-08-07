using MixerClient.Http;
using MixerClient.Services;
using System;

namespace MixerClient
{
    public class MixerAPI
    {
        public readonly UsersService UsersService;

        private static Uri DEFAULT_BASE_PATH = new Uri("https://mixer.com/api/v1/");

        public readonly MixerHttpClient Http;

        public MixerAPI(string oauthToken)
        {
            this.Http = new MixerHttpClient(DEFAULT_BASE_PATH, oauthToken);
            this.UsersService = new UsersService(this);
        }
    }
}
