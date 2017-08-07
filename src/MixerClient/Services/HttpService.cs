using MixerClient.Http;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace MixerClient.Services
{
    public class HttpService
    {
        private readonly MixerHttpClient _http;
        private readonly string _basePath;

        public HttpService(MixerAPI mixer, string path)
        {
            this._http = mixer.Http;
            this._basePath = path;
        }

        public async Task<T> GetAsync<T>(string queryPath)
        {
            var httpResponse = await _http.Http.GetAsync($"{_basePath}/{queryPath}");
            httpResponse.EnsureSuccessStatusCode();
            var response = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(response);
        }
    }
}