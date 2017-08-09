using System;
using System.Net.Http;

namespace MixerClient.Http
{
    public class MixerHttpClient
    {
        public readonly HttpClient Http;        
        private string _oauthToken;

        public MixerHttpClient(Uri basePath, string oauthToken = null)
        {
            this.Http = new HttpClient() { BaseAddress = basePath };

            if (oauthToken != null)
            {
                this._oauthToken = oauthToken;
                Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", oauthToken);
            }
        }
    }
}
