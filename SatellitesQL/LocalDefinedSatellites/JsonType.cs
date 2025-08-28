namespace SatellitesQL.LocalDefinedSatellites
{
    public class JsonType
    {
        public string? Name { get; set; }
        public List<int>? NoradIds { get; set; }
    }
    public class JsonValue 
    {
        public List<JsonType>? SatelliteCategories { get; set; }
    }
}
