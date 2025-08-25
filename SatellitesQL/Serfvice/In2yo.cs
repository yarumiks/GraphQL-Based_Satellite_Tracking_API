using SatellitesQL.Response;

namespace SatellitesQL.Serfvice
{
    public interface In2yo
    {
        Task<TLEResult> GetTLEAsync(int id);
    }
}
