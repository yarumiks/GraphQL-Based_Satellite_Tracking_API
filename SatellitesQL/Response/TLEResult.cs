using SatellitesQL.Response.Types;
using SatellitesQL.Serfvice;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response
{
    public class TLEResult
    {
        public Info Info { get; set; }
        public string Tle { get; set; }
    }
}
