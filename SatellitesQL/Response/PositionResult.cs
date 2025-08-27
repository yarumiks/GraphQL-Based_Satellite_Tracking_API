using SatellitesQL.Response.Types;

namespace SatellitesQL.Response
{
    public class PositionResult 
    {
        public Info Info { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}
