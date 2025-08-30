using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response
{
    public class RadioPassResult
    {
        public PassInfo Info { get; set; }
        public IEnumerable<RadioPass> Passes {  get; set; }
    }
}
