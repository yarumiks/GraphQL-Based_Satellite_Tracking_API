namespace SatellitesQL.Response.Types.Abstract
{
    public interface IObserverService
    {
        public CurrentObserver? CurrentObserver { get; set; }
        public bool HasObserver { get; }
    }
}
