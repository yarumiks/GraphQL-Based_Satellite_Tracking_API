using SatellitesQL.Response;
using SatellitesQL.Serfvice;
using System;
using System.Configuration;

namespace SatellitesQL.Schema
{
    public class Query
    {

        private readonly N2YOService _n2yoService;
        public Query(N2YOService n2yoService)
        {
            _n2yoService = n2yoService;
        }
        public async Task<TLEResult> GetTLE(int id)
        {
            return await _n2yoService.GetTLEAsync(id);
        }

        public Task<PositionResult> GetPosition()
        {

        }
        public string Prints => "hello grapqhl query";
    }
}
