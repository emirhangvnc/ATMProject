using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.Standart
{
    internal static class CalculationMessagesStandart
    {
        internal class CalculationWorker
        {
            internal virtual string Calculation()
            {
                return $"Calculation";
            }
            internal virtual string CalculationListed()
            {
                return $"{BaseConstantsStandart.Search} {CalculationMessagesStandart.Calculation} {BaseConstantsStandart.Listed}";
            }
            internal virtual string CalculationsListed()
            {
                return $"{CalculationMessagesStandart.Calculation} {BaseConstantsStandart.Listed}";
            }
        }
        readonly static CalculationWorker worker = new CalculationWorker();
        internal static string Calculation = worker.Calculation();
        internal static string CalculationsListed = worker.CalculationsListed();
        internal static string CalculationListed = worker.CalculationListed();
    }
}