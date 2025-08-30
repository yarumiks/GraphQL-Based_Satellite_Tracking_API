using SatellitesQL.LocalDefinedSatellites;
using SatellitesQL.Response.Types;
using System.ComponentModel;
using System.Text.Json;
using System.Text.RegularExpressions;
using static SatellitesQL.Serfvice.SatelliteCategories;
using JsonType = SatellitesQL.LocalDefinedSatellites.JsonType;

namespace SatellitesQL.Serfvice
{
    public static class SatelliteCategories
    {

        public static List<JsonType> categoryType;

        //public static readonly Dictionary<SatelliteCategories.SatelliteCategory, string> EnumToJsonName = new()
        //{
        //    { SatelliteCategories.SatelliteCategory.ISS, "ISS" },
        //    { SatelliteCategories.SatelliteCategory.Weather, "Weather" },
        //    { SatelliteCategories.SatelliteCategory.NOAA, "NOAA" },
        //    { SatelliteCategories.SatelliteCategory.GOES, "GOES" },
        //    { SatelliteCategories.SatelliteCategory.EarthResources, "EarthResources" },
        //    { SatelliteCategories.SatelliteCategory.SearchAndRescue, "SearchAndRescue" },
        //    { SatelliteCategories.SatelliteCategory.DisasterMonitoring, "DisasterMonitoring" },
        //    { SatelliteCategories.SatelliteCategory.TrackingAndDataRelaySatelliteSystem, "TrackingAndDataRelaySatelliteSystem" },
        //    { SatelliteCategories.SatelliteCategory.Geostationary, "Geostationary" },
        //    { SatelliteCategories.SatelliteCategory.Intelsat, "Intelsat" },
        //    { SatelliteCategories.SatelliteCategory.Gorizont, "Gorizont" },
        //    { SatelliteCategories.SatelliteCategory.Raduga, "Raduga" },
        //    { SatelliteCategories.SatelliteCategory.Molniya, "Molniya" },
        //    { SatelliteCategories.SatelliteCategory.Iridium, "Iridium" },
        //    { SatelliteCategories.SatelliteCategory.Orbcomm, "Orbcomm" },
        //    { SatelliteCategories.SatelliteCategory.Globalstar, "Globalstar" },
        //    { SatelliteCategories.SatelliteCategory.AmateurRadio, "AmateurRadio" },
        //    { SatelliteCategories.SatelliteCategory.Experimental, "Experimental" },
        //    { SatelliteCategories.SatelliteCategory.GPSOperational, "GPSOperational" },
        //    { SatelliteCategories.SatelliteCategory.GlonassOperational, "GlonassOperational" },
        //    { SatelliteCategories.SatelliteCategory.Galileo, "Galileo" },
        //    { SatelliteCategories.SatelliteCategory.SatelliteBasedAugmentationSystem, "SatelliteBasedAugmentationSystem" },
        //    { SatelliteCategories.SatelliteCategory.NavyNavigationSatelliteSystem, "NavyNavigationSatelliteSystem" },
        //    { SatelliteCategories.SatelliteCategory.RussianLEONavigation, "RussianLEONavigation" },
        //    { SatelliteCategories.SatelliteCategory.SpaceAndEarthScience, "SpaceAndEarthScience" },
        //    { SatelliteCategories.SatelliteCategory.Geodetic, "Geodetic" },
        //    { SatelliteCategories.SatelliteCategory.Engineering, "Engineering" },
        //    { SatelliteCategories.SatelliteCategory.Education, "Education" },
        //    { SatelliteCategories.SatelliteCategory.Military, "Military" },
        //    { SatelliteCategories.SatelliteCategory.RadarCalibration, "RadarCalibration" },
        //    { SatelliteCategories.SatelliteCategory.CubeSats, "CubeSats" },
        //    { SatelliteCategories.SatelliteCategory.XMAndSirius, "XMAndSirius" },
        //    { SatelliteCategories.SatelliteCategory.TV, "TV" },
        //    { SatelliteCategories.SatelliteCategory.BeidouNavigationSystem, "BeidouNavigationSystem" },
        //    { SatelliteCategories.SatelliteCategory.Yaogan, "Yaogan" },
        //    { SatelliteCategories.SatelliteCategory.WestfordNeedles, "WestfordNeedles" },
        //    { SatelliteCategories.SatelliteCategory.Parus, "Parus" },
        //    { SatelliteCategories.SatelliteCategory.Strela, "Strela" },
        //    { SatelliteCategories.SatelliteCategory.Gonets, "Gonets" },
        //    { SatelliteCategories.SatelliteCategory.Tsiklon, "Tsiklon" },
        //    { SatelliteCategories.SatelliteCategory.Tsikada, "Tsikada" },
        //    { SatelliteCategories.SatelliteCategory.O3BNetworks, "O3BNetworks" },
        //    { SatelliteCategories.SatelliteCategory.Tselina, "Tselina" },
        //    { SatelliteCategories.SatelliteCategory.Celestis, "Celestis" },
        //    { SatelliteCategories.SatelliteCategory.IRNSS, "IRNSS" },
        //    { SatelliteCategories.SatelliteCategory.QZSS, "QZSS" },
        //    { SatelliteCategories.SatelliteCategory.Flock, "Flock" },
        //    { SatelliteCategories.SatelliteCategory.Lemur, "Lemur" },
        //    { SatelliteCategories.SatelliteCategory.GPSConstellation, "Global Positioning System(GPS) Constellation" },
        //    { SatelliteCategories.SatelliteCategory.GlonassConstellation, "GlonassConstellation" },
        //    { SatelliteCategories.SatelliteCategory.Starlink, "Starlink" },
        //    { SatelliteCategories.SatelliteCategory.OneWeb, "OneWeb" },
        //    { SatelliteCategories.SatelliteCategory.ChineseSpaceStation, "ChineseSpaceStation" },
        //    { SatelliteCategories.SatelliteCategory.Qianfan, "Qianfan" },
        //    { SatelliteCategories.SatelliteCategory.Kuiper, "Kuiper" }
        //};

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

}
