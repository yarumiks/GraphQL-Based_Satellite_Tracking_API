using SatellitesQL.Serfvice;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response
{
    public class TLEResult
    {
        [JsonPropertyName("info")]
        public TleInfo Info { get; set; }

        [JsonPropertyName("tle")]
        public string Tle { get; set; }
    }

    public class TleInfo : Iinfo
    {
        public int SatId { get; set; }

       
        public string SatName { get; set; }

        public int TransactionsCount { get; set; }
    }

}
