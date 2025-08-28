using SatellitesQL.Response.Types;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response
{
    public class PositionResult 
    {
        public Info Info { get; set; }
        public IEnumerable<Position>? Positions { get; set; }
    }
}
