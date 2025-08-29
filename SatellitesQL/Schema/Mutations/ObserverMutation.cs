using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using SatellitesQL.Serfvice;

namespace SatellitesQL.Schema.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class ObserverMutation
    {
        public async Task<ObserverService> SetObserverLocation(
                [Service] IObserverService observerService,
                double latitude,
                double longitude,
                double altitude)
        {
            var observer = new CurrentObserver();
            observerService.CurrentObserver = observer;

            return (ObserverService)observerService;
        }

    }
}
