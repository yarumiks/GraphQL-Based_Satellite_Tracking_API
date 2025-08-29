using SatellitesQL.Response.Types.Abstract;
using SatellitesQL.Serfvice;

namespace SatellitesQL.Schema
{
    [ExtendObjectType(typeof(Query))]
    public class ObserverQuery
    {
        public ObserverService? GetObserver([Service] IObserverService observerService)
        {
            return observerService as ObserverService;
        }
    }
}
