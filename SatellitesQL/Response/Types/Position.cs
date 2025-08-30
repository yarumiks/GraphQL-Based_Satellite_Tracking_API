using System.Text.Json.Serialization;

namespace SatellitesQL.Response.Types
{
    public class Position
    {
        [JsonPropertyName("satlatitude")]
        public float Latitude { get; set; }

        [JsonPropertyName("satlongitude")]
        public float Longitude { get; set; }

        [JsonPropertyName("sataltitude")]
        public float Altitude { get; set; }

        [JsonPropertyName("azimuth")]
        public float Azimuth { get; set; }

        [JsonPropertyName("elevation")]
        public float Elevation { get; set; }

        [JsonPropertyName("ra")]
        public float RightAscension { get; set; } 

        [JsonPropertyName("dec")] 
        public float Declination { get; set; }

        [JsonPropertyName("timestamp")] 
        public int TimesTamp { get; set; }
    }
}
