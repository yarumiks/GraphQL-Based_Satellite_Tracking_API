using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response.Types
{
    public class PassInfo : IPassInfo
    {
        public int PassesCount { get; set; }
        public int SatId { get ; set; }
        public string SatName { get; set ; }
        public int TransactionsCount { get; set; }
    }
}
