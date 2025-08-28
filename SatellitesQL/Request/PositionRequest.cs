using SatellitesQL.Response.Types;

namespace SatellitesQL.Request
{
    public class PositionRequest
    {
        public int Id { get; set; }
        public CurrentObserver Observer { get; set; }
        public int Seconds { get; set; }
    }
}
