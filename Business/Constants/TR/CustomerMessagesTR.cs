using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class CustomerMessagesTR
    {
        private class Worker : CustomerMessagesStandart.CustomerWorker
        {
            internal override string Customer()
            {
                return "Müşteri";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Customer = worker.Customer();
        public static string CustomerNotNull = worker.CustomerNotNull();
        public static string CustomerIdNotNull = worker.CustomerIdNotNull();
        public static string CustomerListed = worker.CustomerListed();
        public static string CustomersListed = worker.CustomersListed();
        public static string CustomerAdded = worker.CustomerAdded();
        public static string CustomerDeleted = worker.CustomerDeleted();
        public static string CustomerUpdated = worker.CustomerUpdated();
        public static string CustomerNotFound = worker.CustomerNotFound();
    }
}