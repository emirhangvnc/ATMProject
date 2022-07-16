using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class CityMessagesStandart
    {
        internal class CityWorker
        {
            internal virtual string City()
            {
                return $"City";
            }
            internal virtual string CityNameNotNull()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Name} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string CitiesListed()
            {
                return $"Cities {BaseConstantsStandart.Listed}";
            }
            internal virtual string CityListed()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Listed}";
            }
            internal virtual string CityAdded()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Added}";
            }
            internal virtual string CityDeleted()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string CityUpdated()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.Updated}";
            }
            internal virtual string CityNotFound()
            {
                return $"{CityMessagesStandart.City} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static CityWorker worker = new CityWorker();
        internal static string City = worker.City();
        internal static string CityNameNotNull = worker.CityNameNotNull();
        internal static string CityListed = worker.CityListed();
        internal static string CitiesListed = worker.CitiesListed();
        internal static string CityAdded = worker.CityAdded();
        internal static string CityDeleted = worker.CityDeleted();
        internal static string CityUpdated = worker.CityUpdated();
        internal static string CityNotFound = worker.CityNotFound();
    }
}