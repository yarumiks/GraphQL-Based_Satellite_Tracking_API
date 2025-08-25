using SatellitesQL.Response;
using System.Net.Http;
using SatellitesQL.Serfvice;

namespace SatellitesQL.Schema
{
    [ExtendObjectType(nameof(Query))]
    public class TLEQuery
    {
        private readonly N2YOService _n2yoService;
        public TLEQuery(N2YOService n2yoService)
        {
             _n2yoService = n2yoService;
        }

        public async Task<TLEResult> GetTLE(int id)
        {
            return await _n2yoService.GetTLEAsync(id);
        }
    }
}
