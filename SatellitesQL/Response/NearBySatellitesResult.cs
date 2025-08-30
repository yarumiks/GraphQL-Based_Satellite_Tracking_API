using SatellitesQL.Response.Types;

namespace SatellitesQL.Response
{
    public class NearBySatellitesResult
    {
        public AboveInfo Info { get; set; }
        public IEnumerable<Above> Above { get; set; }

    }
}
