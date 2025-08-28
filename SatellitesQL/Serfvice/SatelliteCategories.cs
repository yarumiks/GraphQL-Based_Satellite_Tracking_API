using System.ComponentModel;
using static SatellitesQL.Serfvice.SatelliteCategories;

namespace SatellitesQL.Serfvice
{
        #region 

        //public static readonly Dictionary<string, int> CategoryIdMap = new()
        //{
        //    { "Amateur Radio", 18 },
        //    { "Beidou Navigation System", 35 },
        //    { "Brightest", 1 },
        //    { "Celestis", 45 },
        //    { "Chinese Space Station", 54 },
        //    { "CubeSats", 32 },
        //    { "Disaster monitoring", 8 },
        //    { "Earth resources", 6 },
        //    { "Education", 29 },
        //    { "Engineering", 28 },
        //    { "Experimental", 19 },
        //    { "Flock", 48 },
        //    { "Galileo", 22 },
        //    { "Geodetic", 27 },
        //    { "Geostationary", 10 },
        //    { "Global Positioning System (GPS) Constellation", 50 },
        //    { "Global Positioning System (GPS) Operational", 20 },
        //    { "Globalstar", 17 },
        //    { "Glonass Constellation", 51 },
        //    { "Glonass Operational", 21 },
        //    { "GOES", 5 },
        //    { "Gonets", 40 },
        //    { "Gorizont", 12 },
        //    { "Intelsat", 11 },
        //    { "Iridium", 15 },
        //    { "IRNSS", 46 },
        //    { "ISS", 2 },
        //    { "Kuiper", 56 },
        //    { "Lemur", 49 },
        //    { "Military", 30 },
        //    { "Molniya", 14 },
        //    { "Navy Navigation Satellite System", 24 },
        //    { "NOAA", 4 },
        //    { "O3B Networks", 43 },
        //    { "OneWeb", 53 },
        //    { "Orbcomm", 16 },
        //    { "Parus", 38 },
        //    { "Qianfan", 55 },
        //    { "QZSS", 47 },
        //    { "Radar Calibration", 31 },
        //    { "Raduga", 13 },
        //    { "Russian LEO Navigation", 25 },
        //    { "Satellite-Based Augmentation System", 23 },
        //    { "Search & rescue", 7 },
        //    { "Space & Earth Science", 26 },
        //    { "Starlink", 52 },
        //    { "Strela", 39 },
        //    { "Tracking and Data Relay Satellite System", 9 },
        //    { "Tselina", 44 },
        //    { "Tsikada", 42 },
        //    { "Tsiklon", 41 },
        //    { "TV", 34 },
        //    { "Weather", 3 },
        //    { "Westford Needles", 37 },
        //    { "XM and Sirius", 33 },
        //    { "Yaogan", 36 }
        //};
        //public static int GetCategoryId(string name) =>
        //CategoryIdMap.TryGetValue(name, out int id) ? id : 0;

        //public static string[] GetKeys()
        //{

        //    List<string> items = new();

        //    foreach (var item in CategoryIdMap.Keys) items.Add(item);
            
        //    return items.ToArray();
        //}
        #endregion
    public static class SatelliteCategories
    {

        [EnumType]
        public enum SatelliteCategory
        {
            ISS = 2,
            Weather = 3,
            NOAA = 4,
            GOES = 5,
            EarthResources = 6,
            SearchAndRescue = 7,
            DisasterMonitoring = 8,
            TrackingAndDataRelaySatelliteSystem = 9,
            Geostationary = 10,
            Intelsat = 11,
            Gorizont = 12,
            Raduga = 13,
            Molniya = 14,
            Iridium = 15,
            Orbcomm = 16,
            Globalstar = 17,
            AmateurRadio = 18,
            Experimental = 19,
            GPSOperational = 20,
            GlonassOperational = 21,
            Galileo = 22,
            SatelliteBasedAugmentationSystem = 23,
            NavyNavigationSatelliteSystem = 24,
            RussianLEONavigation = 25,
            SpaceAndEarthScience = 26,
            Geodetic = 27,
            Engineering = 28,
            Education = 29,
            Military = 30,
            RadarCalibration = 31,
            CubeSats = 32,
            XMAndSirius = 33,
            TV = 34,
            BeidouNavigationSystem = 35,
            Yaogan = 36,
            WestfordNeedles = 37,
            Parus = 38,
            Strela = 39,
            Gonets = 40,
            Tsiklon = 41,
            Tsikada = 42,
            O3BNetworks = 43,
            Tselina = 44,
            Celestis = 45,
            IRNSS = 46,
            QZSS = 47,
            Flock = 48,
            Lemur = 49,
            GPSConstellation = 50,
            GlonassConstellation = 51,
            Starlink = 52,
            OneWeb = 53,
            ChineseSpaceStation = 54,
            Qianfan = 55,
            Kuiper = 56
        }

        public static int GetCategoryIdByEnum(SatelliteCategory value)
        {
            return (int)value;
        }
    }

