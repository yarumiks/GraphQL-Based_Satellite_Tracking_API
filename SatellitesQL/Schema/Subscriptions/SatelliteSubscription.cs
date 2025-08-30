
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using SatellitesQL.Request;
using SatellitesQL.Response;
using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using SatellitesQL.Serfvice;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace SatellitesQL.Schema.Subscriptions
{


    public class SatelliteSubscription
    {
        [SubscribeAndResolve]
        public async IAsyncEnumerable<PositionResult> OnPositionUpdated(
        PositionRequest request,
        [EnumeratorCancellation] CancellationToken cancellationToken,
        [Service] PositionPublisher publisher,
        [Service] IObserverService observerService)
        {

            if (request.Observer == null & observerService.HasObserver) 
            {
                request.Observer = observerService.CurrentObserver;
            }
            await foreach (var pos in publisher.SubscribePosition(request, cancellationToken))
            {
                yield return pos;
            }
        }
    }
}