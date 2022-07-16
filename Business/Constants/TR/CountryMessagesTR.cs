using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class CountryMessagesTR
    {
        private class Worker : CountryMessagesStandart.CountryWorker
        {
            internal override string Country()
            {
                return "Ülke";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Country = worker.Country();
        public static string CountryNameNotNull = worker.CountryNameNotNull();
        public static string CountryListed = worker.CountryListed();
        public static string CountriesListed = worker.CountriesListed();
        public static string CountryAdded = worker.CountryAdded();
        public static string CountryDeleted = worker.CountryDeleted();
        public static string CountryUpdated = worker.CountryUpdated();
        public static string CountryNotFound = worker.CountryNotFound();
    }
}