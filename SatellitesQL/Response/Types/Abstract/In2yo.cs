using SatellitesQL.Response;

namespace SatellitesQL.Response.Types.Abstract
{
    public interface In2yo
    {
        Task<TLEResult> GetTLEAsync(int id);
    }
}
