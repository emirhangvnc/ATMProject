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
            internal override string CountryNameNotNull()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
            internal override string CountryListed()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.Listed}";
            }
            internal override string CountriesListed()
            {
                return $"{CountryMessagesTR.Country}ler {BaseConstantsTR.Listed}";
            }
            internal override string CountryAdded()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.Added}";
            }
            internal override string CountryDeleted()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.Deleted}";
            }
            internal override string CountryUpdated()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.Updated}";
            }
            internal override string CountryNotFound()
            {
                return $"{CountryMessagesTR.Country} {BaseConstantsTR.NotFound}";
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