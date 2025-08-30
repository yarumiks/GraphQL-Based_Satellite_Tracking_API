using System.Text.Json.Serialization;

namespace SatellitesQL.Response.Types.Abstract
{
    public interface IPassInfo : Iinfo
    {
        [JsonPropertyName("passescount")]
        public int PassesCount { get; set; }
    }
}
