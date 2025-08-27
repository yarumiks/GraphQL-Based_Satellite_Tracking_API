using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response
{
    public class VisualPassResult
    {
        public IPassInfo Info { get; set; }
        public IEnumerable<VisualPass> VisualPass { get; set; }
    }
}
