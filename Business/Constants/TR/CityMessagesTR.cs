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
            internal override string CityListed()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.Listed}";
            }
            internal override string CitiesListed()
            {
                return $"{CityMessagesTR.City}ler {BaseConstantsTR.Listed}";
            }
            internal override string CityAdded()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.Added}";
            }
            internal override string CityDeleted()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.Deleted}";
            }
            internal override string CityUpdated()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.Updated}";
            }
            internal override string CityNotFound()
            {
                return $"{CityMessagesTR.City} {BaseConstantsTR.NotFound}";
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