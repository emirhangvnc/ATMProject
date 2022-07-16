using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class CountryMessagesStandart
    {
        internal class CountryWorker
        {
            internal virtual string Country()
            {
                return $"Country";
            }
            internal virtual string CountryNameNotNull()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string CountryListed()
            {
                return $"{CountryMessagesStandart.Country} {BaseConstantsStandart.Listed}";
            }
            internal virtual string CountriesListed()
            {
                return $"Cities {BaseConstantsStandart.Listed}";
            }
            internal virtual string CountryAdded()
            {
                return $"{CountryMessagesStandart.Country} {BaseConstantsStandart.Added}";
            }
            internal virtual string CountryDeleted()
            {
                return $"{CountryMessagesStandart.Country} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string CountryUpdated()
            {
                return $"{CountryMessagesStandart.Country} {BaseConstantsStandart.Updated}";
            }
            internal virtual string CountryNotFound()
            {
                return $"{CountryMessagesStandart.Country} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static CountryWorker worker = new CountryWorker();
        internal static string Country = worker.Country();
        internal static string CountryNameNotNull = worker.CountryNameNotNull();
        internal static string CountryListed = worker.CountryListed();
        internal static string CountriesListed = worker.CountriesListed();
        internal static string CountryAdded = worker.CountryAdded();
        internal static string CountryDeleted = worker.CountryDeleted();
        internal static string CountryUpdated = worker.CountryUpdated();
        internal static string CountryNotFound = worker.CountryNotFound();
    }
}