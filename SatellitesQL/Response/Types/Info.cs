using SatellitesQL.Response.Types.Abstract;
using System.Text.Json.Serialization;

namespace SatellitesQL.Response.Types
{
    public class Info : Iinfo
    {
        [JsonPropertyName("satid")]
        public int SatId { get; set; }

        [JsonPropertyName("satname")]
        public string SatName { get; set; }

        [JsonPropertyName("transactionscount")]
        public int TransactionsCount { get; set; }
    }
}
