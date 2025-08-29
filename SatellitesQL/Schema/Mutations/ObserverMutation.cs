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
                float latitude,
                float longitude,
                float altitude)
        {
            var observer = new CurrentObserver()
            {
                ObserverAlt = altitude,
                ObserverLat = latitude,
                ObserverLng = longitude
            };
            observerService.CurrentObserver = observer;

            return (ObserverService)observerService;
        }

    }
}
