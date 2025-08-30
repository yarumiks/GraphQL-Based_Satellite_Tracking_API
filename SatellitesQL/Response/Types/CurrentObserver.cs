using System.Text.Json.Serialization;

namespace SatellitesQL.Response.Types
{
    public class CurrentObserver
    {
        [JsonPropertyName("observer_lat")]
        public float ObserverLat { get; set; }
        [JsonPropertyName("observer_lng")]
        public float ObserverLng { get; set; }
        [JsonPropertyName("observer_alt")]
        public float ObserverAlt { get; set; }
    }
}
