using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class CustomerMessagesStandart
    {
        internal class CustomerWorker
        {
            internal virtual string Customer()
            {
                return $"Customer";
            }
            internal virtual string CustomerNotNull()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.NotNull}";
            }
            internal virtual string CustomersListed()
            {
                return $"Customers {BaseConstantsStandart.Listed}";
            }
            internal virtual string CustomerListed()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.Listed}";
            }
            internal virtual string CustomerAdded()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.Added}";
            }
            internal virtual string CustomerDeleted()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.Deleted}";
            }
            internal virtual string CustomerUpdated()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.Updated}";
            }
            internal virtual string CustomerNotFound()
            {
                return $"{CustomerMessagesStandart.Customer} {BaseConstantsStandart.NotFound}";
            }
        }
        readonly static CustomerWorker worker = new CustomerWorker();
        internal static string Customer = worker.Customer();
        internal static string CustomerNotNull = worker.CustomerNotNull();
        internal static string CustomerListed = worker.CustomerListed();
        internal static string CustomersListed = worker.CustomersListed();
        internal static string CustomerAdded = worker.CustomerAdded();
        internal static string CustomerDeleted = worker.CustomerDeleted();
        internal static string CustomerUpdated = worker.CustomerUpdated();
        internal static string CustomerNotFound = worker.CustomerNotFound();
    }
}