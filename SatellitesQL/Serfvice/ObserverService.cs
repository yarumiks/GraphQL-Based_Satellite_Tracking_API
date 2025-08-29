using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Serfvice
{
    public class ObserverService : IObserverService
    {
        public CurrentObserver CurrentObserver { get; set; }
        public bool HasObserver => CurrentObserver != null;
    }
}
