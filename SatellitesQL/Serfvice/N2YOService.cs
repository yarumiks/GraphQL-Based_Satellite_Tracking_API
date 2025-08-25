using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Configuration;
using SatellitesQL.Response;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SatellitesQL.Serfvice
{

    public sealed class N2YOService : In2yo
    {
        private readonly IConfiguration _config;
        private readonly string? _key;
        private readonly string? _url;
        private readonly HttpClient _httpClient;
       
        public N2YOService(IConfiguration config, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _config = config;
            _url= _config["N2YO:BaseUrl"];
            _key = _config["apiKey"];
        }

        public async Task<TLEResult> GetTLEAsync(int id)
        {
            string req = $"{_url}/tle/{id}&apiKey={_key}";

            var response = await _httpClient.GetFromJsonAsync<TLEResult>(req);
            return response;
        }


    }
}