    public class SatelliteCategoryType : EnumType<SatelliteCategory>
    {
        protected override void Configure(IEnumTypeDescriptor<SatelliteCategory> descriptor)
        {
            descriptor.Value(SatelliteCategory.ISS).Name("ISS");
            descriptor.Value(SatelliteCategory.Weather).Name("Weather");
            descriptor.Value(SatelliteCategory.NOAA).Name("NOAA");
            descriptor.Value(SatelliteCategory.GOES).Name("GOES");
            descriptor.Value(SatelliteCategory.EarthResources).Name("EarthResources");
            descriptor.Value(SatelliteCategory.SearchAndRescue).Name("SearchAndRescue");
            descriptor.Value(SatelliteCategory.DisasterMonitoring).Name("DisasterMonitoring");
            descriptor.Value(SatelliteCategory.TrackingAndDataRelaySatelliteSystem).Name("TrackingAndDataRelaySatelliteSystem");
            descriptor.Value(SatelliteCategory.Geostationary).Name("Geostationary");
            descriptor.Value(SatelliteCategory.Intelsat).Name("Intelsat");
            descriptor.Value(SatelliteCategory.Gorizont).Name("Gorizont");
            descriptor.Value(SatelliteCategory.Raduga).Name("Raduga");
            descriptor.Value(SatelliteCategory.Molniya).Name("Molniya");
            descriptor.Value(SatelliteCategory.Iridium).Name("Iridium");
            descriptor.Value(SatelliteCategory.Orbcomm).Name("Orbcomm");
            descriptor.Value(SatelliteCategory.Globalstar).Name("Globalstar");
            descriptor.Value(SatelliteCategory.AmateurRadio).Name("AmateurRadio");
            descriptor.Value(SatelliteCategory.Experimental).Name("Experimental");
            descriptor.Value(SatelliteCategory.GPSOperational).Name("GPSOperational");
            descriptor.Value(SatelliteCategory.GlonassOperational).Name("GlonassOperational");
            descriptor.Value(SatelliteCategory.Galileo).Name("Galileo");
            descriptor.Value(SatelliteCategory.SatelliteBasedAugmentationSystem).Name("SatelliteBasedAugmentationSystem");
            descriptor.Value(SatelliteCategory.NavyNavigationSatelliteSystem).Name("NavyNavigationSatelliteSystem");
            descriptor.Value(SatelliteCategory.RussianLEONavigation).Name("RussianLEONavigation");
            descriptor.Value(SatelliteCategory.SpaceAndEarthScience).Name("SpaceAndEarthScience");
            descriptor.Value(SatelliteCategory.Geodetic).Name("Geodetic");
            descriptor.Value(SatelliteCategory.Engineering).Name("Engineering");
            descriptor.Value(SatelliteCategory.Education).Name("Education");
            descriptor.Value(SatelliteCategory.Military).Name("Military");
            descriptor.Value(SatelliteCategory.RadarCalibration).Name("RadarCalibration");
            descriptor.Value(SatelliteCategory.CubeSats).Name("CubeSats");
            descriptor.Value(SatelliteCategory.XMAndSirius).Name("XMAndSirius");
            descriptor.Value(SatelliteCategory.TV).Name("TV");
            descriptor.Value(SatelliteCategory.BeidouNavigationSystem).Name("BeidouNavigationSystem");
            descriptor.Value(SatelliteCategory.Yaogan).Name("Yaogan");
            descriptor.Value(SatelliteCategory.WestfordNeedles).Name("WestfordNeedles");
            descriptor.Value(SatelliteCategory.Parus).Name("Parus");
            descriptor.Value(SatelliteCategory.Strela).Name("Strela");
            descriptor.Value(SatelliteCategory.Gonets).Name("Gonets");
            descriptor.Value(SatelliteCategory.Tsiklon).Name("Tsiklon");
            descriptor.Value(SatelliteCategory.Tsikada).Name("Tsikada");
            descriptor.Value(SatelliteCategory.O3BNetworks).Name("O3BNetworks");
            descriptor.Value(SatelliteCategory.Tselina).Name("Tselina");
            descriptor.Value(SatelliteCategory.Celestis).Name("Celestis");
            descriptor.Value(SatelliteCategory.IRNSS).Name("IRNSS");
            descriptor.Value(SatelliteCategory.QZSS).Name("QZSS");
            descriptor.Value(SatelliteCategory.Flock).Name("Flock");
            descriptor.Value(SatelliteCategory.Lemur).Name("Lemur");
            descriptor.Value(SatelliteCategory.GPSConstellation).Name("GPSConstellation");
            descriptor.Value(SatelliteCategory.GlonassConstellation).Name("GlonassConstellation");
            descriptor.Value(SatelliteCategory.Starlink).Name("Starlink");
            descriptor.Value(SatelliteCategory.OneWeb).Name("OneWeb");
            descriptor.Value(SatelliteCategory.ChineseSpaceStation).Name("ChineseSpaceStation");
            descriptor.Value(SatelliteCategory.Qianfan).Name("Qianfan");
            descriptor.Value(SatelliteCategory.Kuiper).Name("Kuiper");
        }


    }

}
