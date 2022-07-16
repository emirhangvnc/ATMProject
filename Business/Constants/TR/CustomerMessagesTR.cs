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
            internal override string CustomerNotNull()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.NotNull}";
            }
            internal override string CustomerListed()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.Listed}";
            }
            internal override string CustomersListed()
            {
                return $"{CustomerMessagesTR.Customer}ler {BaseConstantsTR.Listed}";
            }
            internal override string CustomerAdded()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.Added}";
            }
            internal override string CustomerDeleted()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.Deleted}";
            }
            internal override string CustomerUpdated()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.Updated}";
            }
            internal override string CustomerNotFound()
            {
                return $"{CustomerMessagesTR.Customer} {BaseConstantsTR.NotFound}";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Customer = worker.Customer();
        public static string CustomerNotNull = worker.CustomerNotNull();
        public static string CustomerListed = worker.CustomerListed();
        public static string CustomersListed = worker.CustomersListed();
        public static string CustomerAdded = worker.CustomerAdded();
        public static string CustomerDeleted = worker.CustomerDeleted();
        public static string CustomerUpdated = worker.CustomerUpdated();
        public static string CustomerNotFound = worker.CustomerNotFound();
    }
}