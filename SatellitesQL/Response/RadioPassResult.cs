using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response
{
    public class RadioPassResult
    {
        public IPassInfo Info { get; set; }
        public IEnumerable<RadioPass> RadioPass {  get; set; }
    }
}
