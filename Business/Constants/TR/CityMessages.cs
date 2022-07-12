using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public class CityMessages
    {
        public static string City = "Şehir";
        public static string CityNameNotNull = $"{City} {BaseConstants.Name} {BaseConstants.NotNull}";
        public static string CitiesListed = $"{City}ler {BaseConstants.Listed}";
        public static string CityListed = $"{BaseConstants.Search} {City} {BaseConstants.Listed}";
        public static string CityAdded = $"{City} {BaseConstants.Added}";
        public static string CityDeleted = $"{City} {BaseConstants.Deleted}";
        public static string CityUpdated = $"{City} {BaseConstants.Updated}";
        public static string CityNotFound = $"{City} {BaseConstants.NotFound}";
    }
}