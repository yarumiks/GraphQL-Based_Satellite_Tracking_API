using SatellitesQL.Response.Types;
using SatellitesQL.Response.Types.Abstract;
using System.Text.Json;

namespace SatellitesQL.Serfvice
{
    public class ObserverService : IObserverService
    {
        public CurrentObserver CurrentObserver { get; set; }
        public bool HasObserver => CurrentObserver != null;

        private readonly string localPath;

        public ObserverService()
        {
            localPath = System.IO.Path.Combine(
                AppContext.BaseDirectory, 
                "observer.json");

            if (File.Exists(localPath))
            {
                var json = File.ReadAllText(localPath);
                CurrentObserver = JsonSerializer.Deserialize<CurrentObserver>(json);
            }
            else 
                CurrentObserver = new CurrentObserver();
        }
    }

}
