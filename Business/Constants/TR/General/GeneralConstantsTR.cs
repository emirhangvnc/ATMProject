
using BusinessLayer.Constants.Standart.General;
using BusinessLayer.Constants.TR.Base;

namespace BusinessLayer.Constants.TR.General
{
    public static class GeneralConstantsTR
    {
        private class Worker : GeneralConstantsStandart.GeneralWorker
        {
            internal override string Character()
            {
                return $"Karakter";
            }
            internal override string Max50Character()
            {
                return $"{BaseConstantsTR.Max} 50 {GeneralConstantsTR.Character} {BaseConstantsTR.Entered}";
            }
            internal override string Max30Character()
            {
                return $"{BaseConstantsTR.Max} 30 {GeneralConstantsTR.Character} {BaseConstantsTR.Entered}";
            }
            internal override string Max20Character()
            {
                return $"{BaseConstantsTR.Max} 20 {GeneralConstantsTR.Character} {BaseConstantsTR.Entered}";
            }
            internal override string InvalidFileExtension()
            {
                return $"{BaseConstantsTR.Invalid} {BaseConstantsTR.File} {BaseConstantsTR.Extension}sı";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Character = worker.Character();
        public static string Max50Character = worker.Max50Character();
        public static string Max30Character = worker.Max30Character();
        public static string Max20Character = worker.Max20Character();
        public static string[] ValidImageFileTypes = GeneralConstantsStandart.ValidImageFileTypes;
        public static string InvalidFileExtension = worker.InvalidFileExtension();
    }
}