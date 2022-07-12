using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public class CountryMessages
    {
        public static string Country = $"Ülke";
        public static string CountryNameNotNull = $"{Country} {BaseConstants.Name} {BaseConstants.NotNull}";
        public static string CountriesListed = $"{Country}ler {BaseConstants.Listed}";
        public static string CountryListed = $"{BaseConstants.Search} {Country} {BaseConstants.Listed}";
        public static string CountryAdded = $"{Country} {BaseConstants.Added}";
        public static string CountryDeleted = $"{Country} {BaseConstants.Deleted}";
        public static string CountryUpdated = $"{Country} {BaseConstants.Updated}";
        public static string CountryNotFound = $"{Country} {BaseConstants.NotFound}";
    }
}