using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using SatellitesQL.LocalDefinedSatellites;
using SatellitesQL.Request;
using SatellitesQL.Response;
using SatellitesQL.Response.Types;
using SatellitesQL.Serfvice;
using System;
using System.Configuration;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using JsonType = SatellitesQL.LocalDefinedSatellites.JsonType;

namespace SatellitesQL.Schema
{
    [ExtendObjectType(typeof(Query))]
    public class SatelliteQuery
    {
        private readonly N2YOService _n2yoService;
        public SatelliteQuery(N2YOService n2yoService)
        {
            _n2yoService = n2yoService;
        }

        public IEnumerable<JsonType> GetLocalSattellitesID(SatelliteCategories.SatelliteCategory? name)
        {
            string path = System.IO.Path.Combine(AppContext.BaseDirectory, "LocalDefinedSatellites/Satellitesjson.json");
            string allText = File.ReadAllText(path);

            var jsonObject = JsonConvert.DeserializeObject<LocalDefinedSatellites.JsonValue>(allText);
            if (name.HasValue)
            {
                string val = name.Value.ToString();
                var find = jsonObject.SatelliteCategories
                        .Where(sc => sc.Name.Equals(val, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();

                if (find == null) throw new GraphQLException($"Value for the parameter given not found: '{val}'");

                return new List<JsonType> { find };
            }

            return jsonObject.SatelliteCategories;
        }

        public Task<TLEResult> GetTLE(int id)
        {
            return _n2yoService.GetTLEAsync(id);
        }

        public Task<PositionResult> GetPosition(PositionRequest position)
        {
            return _n2yoService.GetPositionAsync(position);
        }

        public Task<VisualPassResult> GetVisualVisibility(VisualPassRequest visualP)
        {
            return _n2yoService.GetSatelliteVisibilityAsync(visualP);
        }

        public Task<RadioPassResult> GetRadioPass(RadioPassRequest radioP)
        {
            return _n2yoService.GetRadioPassAsync(radioP);
        }
        public Task<NearBySatellitesResult> GetNearBySatellites(NearBySatellitesRequest satellites)
        {
            return _n2yoService.GetNearBySatellitesAsync(satellites);
        }
    }
}
