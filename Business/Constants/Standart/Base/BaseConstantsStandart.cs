
namespace BusinessLayer.Constants.Standart.Base
{
    public static class BaseConstantsStandart
    {
        public class BaseWorker
        {
            public virtual string NotNull()
            {
                return "Not Null";
            }
            public virtual string Added()
            {
                return "Added";
            }
            public virtual string Deleted()
            {
                return "Deleted";
            }
            public virtual string Updated()
            {
                return "Updated";
            }
            public virtual string Listed()
            {
                return "Listed";
            }
            public virtual string Search()
            {
                return "Search";
            }
            public virtual string LoginSuccessful()
            {
                return "Login Successful";
            }
            public virtual string Summoned()
            {
                return "Summoned";
            }
            public virtual string AlreadyAvailable()
            {
                return "Already Available";
            }
            public virtual string NotFound()
            {
                return "Not Found";
            }
            public virtual string Name()
            {
                return "Name";
            }
            public virtual string Created()
            {
                return "Created";
            }
        }
        readonly static BaseWorker worker = new BaseWorker();
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