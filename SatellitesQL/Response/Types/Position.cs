namespace SatellitesQL.Response.Types
{
    public class Position
    {
        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public float Azimuth { get; set; }

        public float Elevation { get; set; }

        public float RightAscension { get; set; } 

        public float Declination { get; set; }

        public int TimesTamp { get; set; }
    }
}
