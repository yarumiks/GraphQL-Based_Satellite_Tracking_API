namespace SatellitesQL.Request
{
    public class VisualPassRequest
    {
        public int Id { get; set; }
        public CurrentObserver Observer { get; set; }
        public int Days { get; set; }
        public int MinVisibility { get; set; }

    }
}
