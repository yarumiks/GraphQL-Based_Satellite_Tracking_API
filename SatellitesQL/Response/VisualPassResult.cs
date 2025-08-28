using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response
{
    public class VisualPassResult
    {
        public PassInfo Info { get; set; }

        
        public IEnumerable<VisualPass> Passes { get; set; }
    }
}
