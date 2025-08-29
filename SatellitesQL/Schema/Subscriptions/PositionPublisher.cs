using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using SatellitesQL.Request;
using SatellitesQL.Response;
using SatellitesQL.Response.Types;
using SatellitesQL.Serfvice;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace SatellitesQL.Schema.Subscriptions
{
    public class PositionPublisher
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _url;
        private readonly string _key;
        //private readonly ITopicEventSender _sender;
        public PositionPublisher(IHttpClientFactory httpClientFactory, IConfiguration config /*ITopicEventSender sender*/)
        {
            _httpClientFactory = httpClientFactory;
            _url = config["N2YO:BaseUrl"];
            // _sender = sender;
            _key = config["apiKey"];
        }
        public async IAsyncEnumerable<PositionResult> SubscribePosition(PositionRequest position, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            int seconds = position.Seconds;

            var client = _httpClientFactory.CreateClient();

            while (!cancellationToken.IsCancellationRequested)
            {

                string req = $"{_url}/positions/{position.Id}/{position.Observer.ObserverLat}/{position.Observer.ObserverLng}/{position.Observer.ObserverAlt}/{seconds}/&apiKey={_key}";
                var jsonString = await client.GetStringAsync(req, cancellationToken);

                var data = JsonSerializer.Deserialize<PositionResult>(jsonString);
                var lastPosition = data.Positions.Last();

                if (data.Positions != null && data.Positions.Any())
                {

                    var last = new PositionResult
                    {
                        Info = data.Info,
                        Positions = new List<Position> { lastPosition }
                    };

                    Console.WriteLine();
                    //await _sender.SendAsync(topic, last, cancellationToken);

                    yield return last;
                }

                ++seconds;
                await Task.Delay(2000, cancellationToken);
            }
        }
    }
}
