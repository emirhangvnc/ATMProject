using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.TR.Base
{
    public static class BaseConstantsTR
    {
        private class TRWorker : BaseConstantsStandart.BaseWorker
        {
            public override string NotNull()
            {
                return "Boş Geçilemez";
            }
            public override string Added()
            {
                return "Eklendi";
            }
            public override string Deleted()
            {
                return "Silindi";
            }
            public override string Updated()
            {
                return "Güncellendi";
            }
            public override string Listed()
            {
                return "Listelendi";
            }
            public override string Search()
            {
                return "Aranan";
            }
        }
        readonly static TRWorker worker = new TRWorker();
        public static string NotNull = worker.NotNull();
        public static string Added = worker.Added();
        public static string Deleted = worker.Deleted();
        public static string Updated = worker.Updated();
        public static string Listed = worker.Listed();
        public static string Search = worker.Search();
        public static string LoginSuccessful = worker.LoginSuccessful();
        public static string Summoned = worker.Summoned();
        public static string AlreadyAvailable = worker.AlreadyAvailable();
        public static string NotFound = worker.NotFound();
        public static string Name = worker.Name();
        public static string Created = worker.Created();
    }
}