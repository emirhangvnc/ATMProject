using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class CityMessagesTR
    {
        private class Worker : CityMessagesStandart.CityWorker
        {
            internal override string City()
            {
                return "Şehir";
            }
            internal override string CityNameNotNull()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string City = worker.City();
        public static string CityNameNotNull = worker.CityNameNotNull();
        public static string CityListed = worker.CityListed();
        public static string CitiesListed = worker.CitiesListed();
        public static string CityAdded = worker.CityAdded();
        public static string CityDeleted = worker.CityDeleted();
        public static string CityUpdated = worker.CityUpdated();
        public static string CityNotFound = worker.CityNotFound();
    }
}