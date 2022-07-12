using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public class CustomerMessages
    {
        public static string Customer = $"Müşteri";
        public static string CustomerNotNull = $"{Customer} {BaseConstants.NotNull}";
        public static string CustomerIdNotNull = $"{Customer} Id {BaseConstants.NotNull}";
        public static string CustomersListed = $"{Customer}ler {BaseConstants.Listed}";
        public static string CustomerListed = $"{BaseConstants.Search} {Customer} {BaseConstants.Listed}";
        public static string CustomerAdded = $"{Customer} {BaseConstants.Added}";
        public static string CustomerDeleted = $"{Customer} {BaseConstants.Deleted}";
        public static string CustomerUpdated = $"{Customer} {BaseConstants.Updated}";
        public static string CustomerNotFound = $"{Customer} {BaseConstants.NotFound}";
        
    }
}