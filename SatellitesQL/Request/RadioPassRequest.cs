using SatellitesQL.Response.Types;

namespace SatellitesQL.Request
{
    public class RadioPassRequest
    {
        public int Id { get; set; }
        public CurrentObserver Observer { get; set; }
        public int Days { get; set; }
        public int MinElevation { get; set; }

    }
}
