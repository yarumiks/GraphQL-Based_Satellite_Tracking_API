using SatellitesQL.Response.Types;
using SatellitesQL.Serfvice;
using static SatellitesQL.Serfvice.SatelliteCategories;

namespace SatellitesQL.Request
{
    public class NearBySatellitesRequest
    {
        public CurrentObserver Observer { get; set; }
        public int SearchRadius { get; set; }
        public SatelliteCategory categoryName { get; set; }
    }
}
