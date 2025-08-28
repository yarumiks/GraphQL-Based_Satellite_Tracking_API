using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response.Types
{
    public class Above
    {
        public int SatId { get; set; }
        public string IntDesignator { get; set; }
        public string SatName { get; set; }
        public string LaunchDate { get; set; }
        public float SatLat { get; set; }
        public float SatLng { get; set; }
        public float SatAlt { get; set; }
    }

    public class AboveInfo
    {
        public string Category { get; set; }
        public int TransactionCount { get; set; }
        public int SatCount { get; set; }
    }
}
