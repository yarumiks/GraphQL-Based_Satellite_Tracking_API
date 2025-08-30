using SatellitesQL.Response.Types;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response
{
    public class PositionResult 
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("positions")]
        public IEnumerable<Position>? Positions { get; set; }
    }
}
