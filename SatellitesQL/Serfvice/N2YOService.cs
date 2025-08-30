using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Configuration;
using SatellitesQL.Request;
using SatellitesQL.Response;
using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using System;
using System.Diagnostics;
using System.Globalization;
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
        private string? _req;
        public N2YOService(IConfiguration config, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _config = config;
            _url = _config["N2YO:BaseUrl"];
            _key = _config["apiKey"];
        }

        /// <summary>
        /// According to id information, it returns satellite information in Two-Line Element (TLE) format
        /// </summary>
        public async Task<TLEResult> GetTLEAsync(int id)
        {
            _req = $"{_url}/tle/{id}&apiKey={_key}";
            var response = await _httpClient.GetFromJsonAsync<TLEResult>(_req);
            return response;
        }

        public async Task<PositionResult> GetPositionAsync(PositionRequest position)
        {
            var id = position.Id;
            var observer_lat = position.Observer.ObserverLat;
            var observer_lng = position.Observer.ObserverLng;
            var observer_alt = position.Observer.ObserverAlt;
            var seconds = position.Seconds;

            _req = $"{_url}/positions/{id}/{observer_lat}/{observer_lng}/{observer_alt}/{seconds}/&apiKey={_key}";

            var response = await _httpClient.GetFromJsonAsync<PositionResult>(_req);
            return response;
        }


        /// <summary>
        /// Predicts satellite visibility for an observer.
        /// </summary>
        /// <param name="visualPass">The request object containing the satellite ID, observer location...</param>
        /// <returns>A <see cref="VisualPassResult"/> object containing predicted visual passes with azimuth, elevation....</returns>
        public async Task<VisualPassResult> GetSatelliteVisibilityAsync(VisualPassRequest visualPass)
        {
            var id = visualPass.Id;
            var lat = visualPass.Observer.ObserverLat;
            var lng = visualPass.Observer.ObserverLng;
            var alt = visualPass.Observer.ObserverAlt;
            var days = visualPass.Days;
            var v = visualPass.MinVisibility;

            _req = $"{_url}/visualpasses/{id}/{lat}/{lng}/{alt}/{days}/{v}/&apiKey={_key}";

            var response = await _httpClient.GetFromJsonAsync<VisualPassResult>(_req);
            return response;
        }

        /// <summary>
        /// Predicts satellite radio passes for communication.
        /// </summary>
        /// <param name="radioPass">The request object containing the satellite ID, observer location...</param>
        /// <returns>A <see cref="RadioPassResult"/> object containing the predicted radio passes with azimuth, elevation.../returns>
        public async Task<RadioPassResult> GetRadioPassAsync(RadioPassRequest radioPass)
        {
            var id = radioPass.Id;
            var lat = radioPass.Observer.ObserverLat;
            var lng = radioPass.Observer.ObserverLng;
            var alt = radioPass.Observer.ObserverAlt;
            var days = radioPass.Days;
            var e = radioPass.MinElevation;

            _req = $"{_url}/radiopasses/{id}/{lat}/{lng}/{alt}/{days}/{e}/&apiKey={_key}";

            var response = await _httpClient.GetFromJsonAsync<RadioPassResult>(_req);
            return response;
        }


        public async Task<NearBySatellitesResult> GetNearBySatellitesAsync(NearBySatellitesRequest satellites)
        {
           
            float lat = satellites.Observer.ObserverLat;
            float lng = satellites.Observer.ObserverLng;
            float alt = satellites.Observer.ObserverAlt;
            var degree = satellites.SearchRadius;
            var category = satellites.categoryName;
    
            int id = SatelliteCategories.GetCategoryIdByEnum(category);

            _req = $"{_url}/above/{lat.ToString(CultureInfo.InvariantCulture)}/" +
                   $"{lng.ToString(CultureInfo.InvariantCulture)}/" +
                   $"{alt.ToString(CultureInfo.InvariantCulture)}/" +
                   $"{degree.ToString(CultureInfo.InvariantCulture)}/" +
                   $"{id}/&apiKey={_key}";


            var response = await _httpClient.GetFromJsonAsync<NearBySatellitesResult>(_req);
            
            if (response is null)
                throw new GraphQLException("No satellite was found for the parameters given. You can try again by selecting another satellite category.");
            

            return response;
        }
    }
}
