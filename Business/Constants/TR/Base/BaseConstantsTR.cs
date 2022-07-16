using BusinessLayer.Constants.Standart.Base;

namespace BusinessLayer.Constants.TR.Base
{
    public static class BaseConstantsTR
    {
        private class TRWorker : BaseConstantsStandart.BaseWorker
        {
            internal override string NotNull()
            {
                return "Boş Geçilemez";
            }
            internal override string Added()
            {
                return "Eklendi";
            }
            internal override string Deleted()
            {
                return "Silindi";
            }
            internal override string Updated()
            {
                return "Güncellendi";
            }
            internal override string Listed()
            {
                return "Listelendi";
            }
            internal override string Search()
            {
                return "Aranan";
            }
            internal override string LoginSuccessful()
            {
                return "Giriş Başarılı";
            }
            internal override string Summoned()
            {
                return "İstenilen";
            }
            internal override string AlreadyExists()
            {
                return "Zaten Mevcut";
            }
            internal override string NotFound()
            {
                return "Bulunamadı";
            }
            internal override string Name()
            {
                return "İsim";
            }
            internal override string ID()
            {
                return "Birincil Anahtar(ID)";
            }
            internal override string Created()
            {
                return "Oluşturuldu";
            }
            internal override string Max()
            {
                return "Maksimum";
            }
            internal override string Min()
            {
                return "Minimum";
            }
            internal override string Entered()
            {
                return "Girilebilir";
            }
            internal override string Code()
            {
                return "Kod";
            }
            internal override string Password()
            {
                return "Şifre";
            }
        }
        readonly static TRWorker worker = new TRWorker();
        internal static string NotNull = worker.NotNull();
        internal static string Added = worker.Added();
        internal static string Deleted = worker.Deleted();
        internal static string Updated = worker.Updated();
        internal static string Listed = worker.Listed();
        internal static string Search = worker.Search();
        internal static string LoginSuccessful = worker.LoginSuccessful();
        internal static string Summoned = worker.Summoned();
        internal static string AlreadyExists = worker.AlreadyExists();
        internal static string NotFound = worker.NotFound();
        internal static string Name = worker.Name();
        internal static string ID = worker.ID();
        internal static string Created = worker.Created();
        internal static string Max = worker.Max();
        internal static string Min = worker.Min();
        internal static string Entered = worker.Entered();
        internal static string Code = worker.Code();
        internal static string Password = worker.Password();
    }
}