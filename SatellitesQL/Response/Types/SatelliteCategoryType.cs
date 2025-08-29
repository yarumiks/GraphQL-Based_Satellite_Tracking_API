using static SatellitesQL.Serfvice.SatelliteCategories;

namespace SatellitesQL.Response.Types
{
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
