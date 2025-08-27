using SatellitesQL.Response.Types.Abstract;

namespace SatellitesQL.Response.Types
{
    public class VisualPass : IPassBase
    {
        public float StartAz { get; set; }
        public string StartAzCompass { get; set; }
        public float StartEl { get; set; }
        public int StartUTC { get; set; }
        public float MaxAz { get; set; }
        public string MaxAzCompass { get; set; }
        public float MaxEl { get; set; }
        public int MaxUTC { get; set; }
        public float EndAz { get; set; }
        public string EndAzCompass { get; set; }
        public float? EndEl { get; set; }
        public int EndUTC { get; set; }
        public float Mag {  get; set; }
        public int Duration { get; set; }
       
    }
}
