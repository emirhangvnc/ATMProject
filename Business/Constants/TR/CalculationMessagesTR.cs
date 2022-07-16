using BusinessLayer.Constants.Standart;
using BusinessLayer.Constants.Standart.Base;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR
{
    public static class CalculationMessagesTR
    {
        private class Worker : CalculationMessagesStandart.CalculationWorker
        {
        }
        readonly static Worker worker = new Worker();
        public static string Calculation = worker.Calculation();
        public static string CalculationListed = worker.CalculationListed();
        public static string CalculationsListed = worker.CalculationsListed();
    }
}